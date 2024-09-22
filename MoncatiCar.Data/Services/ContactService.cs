using AutoMapper;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using MocatiCar.Core.SeedWorks;
using MocatiCar.Core.Services;
using Spire.Doc;

namespace MoncatiCar.Data.Services
{
    public class ContactService : IContactService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        public ContactService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public byte[] ConverDocxToPdf(string filePath)
        {
            // Load the Word document
            Spire.Doc.Document document = new Spire.Doc.Document();
            document.LoadFromFile(filePath);

            // Save the document as a PDF in a memory stream
            using (MemoryStream ms = new MemoryStream())
            {
                document.SaveToStream(ms, FileFormat.PDF);
                return ms.ToArray();
            }
        }

        public async Task<string> GenerateContract()
        {
            string templatePath = "F:/GitSource/ContactForRental.docx";
            string ouputPath = "F:/GitSource/filled_contract.docx";
            File.Copy(templatePath, ouputPath, true);
            using (WordprocessingDocument wordDoc = WordprocessingDocument.Open(ouputPath, true))
            {
                // Get the main document part
                MainDocumentPart mainPart = wordDoc.MainDocumentPart;

                // Get the document's text
                string docText = null;
                using (StreamReader reader = new StreamReader(mainPart.GetStream()))
                {
                    docText = reader.ReadToEnd();
                }

                // Replace placeholders with actual values
                docText = docText.Replace("{TestYou}", "Amenhehe");


                // Write back the modified text
                using (StreamWriter writer = new StreamWriter(mainPart.GetStream(FileMode.Create)))
                {
                    writer.Write(docText);
                }
                return ouputPath;

            }

        }

        public void InsertDataInFile(string filepath, Dictionary<string, string> replacements)
        {
            using (WordprocessingDocument wordDoc = WordprocessingDocument.Open(filepath, true))
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
                    foreach (var replacement in replacements)
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
    }
}
