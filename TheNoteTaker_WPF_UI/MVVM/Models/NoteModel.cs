using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheNoteTaker_WPF_UI.MVVM.Models
{
    public class NoteModel
    {
        public DateTime TimePosted { get; set; } = DateTime.Now;
        public string Note { get; set; } = "";

        public override string ToString()
        {
            return TimePosted.ToString("F") + Environment.NewLine + Note;
        }
    }
}
