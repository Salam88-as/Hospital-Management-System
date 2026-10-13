using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HospitalManagementSystem.Models
{
    public class Ward
    {
        [Key]
        public int WardId { get; set; }

        [Required, StringLength(100)]
        public string WardName { get; set; }

        [Required, StringLength(50)]
        public string WardType { get; set; }

        public int TotalBeds { get; set; }

        public int AvailableBeds { get; set; }

        [StringLength(50)]
        public string FloorNumber { get; set; }

        public virtual ICollection<Room> Rooms { get; set; }
    }
}