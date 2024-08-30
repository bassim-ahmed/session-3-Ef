using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertance_Example.Model
{
    internal class PartTimeEmployee:Employee
    {
        public int NumberOfHour {  get; set; }
        public double HourRate { get; set; }
    }
}
