using System;
using System.ComponentModel.DataAnnotations;

namespace EF6_MVC5_Example.ViewModels
{
    public class EnrollmentDateGroup
    {
        [DataType(DataType.Date)]
        public DateTime? EnrollmentDate { get; set; }
        public int StudentCount { get; set; }
    }
}