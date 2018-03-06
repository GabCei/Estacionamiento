using System;
using System.Linq;
using System.Linq.Expressions;

namespace CeibaEstacionamientoGjmg.AccesoADatos
{
    public interface IRepositorioGenerico<TRepocitorioGenerico> where TRepocitorioGenerico : class
    {
        IQueryable<TRepocitorioGenerico> GetAll();
        IQueryable<TRepocitorioGenerico> Find(Expression<Func<TRepocitorioGenerico, bool>> predicate);
        void Add(TRepocitorioGenerico repocitorio);
        void Delete(TRepocitorioGenerico repocitorio);
        void Edite(TRepocitorioGenerico repocitorio);
        void Save();
    }
}
