using airbnb.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace airbnb.Class
{
    public class Personne
    {
        public int IdPersonne { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool Status { get; set; }

        public List<Hebergement> Favoris { get; set; }
        public List<Adresse> Adresses {get; set;}
        public List<Reservation> Reservations { get; set; }


        public Personne()
        {
            Favoris = new List<Hebergement>();
            Adresses = new List<Adresse>();
            Reservations = new List<Reservation>();
        }

        //Constructeur
        public Personne(string nom, string prenom, string telephone, string email, string login, string password, bool type) : base()
        {

            this.Nom = nom;
            this.Prenom = prenom;
            this.Telephone = telephone;
            this.Login = login;
            this.Password = password;
            this.Status = type;
            this.Email = email;

        }
    }
}