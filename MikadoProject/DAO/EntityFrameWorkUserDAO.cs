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

        public void create(User obj)
        {
            _contexte.User.Add(obj);
        }

        public void delete(int id)
        {
            User findUser = _contexte.User.SingleOrDefault(u => u.UserId == id);
            _contexte.User.Remove(findUser);
        }

        public List<User> findAll()
        {
            return _contexte.User.ToList();
        }

        public User findById(int id)
        {
            return _contexte.User.Find(id);
        }

        public void update(User obj)
        {
            _contexte.User.Update(obj);
        }

        public List<Media> GetUserFavoris(int idUser)
        {
            return _contexte.Favoris.Where(f => f.UserId == idUser).Select(f => f.Media).ToList();
        }
    }
}
