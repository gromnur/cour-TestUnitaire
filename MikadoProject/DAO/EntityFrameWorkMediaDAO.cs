using MikadoProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MikadoProject.DAO
{
    public class EntityFrameWorkMediaDAO : IMediaDAO
    {
        private readonly MikadoContexte _contexte;

        public EntityFrameWorkMediaDAO(MikadoContexte contexte)
        {
            _contexte = contexte;
        }

        public void create(Media obj)
        {
            _contexte.Media.Add(obj);
        }

        public void delete(int id)
        {
            Media findMedia = _contexte.Media.SingleOrDefault(m => m.MediaId == id);
            _contexte.Media.Remove(findMedia);
        }

        public List<Media> findAll()
        {
            return _contexte.Media.ToList();
        }

        public Media findById(int id)
        {
            return _contexte.Media.Find(id);
        }

        public void update(Media obj)
        {
            _contexte.Media.Update(obj);
        }
    }
}
