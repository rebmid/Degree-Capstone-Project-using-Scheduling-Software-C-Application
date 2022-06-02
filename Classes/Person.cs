using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleProgram.Classes
{
    public abstract class Person
    {
        public byte Active { get; set; }
        public DateTime CreateDate { get; set; }
    }

}

