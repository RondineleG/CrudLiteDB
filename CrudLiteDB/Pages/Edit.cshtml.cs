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
    public class EditModel : PageModel
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
            if (!ModelState.IsValid)
            {
                return Page();
            }

            using (var db = new LiteDatabase(@"bug.db"))
            {
                var bugs = db.GetCollection<Cliente>();
                bugs.Update(Cliente);

            }
            return RedirectToPage("./index");

        }
    }
}