using MikadoProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MikadoProject.DAO
{
    public interface IDAO<T>
    {

        public abstract T create(object T);

        public abstract T update(object T);

        public abstract void delete(int id);

        public abstract T findById(int id);

        public abstract List<T> findAll();
    }
}
