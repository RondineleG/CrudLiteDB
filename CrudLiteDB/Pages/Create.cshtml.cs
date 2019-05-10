using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudLiteDB.Common;
using CrudLiteDB.Models;
using LiteDB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CrudLiteDB.Pages
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Cliente Cliente { get; set; }

        private readonly LiteDbContext _db;

        public CreateModel(LiteDbContext db)
        {
            _db = db;
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var bugs = _db.Context.GetCollection<Cliente>();
            bugs.Insert(Cliente);

            TempData["message"] = $"Novo Cliente Cadastrado : {Cliente.Nome}";

            return RedirectToPage("./index");

        }
    }
}