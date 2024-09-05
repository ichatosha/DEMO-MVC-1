using DEMO_MVC_1.Models;
using Microsoft.AspNetCore.Mvc;


namespace DEMO_MVC_1.Controllers
{
    public class MoviesController : Controller
    {
        // Actions Parameters Binding : (In Order) when you enter the parameter in url :
        // 1. Form From html with the same parameters like Id 
        // 2. Segment with the same name of the parameters (segment => like app.MapController.Route) with pattern and name
        // 3. Query String / Query Parameters :: Like => ?id=5%name=abc
        // 4. File with the name of the parametrs



        // actions : public non static functions
        // the all actions are inherit from one interface called [IActionResult]
        public IActionResult DefultAction()
        {
            return Content("Default Path!");
        }

        [HttpGet]
        [ActionName("Select")]
        public IActionResult GetMovie(int? id , string name , Movie movie)
        {
            return Content($"Id: {id} , Name: {name}" , "text/html");
        }




        public IActionResult Test(string id)
        {
            ContentResult result= new ContentResult();

            result.Content = $"id : {id}";
            result.ContentType = "text/html";  // to html style
            result.ContentType = "object/pdf";  // to pdf

            return result;
        }

        // 
        public IActionResult Test1(int? id) // all the actions result inherit from one class is ActionResult
        {
            if (id is null)
            {
                //RedirectResult result = new RedirectResult("https://github.com/ichatosha");
                //return result;
                return Redirect("https://github.com/ichatosha");
            }
            else
            {

                //RedirectToActionResult result = new RedirectToActionResult("GetMovie", "Movies", new { id = "Hesham" });
                //return result;

                return RedirectToAction("GetMovie", "Movies", new { id = "Hesham" });

            }
        }


        public IActionResult Test2(int id)
        {
            RedirectResult result;
            if (id == 1)
            {
                result = new RedirectResult("https://github.com/ichatosha");
                result = new RedirectResult("https://github.com/ichatosha");
            }
            else
            {
                result = new RedirectResult("");
            }

            return result;


        }
    }
}
 