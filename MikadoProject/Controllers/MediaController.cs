using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MikadoProject.DAO;
using MikadoProject.Models;

namespace MikadoProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
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

        [HttpPost]
        public void CreateMedia(Media media)
        {
            new EntityFrameWorkMediaDAO(_contexte).create(media);
        }

        [HttpPut]
        public void UpdateMedia(Media media)
        {
            new EntityFrameWorkMediaDAO(_contexte).update(media);
        }
    }
}
