using SimpleToDoList4.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleToDoList4.ViewModels
{
    class MainViewModel
    {
        //properties
        private string newTaskDescription = "";

        public string NewTaskDescription
        {
            get { return newTaskDescription; }
            set { newTaskDescription = value; }
        }

        private ObservableCollection<ToDoVM> toDoList = new ObservableCollection<ToDoVM>();

        public ObservableCollection<ToDoVM> ToDoList
        {
            get { return toDoList; }
            set { toDoList = value; }
        }

        private RelayCommand addBtnClickedCommand;

        public RelayCommand AddBtnClickedCommand
        {
            get { return addBtnClickedCommand; }
            set { addBtnClickedCommand = value; }
        }


        //constructor
        public MainViewModel()
        {
            AddBtnClickedCommand = new RelayCommand(new Action(AddBtnClicked), new Func<bool>(CanExecute));
            LoadData();
        }

        //methods

        private bool CanExecute()
        {
            return NewTaskDescription.Length > 0;
        }

        private void AddBtnClicked()
        {
            ToDoList.Add(new ToDoVM(NewTaskDescription, false));
        }

        public void LoadData()
        {
            toDoList.Add(new ToDoVM("Buy some bread", false));
            toDoList.Add(new ToDoVM("Buy sth else", true));
        }


    }
}
