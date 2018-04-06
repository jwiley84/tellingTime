using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace timeDate.Controllers //remember to update your namespace
{
    public class timeDateController : Controller //"HelloController" must match file name (ie HelloController.cs)
    {
        [HttpGet]
        
        [Route("")] 
        public IActionResult Method(string Name)
        {
                return View("Index");
        }
    }
}