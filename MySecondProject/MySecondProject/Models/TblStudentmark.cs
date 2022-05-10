using System;
using System.Collections.Generic;

namespace MySecondProject.Models
{
    public partial class TblStudentmark
    {
        public int Serialno { get; set; }
        public long StudentId { get; set; }
        public decimal? SFeespaid { get; set; }
        public int? SMathsmarks { get; set; }
        public int? SPhysicsmarks { get; set; }
        public int? SChemistrymarks { get; set; }
        public int? SSciencemarks { get; set; }
        public int? SEnglishmarks { get; set; }
        public int? STotalmarks { get; set; }
        public double? SPercentage { get; set; }

        public virtual TblStudentdetail Student { get; set; } = null!;
    }
}
