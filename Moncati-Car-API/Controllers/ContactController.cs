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
        [HttpGet]
        public async Task<IActionResult> GenerateContractAsync()
        {
            string generated = await _serviceManager.ContactService.GenerateContract();
            return PhysicalFile(generated, "application/vnd.openxmlformats-officedocument.wordprocessingml.document", "Contract.docx");
        }




    }
}
