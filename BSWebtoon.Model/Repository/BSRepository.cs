using BSWebtoon.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSWebtoon.Model.Repository
{
    public class BSRepository
    {
        private BSWebtoonDbContext _context;
        public BSWebtoonDbContext Context { get { return _context; } }
        public BSRepository(BSWebtoonDbContext context)
        {
            if (context == null) { throw new ArgumentNullException(); }
            _context = context;
        }

        public BSRepository()
        {
        }

        public EntityEntry<T> Create<T>(T value) where T : class
        {
            EntityEntry<T> e = _context.Entry(value);
            e.State = EntityState.Added;
            return e;
        }
        public void Update<T>(T value) where T : class
        {
            _context.Entry(value).State = EntityState.Modified;
        }
        public void Delete<T>(T value) where T : class
        {
            _context.Entry(value).State = EntityState.Deleted;
        }
        public IQueryable<T> GetAll<T>() where T : class
        {
            return _context.Set<T>();
        }
        public void SaveChange()
        {
            _context.SaveChanges();
        }


    }
}
