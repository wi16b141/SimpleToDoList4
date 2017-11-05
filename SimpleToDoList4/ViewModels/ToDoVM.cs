using SimpleToDoList4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleToDoList4.ViewModels
{
    public class ToDoVM
    {
        //properties
        private ToDo toDo;

        public string Description
        {
            get { return toDo.Description; }
            set { toDo.Description = value; }
        }

        public bool Done
        {
            get { return toDo.Done; }
            set { toDo.Done = value; }
        }

        //constructor
        public ToDoVM(string description, bool done)
        {
            toDo = new ToDo(description, done);
        }

    }
}
