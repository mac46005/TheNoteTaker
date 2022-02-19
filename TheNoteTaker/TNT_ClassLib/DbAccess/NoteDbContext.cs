using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TNT_ClassLib.Models;

namespace TNT_ClassLib.DbAccess
{
    public class NoteDbContext : DbContext
    {
        DbSet<NoteItem> NoteItems { get; set; }
        public NoteDbContext(DbContextOptions options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NoteItem>().ToTable("NoteItems");
            modelBuilder.Entity<NoteItem>(entity =>
            {
                entity.HasKey(k => k.ID);
            });
            base.OnModelCreating(modelBuilder);
        }

    }
}
