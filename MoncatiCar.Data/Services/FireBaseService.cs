using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Storage.V1;
using MocatiCar.Core.Services;
using Spire.Doc;
using Document = Spire.Doc.Document;

namespace MoncatiCar.Data.Services
{
    public class FireBaseService : IFireBaseService
    {
        private readonly string _bucketName = "moncatiproject.appspot.com";  // Replace with your Firebase Storage bucket
        private readonly StorageClient _storageClient;

        public FireBaseService()
        {
            string credentialPath = "F:/GitSource/moncatiproject-firebase-adminsdk-kc6fn-ea9c866bbc.json";

            // Khởi tạo Firebase Admin SDK
            FirebaseApp.Create(new AppOptions()
            {
                Credential = GoogleCredential.FromFile(credentialPath),
            });
            GoogleCredential googleCredential = GoogleCredential.FromFile(credentialPath);

            _storageClient = StorageClient.Create(googleCredential);
        }

        public void AddUserInfoToDocx(MemoryStream docxStream, Dictionary<string, string> userInfo)
        {
            using (WordprocessingDocument wordDoc = WordprocessingDocument.Open(docxStream, true))
            {
                // Get the main document part
                MainDocumentPart mainPart = wordDoc.MainDocumentPart;

                // Get the document's text body
                var body = mainPart.Document.Body;

                // Collect the text from the document
                foreach (var paragraph in body.Elements<Paragraph>())
                {
                    string fullText = "";
                    List<Text> textElements = new List<Text>();

                    // Collect all the text elements in the paragraph
                    foreach (var run in paragraph.Elements<Run>())
                    {
                        foreach (var text in run.Elements<Text>())
                        {
                            fullText += text.Text;
                            textElements.Add(text);  // Add all text elements to modify later
                        }
                    }

                    // Perform replacements on the combined text
                    foreach (var replacement in userInfo)
                    {
                        if (fullText.Contains(replacement.Key))
                        {
                            fullText = fullText.Replace(replacement.Key, replacement.Value);
                        }
                    }

                    // Now, split the modified text back into the original text elements
                    int textIndex = 0;
                    foreach (var text in textElements)
                    {
                        var textLength = text.Text.Length;
                        if (textIndex + textLength <= fullText.Length)
                        {
                            text.Text = fullText.Substring(textIndex, textLength);  // Assign back the corresponding part of the replaced text
                            textIndex += textLength;
                        }
                        else
                        {
                            text.Text = fullText.Substring(textIndex);
                            break;
                        }
                    }
                }

                // Save the changes
                mainPart.Document.Save();
            }
        }


        public MemoryStream ConvertDocxToPdf(MemoryStream docxStream)
        {
            // Load the DOCX file into Spire.Doc's Document object
            Document document = new Document();
            document.LoadFromStream(docxStream, FileFormat.Docx);

            // Create a MemoryStream to hold the converted PDF
            MemoryStream pdfStream = new MemoryStream();

            // Convert the DOCX to PDF and save the PDF to the MemoryStream
            document.SaveToStream(pdfStream, FileFormat.PDF);
            pdfStream.Position = 0;  // Reset the stream position

            return pdfStream;  // Return the MemoryStream containing the PDF
        }

        public async Task<MemoryStream> DownloadDocxTemplateFromFirebase(string fileName)
        {
            MemoryStream memoryStream = new MemoryStream();
            try
            {
                // Download the file from Firebase Storage to a MemoryStream
                await _storageClient.DownloadObjectAsync(_bucketName, fileName, memoryStream);

                memoryStream.Position = 0;  // Reset the stream position for further operations
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error downloading file: {ex.Message}");
                throw;  // Re-throw the exception to handle it later or log it            }

            }
            return memoryStream;

        }

        public async Task<string> UploadPdfToFirebase(MemoryStream memoryStream, string fileName)
        {
            // Define the path where the file will be stored in the bucket
            var objectName = $"uploads/{fileName}";

            // Reset the position of the MemoryStream to the beginning before upload
            memoryStream.Position = 0;

            // Upload the file from MemoryStream to Firebase Storage
            await _storageClient.UploadObjectAsync(_bucketName, objectName, "application/pdf", memoryStream);

            var obj = await _storageClient.GetObjectAsync(_bucketName, objectName);

            // Đặt lại ContentDisposition là inline để tệp hiển thị thay vì tải xuống
            obj.ContentDisposition = "inline";

            // (Tùy chọn) Đảm bảo Content-Type vẫn là PDF, chỉ cần nếu không chắc MIME type
            obj.ContentType = "application/pdf"; // Có thể bỏ qua nếu chắc chắn upload đúng ContentType

            // Cập nhật metadata với Content-Disposition là inline
            await _storageClient.UpdateObjectAsync(obj);

            // Return the public URL of the uploaded file
            return $"https://storage.googleapis.com/{_bucketName}/{objectName}";
        }
    }
}
