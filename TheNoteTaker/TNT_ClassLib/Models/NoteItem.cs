using DataAccess_ClassLib.Interfaces;
using DataAccess_ClassLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNT_ClassLib.Models 
{
    public class NoteItem : BaseModel<int>,INoteItem
    {

        public string Note { get; set; } = string.Empty;
        public DateTime TimePosted { get; set; } = DateTime.Now;
    }
}
