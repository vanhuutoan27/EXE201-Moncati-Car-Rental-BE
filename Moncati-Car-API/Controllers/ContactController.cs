using Microsoft.AspNetCore.Mvc;
using MocatiCar.Core.SeedWorks;

namespace Moncati_Car_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public ContactController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }
        [HttpGet("get-file-by-rentalId")]
        public async Task<IActionResult> GenerateContractAsync([FromQuery] string filePath)
        {
            //if (!System.IO.File.Exists(filePath))
            //{
            //    return NotFound("File not found.");
            //}
            if (Path.GetExtension(filePath).ToLower() != ".docx")
            {
                return BadRequest("The provided file is not a DOCX file.");
            }
            byte[] pdfBytes;
            try
            {
                pdfBytes = _serviceManager.ContactService.ConverDocxToPdf(filePath);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred during the conversion: {ex.Message}");
            }
            return File(pdfBytes, "application/pdf", "contact_document.pdf");

        }

        [HttpPost("fill-contract")]
        public IActionResult FillContract()
        {
            // Example data for replacements
            var replacements = new Dictionary<string, string>
            {
            { "{TestYou}", "Ahihi" },
                { "{Representative}", "xinchao"}
            };

            // Path to your Word template
            string templateFilePath = "F:/GitSource/ContactForRental.docx";
            string outputFilePath = "F:/GitSource/filledContact.docx";

            System.IO.File.Copy(templateFilePath, outputFilePath, true);

            // Call the service to replace the text in the document
            _serviceManager.ContactService.InsertDataInFile(outputFilePath, replacements);
            var fileBytes = System.IO.File.ReadAllBytes(outputFilePath);

            // Return a success response
            return File(fileBytes, "application/vnd.openxmlformats-officedocument.wordprocessingml.document", "Contract.docx");


        }
    }
}
