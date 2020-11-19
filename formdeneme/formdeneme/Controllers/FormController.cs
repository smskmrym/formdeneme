using System;
using formdeneme.Models.DomainModels;
using Microsoft.AspNetCore.Mvc;

namespace formdeneme.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Index()
        {
            var book = new Form();
            book.Title = "";
            book.Description = "";
            book.SamplePage = "";
            book.AuthorEmail = "";
            book.AuthorPhone = "";

            return View(book);
        }

        public IActionResult Create()
        {
            return View(null);
        }

        [HttpPost]
        public IActionResult Create(Form book)
        {
            if (ModelState.IsValid == true)
            {
                // business logic ...
            }
            else
            {
                // let user re-input the data
            }

            return new JsonResult(book);
        }

        [HttpPost]
        public IActionResult Update(Form book)
        {
            if (ModelState.IsValid == true)
            {
                // business logic ...
            }
            else
            {
                // let user re-input the data
            }

            return new JsonResult(book);
        }
    }
}