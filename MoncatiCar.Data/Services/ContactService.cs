using AutoMapper;
using DocumentFormat.OpenXml.Packaging;
using MocatiCar.Core.SeedWorks;
using MocatiCar.Core.Services;

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
    }
}
