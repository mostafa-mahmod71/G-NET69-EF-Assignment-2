using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET69_EF_Assignment_2.Models
{
    internal class OrganizerProfile
    {
        public int OrganizerProfID { get; set; }
        public string Biography { get; set; }
        public string WebSite { get; set; }
        public string Logo { get; set; }
        public int OrganizerID { get; set; }
        public Organizer organizer { get; set; } = new Organizer(); // NotNull Required

    }
}
