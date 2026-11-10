using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET69_EF_Assignment_2.Models
{
    internal class Event
    {

        public int EventID { get; set; }
        public string Title { get; set; }
        public string DetailedDescription { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int MaxAttendedNumber { get; set; }

        public int OrganizerID { get; set; }
        public Organizer Organizer { get; set; } = new Organizer();


    
    
    }
}
