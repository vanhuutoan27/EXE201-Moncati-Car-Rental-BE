namespace MocatiCar.Core.Services
{
    public interface IFireBaseService
    {
        Task<MemoryStream> DownloadDocxTemplateFromFirebase(string fileName);
        void AddUserInfoToDocx(MemoryStream docxStream, Dictionary<string, string> userInfo);
        public MemoryStream ConvertDocxToPdf(MemoryStream docxStream);
        public Task<string> UploadPdfToFirebase(MemoryStream memoryStream, string fileName);
    }
}
