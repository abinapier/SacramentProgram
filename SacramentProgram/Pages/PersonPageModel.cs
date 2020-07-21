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
        public SelectList SongDropDown { get; set; }
        public SelectList MusicNumDropDown { get; set; }

        public void PopulatePersonDropDownList(SacramentProgramContext _context)
        {
            var personsQuery = from d in _context.Person
                                   orderby d.LastName // Sort by name.
                                   select d;

            PersonDropDown = new SelectList(personsQuery,
                        "ID", "FullName");
        }

        public void PopulateSongDropDownList(SacramentProgramContext _context)
        {
            var songsQuery = from d in _context.Song
                               orderby d.PageNum // Sort by name.
                               select d;

            SongDropDown = new SelectList(songsQuery,
                        "ID", "Name");
        }

        

        public void PopulateMusicNumDropDownList(SacramentProgramContext _context)
        {
            var musicQuery = from d in _context.MusicalNum
                             orderby d.Performer // Sort by name.
                             select d;

            MusicNumDropDown = new SelectList(musicQuery,
                        "ID", "FullPerformance");
        }
    }
}