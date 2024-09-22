namespace MocatiCar.Core.Services
{
    public interface IContactService
    {
        Task<string> GenerateContract();
        void InsertDataInFile(string filepath, Dictionary<string, string> replacements);
        public byte[] ConverDocxToPdf(string filePath);
    }
}
