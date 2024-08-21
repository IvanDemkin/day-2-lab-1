using Microsoft.AspNetCore.Mvc;
using ControllersProj.Filters;

namespace ControllersProj.Controllers
{
   // [MyActionFilter]
    public class MyController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public ContentResult ParamsObject(Models.Person p)
        {
            var c = new ContentResult();
            c.Content = $" <h3>name: {p.Name} age: {p.Description}</h3>";
            c.ContentType = "text/html";

            return c;
        }

        [ActionName("Json")]
        public IActionResult JsonAction(Models.Person p)
        {            
            return this.Json(p);
        }

        public IActionResult YaLink()
        {
            return this.Redirect("http://ya.ru");
        }

        public IActionResult GetFile()
        {
            string s = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "test.txt");
            return PhysicalFile(s, "text/plain");
        }

       
        public IActionResult somePage()
        {
            return View();
        } 
    }
}
