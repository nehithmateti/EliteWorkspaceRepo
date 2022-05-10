using System;
using System.Collections.Generic;

namespace MySecondProject.Models
{
    public partial class TblStudentdetail
    {
        public long Sno { get; set; }
        public long SId { get; set; }
        public string? SFirstname { get; set; }
        public string? SLastname { get; set; }
        public int? SAge { get; set; }
        public string? SGender { get; set; }
        public string? SCourse { get; set; }
        public string? SAddress { get; set; }
        public long? SPhone { get; set; }
        public DateTime? Dob { get; set; }
        public DateTime? DateOfJoining { get; set; }
    }
}
