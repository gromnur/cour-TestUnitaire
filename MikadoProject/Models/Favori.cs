using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MikadoProject.Models
{
    [Table("Favoris")]
    public class Favori
    {
        public int UserId { set; get; }

        public int MediaId { set; get; }

        public virtual User User { set; get; }

        public virtual Media Media { set; get; }

    }
}
