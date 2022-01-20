using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;
using TheNoteTaker_WPF_UI.Core;
using TheNoteTaker_WPF_UI.MVVM.Models;

namespace TheNoteTaker_WPF_UI.MVVM.ViewModels
{
    public class ToDoInterfaceViewModel : BaseViewModel
    {

        private CollectionViewSource ToDoCollection;

        public ICollectionView ToDoSourceCollection => ToDoCollection.View;
        public ToDoInterfaceViewModel()
        {
            ToDoCollection = new CollectionViewSource { Source = toDoItems };
            
        }

        private ObservableCollection<ToDoItem> toDoItems = new ObservableCollection<ToDoItem>();

        public ICommand AddToDo => new RelayCommand(o => 
        {
            ToDoItem toDoItem = new ToDoItem { ToDo = TbToDo };
            toDoItems.Add(toDoItem);
            ToDoSourceCollection.Refresh();
        });



        private string _tbToDo;

        public string TbToDo
        {
            get { return _tbToDo; }
            set 
            { 
                _tbToDo = value;
                OnPropertyChanged("TbToDo");
            }
        }

    }
}
