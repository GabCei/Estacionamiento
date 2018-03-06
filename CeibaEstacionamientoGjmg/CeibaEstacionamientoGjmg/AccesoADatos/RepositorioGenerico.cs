using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace CeibaEstacionamientoGjmg.AccesoADatos
{
    public class RepositorioGenerico<T> : IRepositorioGenerico<T> where T : class
    {
        internal DbEstacionamientoContext _context;

        public RepositorioGenerico(DbEstacionamientoContext context)
        {
            _context = context;
        }
        public void Add(T repocitorio)
        {
            _context.Set<T>().Add(repocitorio);
        }

        public void Delete(T repocitorio)
        {
            _context.Set<T>().Remove(repocitorio);
        }

        public void Edite(T repocitorio)
        {
            _context.Entry(repocitorio).State = EntityState.Modified;
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = _context.Set<T>().Where(predicate);
            return query;
        }

        public IQueryable<T> GetAll()
        {
            IQueryable<T> query = _context.Set<T>();
            return query;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
