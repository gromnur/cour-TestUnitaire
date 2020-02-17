using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MikadoProject.Models
{
    public class Media
    {
        public Media(int mediaId, string libelle, string description, string auteur, string realisateur, string type)
        {
            MediaId = mediaId;
            Libelle = libelle;
            Description = description;
            Auteur = auteur;
            Realisateur = realisateur;
            Type = type;
        }

        public int MediaId { get; set; }

        public string Libelle { get; set; }

        public string Description { get; set; }

        public string Auteur { get; set; }

        public string Realisateur { get; set; }

        public string Type { get; set; }

        public virtual ICollection<Favori> Favoris { get; set; }

    }
}
