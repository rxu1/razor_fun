using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RazorFun.Controllers
{
  public class RazorFunController : Controller
  {
    [HttpGet]       //type of request
    [Route("")]     //associated route string (exclude the leading /)
    public ViewResult Index()
    {
      System.Console.WriteLine("Working!");
      return View("Index");
    }
  }
}