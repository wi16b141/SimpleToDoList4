using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleToDoList4.Models
{
    public class ToDo
    {
        //properties
        public string Description { get; set; }
        public bool Done { get; set; }

        //constructors
        public ToDo(string description, bool done)
        {
            Description = description;
            Done = done;
        }
    }
}
