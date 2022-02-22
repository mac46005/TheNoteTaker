using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNT_WPF.MVVM.ViewModels
{
    internal class MainViewModel : BaseViewModel<NoteViewModel>
    {
        public MainViewModel(NoteViewModel noteViewModel)
        {
            Model = noteViewModel;
            NoteView = Model;
        }

        private NoteViewModel noteViewModel1;

        public NoteViewModel NoteView
        {
            get { return noteViewModel1; }
            set { noteViewModel1 = value; }
        }

    }
}
