using SacramentProgram.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace SacramentProgram.Pages.Meetings
{
    public class PersonPageModel : PageModel
    {
        public SelectList PersonDropDown { get; set; }

        public void PopulatePersonDropDownList(SacramentProgramContext _context)
        {
            var personsQuery = from d in _context.Person
                                   orderby d.LastName // Sort by name.
                                   select d;

            PersonDropDown = new SelectList(personsQuery,
                        "ID", "FullName");
        }
    }
}