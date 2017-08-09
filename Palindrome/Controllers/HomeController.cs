using Microsoft.AspNetCore.Mvc;
using Palindrome.Models;
using System.Collections.Generic;
using System;
namespace Palindrome.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
    [HttpPost("/result")]
    public ActionResult FindPalindrome()
    {
      PalindromeClass pmd = new PalindromeClass(Request.Form["input"]);
      return View("Index",pmd);
    }
  }
}
