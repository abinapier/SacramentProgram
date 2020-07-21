using SacramentProgram.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace SacramentProgram.Pages.Speakers
{
    public class MeetingPickerPageModel : PageModel
    {
        public SelectList MeetingDatesDropDown { get; set; }

        public void PopulateMeetingsDropDownList(SacramentProgramContext _context,
            object selectedMeeting = null)
        {
            var meetingQuery = from m in _context.Meeting
                                   orderby m.MeetingDate 
                                   select m.MeetingDate;

            MeetingDatesDropDown = new SelectList(meetingQuery,
                        "ID", "MeetingDate", selectedMeeting);
        }
    }
}
