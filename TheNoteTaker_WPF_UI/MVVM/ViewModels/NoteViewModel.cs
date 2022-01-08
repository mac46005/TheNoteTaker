using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TheNoteTaker_WPF_UI.MVVM.Models;

namespace TheNoteTaker_WPF_UI.MVVM.ViewModels
{
    public class NoteViewModel : Screen
    {
        private ObservableCollection<NoteModel> _listofNotes;

        public ObservableCollection<NoteModel> ListOfNotes
        {
            get { return _listofNotes; }
            set 
            {
                _listofNotes = value;
                NotifyOfPropertyChange(() => ListOfNotes);
            }
        }

        private string _noteTextBox;

        public string NoteTextBox
        {
            get { return _noteTextBox; }
            set 
            {
                _noteTextBox = value;
                NotifyOfPropertyChange(() => NoteTextBox);
            }
        }



        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Console.WriteLine();
            }
        }
    }



}
