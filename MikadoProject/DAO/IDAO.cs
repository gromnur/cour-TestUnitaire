using MikadoProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MikadoProject.DAO
{
    public interface IDAO<T>
    {

        public abstract void create(T obj);

        public abstract void update(T obj);

        public abstract void delete(int id);

        public abstract T findById(int id);

        public abstract List<T> findAll();
    }
}
