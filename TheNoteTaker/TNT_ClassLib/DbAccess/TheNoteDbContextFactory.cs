using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNT_ClassLib.DbAccess
{
    public class TheNoteDbContextFactory : IDesignTimeDbContextFactory<NoteDbContext>
    {
        public NoteDbContext CreateDbContext(string[] args = null)
        {
            var options = new DbContextOptionsBuilder<NoteDbContext>();
            options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=TheNoteTake_DB;Trusted_Connection=True");
            return new NoteDbContext(options.Options);
        }
    }
}
