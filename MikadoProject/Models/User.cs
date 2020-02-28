using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MikadoProject.Models
{
    [Table("Users")]
    public class User
    {
        public User(string nom, string prenom, string login, string password, int role)
        {
            Nom = nom;
            Prenom = prenom;
            Login = login;
            Password = password;
            Role = role;
        }

        [Key]
        public int UserId { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public int Role { get; set; }

        public virtual ICollection<Favori> Favoris { get; set; }
    }
}
