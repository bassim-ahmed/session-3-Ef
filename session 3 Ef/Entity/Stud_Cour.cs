﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_3_Ef.Entity
{
    public class Stud_Cour
    {
        public int StudentId {  get; set; }
        public int CourseId { get; set; }
        public  virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
        public double Grade { get; set; }
    }
}
