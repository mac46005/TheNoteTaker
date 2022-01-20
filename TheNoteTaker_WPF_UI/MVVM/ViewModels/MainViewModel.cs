using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheNoteTaker_WPF_UI.MVVM.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private object _viewModel;

        public object ViewModel
        {
            get { return _viewModel; }
            set { _viewModel = value; }
        }


        public MainViewModel()
        {

        }
    }
}
