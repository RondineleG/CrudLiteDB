using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudLiteDB.Models;
using LiteDB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CrudLiteDB.Pages
{
    public class DeleteModel : PageModel
    {
        [BindProperty]
        public Cliente Cliente { get; set; }

        public void OnGet(int id)
        {
            using (var db = new LiteDatabase(@"CrudLiteDB.db"))
            {
                Cliente = db.GetCollection<Cliente>().FindById(id);
            }
        }

        public IActionResult OnPost()
        {
            using (var db = new LiteDatabase(@"CrudLiteDB.db"))
            {
                var bugs = db.GetCollection<Cliente>();
                bugs.Delete(Cliente.Id);

            }
            return RedirectToPage("./index");

        }
    }
}