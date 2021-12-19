using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Blazor344.Models
{
    public class Student
    {
        public string studentID { get; set; }

        public string firstName{ get; set; }

        public string lastName{ get; set; }

        public DateTime enrollmentDate{ get; set; }
    }
}