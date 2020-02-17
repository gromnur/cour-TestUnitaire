using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MikadoProject.DAO;
using MikadoProject.Models;

namespace MikadoProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MediaController : ControllerBase
    {
        private readonly MikadoContexte _contexte;

        public MediaController(MikadoContexte contexte)
        {
            _contexte = contexte;
        }

        [HttpGet("{mediaId}")]
        public Media GetMedia(int mediaId)
        {
            return new EntityFrameWorkMediaDAO(_contexte).findById(mediaId);
        }

        [HttpGet("findAll")]
        public List<Media> GetAllMedia()
        {
            return new EntityFrameWorkMediaDAO(_contexte).findAll();
        }

        [HttpDelete("{mediaId}")]
        public void DeleteMedia(int mediaId)
        {
            new EntityFrameWorkMediaDAO(_contexte).delete(mediaId);
        }

        [HttpPut]
        public Media UpdateMedia(Media media)
        {
            return new EntityFrameWorkMediaDAO(_contexte).update(media);
        }
    }
}
