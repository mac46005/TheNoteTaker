using DataAccess_ClassLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNT_ClassLib.Models 
{
    public class NoteItem : INoteItem<int>
    {
        public int ID { get; set; }

        public string Note { get; set; } = string.Empty;
        public DateTime TimePosted { get; set; } = DateTime.Now;
    }
}
