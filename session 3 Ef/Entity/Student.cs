using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_3_Ef.Entity
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Stud_Cour> Course { get; set; }
    }
}
