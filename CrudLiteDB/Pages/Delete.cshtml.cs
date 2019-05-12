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
                var clientes = db.GetCollection<Cliente>();
                clientes.Delete(Cliente.ClienteId);

            }
            return RedirectToPage("./index");

        }
    }
}