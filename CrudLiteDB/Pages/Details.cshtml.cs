using CrudLiteDB.Models;
using LiteDB;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CrudLiteDB.Pages
{
    public class DetailsModel : PageModel
    {

      
        public Cliente Cliente { get; set; }

        public void OnGet(int id)
        {
            using (var db = new LiteDatabase(@"Cliente.db"))
            {
                Cliente = db.GetCollection<Cliente>().FindById(id);
            }
        }
    }
}