﻿using DataAccess_ClassLib.Interfaces;
using DataAccess_ClassLib.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TNT_ClassLib.Models;

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

                T? entity = await context.Set<T>().FindAsync(id);
                context.Set<T>().Remove(entity);
                context.SaveChanges();
                return true;
            }
        }

        public async Task<T> Get(U id)
        {
            using(NoteDbContext ctx = _theNoteDbContextFactory.CreateDbContext())
            {


                T entity = await ctx.Set<T>().FirstOrDefaultAsync(e => e.ID == id);
                return etity
            }
        }

        public Task<IEnumerable<T>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<T> Update(U id, T Entity)
        {
            throw new NotImplementedException();
        }
    }
}
