using CrudLiteDB.Common;
using CrudLiteDB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace CrudLiteDB.Pages
{
    public class IndexModel : PageModel
    {
        public IEnumerable<Cliente> Clientes { get; set; }
        public void OnGet([FromServices]LiteDbContext db)
        {

            var clientes = db.Context.GetCollection<Cliente>();
            Clientes = clientes.FindAll();

        }
    }
}