using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TNT_ClassLib.Models;

namespace TNT_WPF.MVVM.ViewModels
{
    public class NoteViewModel : BaseViewModel<ObservableCollection<INoteItem>>
    {
        public NoteViewModel()
        {
            
        }
    }
}
