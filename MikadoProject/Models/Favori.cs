using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MikadoProject.Models
{
    public class Favori
    {
        public int UserId { set; get; }

        public int MediaId { set; get; }

        public User User { set; get; }

        public Media Media { set; get; }

    }
}
