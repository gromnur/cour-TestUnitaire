using Microsoft.EntityFrameworkCore;
using MikadoProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MikadoProject.DAO
{
    public class EntityFrameWorkUserDAO : IUserDAO
    {
        private readonly MikadoContexte _contexte;

        public EntityFrameWorkUserDAO(MikadoContexte contexte)
        {
            _contexte = contexte;
        }

        public User create(object T)
        {
            throw new NotImplementedException();
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> findAll()
        {
            return _contexte.User.ToList();
        }

        public User findById(int id)
        {
            return _contexte.User.Find(id);
        }

        public List<Favori> GetUserFavoris(int idUser)
        {
            return null;
        }

        public User update(object T)
        {
            throw new NotImplementedException();
        }
    }
}
