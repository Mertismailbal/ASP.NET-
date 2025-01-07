using ASP.NET_LEARNİNG.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_LEARNİNG.Controllers
{
    public class HomeController : Controller
    {
        // public IEnumerable<Person> Index()
        // {
        //    return new List<Person>()
        //    {
        //        new Person(){FirstName="mert",LastName="Bal"},
        //        new Person(){FirstName="Duygu",LastName="Bal"}
        //    };
        // }


        //public class Person
        //{
        //    public  string FirstName { get; set; }
        //    public string  LastName { get; set; }
        //}


        //public IActionResult Index()
        //{
        //    return View();//Parametresiz olursa direkt default olarak views içerisinde HomeController oldugu için Home adında bir dosya arar ve metot adında bir RazorView sayfası arar.
        //}


        //public IActionResult Index()
        //{
        //    return View("Index1");//Böyle olursa parametre adındaki view sayfasıan gidiyor.
        //}

       
        
        public IActionResult Index()
        {
            
            return View(RepositoryContext.GetProducts());//Böyle olur ise de verdiğimiz modeli döndürüyor ancak onu view da göstermemiz gerekiyor.
        }
    }
}
