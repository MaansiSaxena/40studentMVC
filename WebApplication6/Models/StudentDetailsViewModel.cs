using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication6.Models
{
    public class StudentDetailsViewModel
    {
        public Student student { get; set; }
        public Address address { get; set; }
        public string Title { get; set; }
        public string Header { get; set; }
    }
}
