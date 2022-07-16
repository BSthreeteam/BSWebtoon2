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
        public BSRepository(BSWebtoonContext context)
        {
            if (context == null) { throw new ArgumentNullException(); }
            _context = context;
        }

        public BSRepository()
        {
        }

        private BSWebtoonContext _context;

        public void Create<T>(T value) where T : class
        {
            _context.Entry(value).State = EntityState.Added;
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

        public IEnumerable<object> GetAll<T>(Activity activity)
        {
            throw new NotImplementedException();
        }
    }
}
