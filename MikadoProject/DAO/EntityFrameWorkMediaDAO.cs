using MikadoProject.Models;
using System;
using System.Collections.Generic;

namespace MikadoProject.DAO
{
    public class EntityFrameWorkMediaDAO : IMediaDAO
    {
        private readonly MikadoContexte _contexte;

        public EntityFrameWorkMediaDAO(MikadoContexte contexte)
        {
            _contexte = contexte;
        }

        public Media create(object T)
        {
            throw new NotImplementedException();
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Media> findAll()
        {
            throw new NotImplementedException();
        }

        public Media findById(int id)
        {
            throw new NotImplementedException();
        }

        public Media update(object T)
        {
            throw new NotImplementedException();
        }
    }
}
