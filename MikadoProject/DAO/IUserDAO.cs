using MikadoProject.Models;
using System.Collections.Generic;

namespace MikadoProject.DAO
{
    public interface IUserDAO : IDAO<User>
    {

        public List<Media> GetUserFavoris(int idUser);
    }
}