using BusinessObjects.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Repository;

namespace PRN231PE_FA22_StudentCode.Controllers
{
    public class PropertyProfileController : ODataController
    {
        private PRN231PE_FA22_StudentCodeContext context;
        private readonly IPropertyProfileRepository repo;

        public PropertyProfileController(IPropertyProfileRepository p)
        {
            repo = p;
        }

        //[HttpGet]
        //[Route("GetAll")]
        [EnableQuery]
        public async Task<IActionResult> GetAllBook()
        {
            var p = await repo.GetAllPropertyProfile();
            return Ok(p);
        }



    }
}
