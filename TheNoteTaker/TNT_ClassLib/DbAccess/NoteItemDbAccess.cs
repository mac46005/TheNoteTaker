using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TNT_ClassLib.Models;
using DataAccess_ClassLib.Interfaces;
using DataAccess_ClassLib.Models;
using Microsoft.EntityFrameworkCore;

namespace TNT_ClassLib.DbAccess
{
    internal class NoteItemDbAccess<T,U> : IDataService<T,U> where T : BaseModel<U>
    {
        TheNoteDbContextFactory _theNoteDbContextFactory;
        public NoteItemDbAccess(TheNoteDbContextFactory theNoteDbContextFactory)
        {
            _theNoteDbContextFactory = theNoteDbContextFactory;
        }

        public async Task<T> Create(T entity)
        {
            using (NoteDbContext ctx = _theNoteDbContextFactory.CreateDbContext())
            {
                await ctx.Set<T>().AddAsync(entity);
                ctx.SaveChanges();
                return entity;
            }
        }

        public async Task<bool> Delete(U id)
        {
            using (NoteDbContext context = _theNoteDbContextFactory.CreateDbContext())
            {

                var entity = await context.Set<T>().FindAsync(id);
                context.Set<T>().Remove(entity);
                context.SaveChanges();
                return true;
            }
        }

        public async Task<T> Get(U id)
        {
            using(NoteDbContext ctx = _theNoteDbContextFactory.CreateDbContext())
            {


                T entity = await ctx.Set<T>().FirstOrDefaultAsync(e => e.ID.Equals(id));
                return entity;
            }
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            using (NoteDbContext ctx = _theNoteDbContextFactory.CreateDbContext())
            {
                var list = await ctx.Set<T>().ToListAsync();
                return list;
            }
        }

        public async Task<T> Update(U id, T Entity)
        {
            using (NoteDbContext ctx = _theNoteDbContextFactory.CreateDbContext())
            {
                Entity.ID = id;
                ctx.Set<T>().Update(Entity);
                return await Task.FromResult(Entity);
            }
        }
    }
}
