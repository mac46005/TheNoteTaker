using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TNT_ClassLib.Models;
using TNT_WPF.Core;

namespace TNT_WPF.MVVM.ViewModels
{
    public class NoteViewModel : BaseViewModel<ObservableCollection<INoteItem>>
    {
        private string _noteMessage;

        public string NoteMessage
        {
            get { return _noteMessage; }
            set 
            { 
                _noteMessage = value;
                OnPropertyChaged("NoteMessage");
            }
        }




        public NoteViewModel()
        {
            Model = new ObservableCollection<INoteItem>();
            SubmitCommand = new RelayCommand(o =>
            {
                INoteItem item = new NoteItem();
                item.Note = NoteMessage;
                NoteMessage = string.Empty;
                Model.Add(item);
            });
        }


        public ICommand SubmitCommand { get; set; }
    }
}
