using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MikadoProject.DAO;
using MikadoProject.Models;

namespace MikadoProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly MikadoContexte _contexte;

        public UserController(MikadoContexte contexte)
        {
            _contexte = contexte;
        }

        [HttpGet("{userId}")]
        public User GetUser(int userId)
        {
            return new EntityFrameWorkUserDAO(_contexte).findById(userId);
        }

        [HttpGet("findAll")]
        public List<User> GetAllUsers()
        {
            return new EntityFrameWorkUserDAO(_contexte).findAll();
        }

        [HttpDelete("{userId}")]
        public void DeleteUser(int userId)
        {
            new EntityFrameWorkUserDAO(_contexte).delete(userId);
        }

        [HttpPost]
        public ActionResult CreateUser(User user)
        {
            if(user == null)
            {
                return BadRequest();
            }
            new EntityFrameWorkUserDAO(_contexte).create(user);

            return Ok();
        }

        [HttpPut]
        public void UpdateUser(User user)
        {
            new EntityFrameWorkUserDAO(_contexte).update(user);
        }

        [HttpGet("{userId}/favoris")]
        public List<Media> GetUserFavoris(int userId)
        {
            return new EntityFrameWorkUserDAO(_contexte).GetUserFavoris(userId);
        }
    }
}
