using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheNoteTaker_WPF_UI.MVVM.Models
{
    public class ToDoItem
    {
        public int ID { get; set; }
        public string ToDo { get; set; }
        public DateTime Due { get; set; }

    }
}
