using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace G_NET69_EF_Assignment_2.Models
{
    internal class Attendee
    {
        [Key]
        public int AttendeeID { get; set; }

        [Required]
        [MaxLength(150)]
        public string FullName { get; set; }

        [Required]
        [MaxLength(200)]
        public string Email { get; set; }

        [Required]
        [MaxLength(150)]
        public string Street { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string City { get; set; }

        [Required]
        [MaxLength (100)]
        public string Country { get; set; }

        [Required]
        [MaxLength(20)]
        [Column("ZipCode")]
        public string postalCode { get; set; }

        [NotMapped]
        public string FullAddress { get {

                return $"{Street}, {City}, {Country}, {postalCode}"; 

            } }

        public Badge badge { get; set; } = new Badge();


    }
}
