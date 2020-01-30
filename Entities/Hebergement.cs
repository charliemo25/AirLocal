using airbnb.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace airbnb.Class
{
    public class Hebergement : IEquatable<Hebergement>
    {
        public int IdHebergement { get; set; }
        public string Photo { get; set; }
        public string Nom { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public decimal Prix { get; set; }
        public Adresse Adresse { get; set; }
        public Personne Personne { get; set; }

        //Constructeur par defaut
        public Hebergement()
        {

        }

        //Constructeur
        public Hebergement(int id, string photo, string nom, string type, string description, Adresse adresse, Personne personne)
        {
            this.IdHebergement = id;
            this.Photo = photo;
            this.Nom = nom;
            this.Type = type;
            this.Description = description;
            this.Adresse = adresse;
            this.Personne = personne;
        }

        public bool Equals(Hebergement item)
        {
            return this.IdHebergement == item.IdHebergement;
        }
    }
}