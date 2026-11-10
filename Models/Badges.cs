using System;
using System.Collections.Generic;
using System.Text;
using G_NET69_EF_Assignment_2.Models.Enums;
namespace G_NET69_EF_Assignment_2.Models
{
    internal class Badge
    {
        public int BadgeNumber { get; set; }
        public DateTime IssueDate { get; set; }
        public BadgeTie BadgeTie { get; set; }

        public int AttendeeID;
        public Attendee Attendee { get; set; } = new Attendee();

    }
}
