using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TNT_ClassLib.Models;

namespace TNT_ClassLib.DbAccess
{
    public class NoteDbContext : DbContext
    {
        DbSet<NoteItem> NoteItems { get; set; }
        
    }
}
