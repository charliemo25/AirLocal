using airbnb.Class;
using airbnb.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using airbnb.Utilities;

namespace airbnb.DAO
{
    public class DaoHebergement : DataAcess
    {
        public DaoHebergement() : base()
        {
            
        }

        public bool AddHebergement(List<Hebergement> hebergements, Hebergement hebergement, Adresse adresse, Personne personne)
        {
            try
            {
                SqlParameter[] sqlParameters = {
                    new SqlParameter("@idProprietaire", personne.IdPersonne),
                    new SqlParameter("@idAdresse", hebergement.IdHebergement),
                    new SqlParameter("@nomHebergement", hebergement.Nom),
                    new SqlParameter("@photo", hebergement.Photo),
                    new SqlParameter("@type", hebergement.Type),
                    new SqlParameter("@description", hebergement.Description),
                    new SqlParameter("@prix", hebergement.Prix),
                    new SqlParameter("@nomAdresse", adresse.NomAdresse),
                    new SqlParameter("@NumeroAdresse", adresse.Numero),
                    new SqlParameter("@voie", adresse.Voie),
                    new SqlParameter("@codePostal", adresse.CodePostal),
                    new SqlParameter("@ville", adresse.Ville),
                    new SqlParameter("@etat", 1)

                };

                //Execution de l'operation sql qui renvoie un tableau
                //Les données sont stockées dans un objet de type DataReader
                base.ExecuteQuery("sp_AddHebergement", sqlParameters);

                base.sqlDataReader.Close();

            }
            catch (Exception ex)
            {
                return true;
            }
            //Constant loadHebergement = (List<Hebergement>)Session[LoadHebergement]


            return false;
        }

        public Hebergement GetHebergement(int id)
        {
            Hebergement hebergement = null;

            try
            {
                SqlParameter[] sqlParameters = { 
                    new SqlParameter("@idHebergement", id)
                };

                //Execution de l'operation sql qui renvoie un tableau
                //Les données sont stockées dans un objet de type DataReader
                base.GetDataReader("sp_getHebergement", sqlParameters);

                if (base.sqlDataReader.HasRows)
                {
                    hebergement = new Hebergement();
                    while (base.sqlDataReader.Read())
                    {

                        //Hebergement
                        hebergement.IdHebergement = (int)sqlDataReader["IdHebergement"];
                        hebergement.Nom = (string)sqlDataReader["Nom"];
                        hebergement.Photo = (string)sqlDataReader["Photo"];
                        hebergement.Type = (string)sqlDataReader["Type"];
                        hebergement.Description = (string)sqlDataReader["Description"];
                        hebergement.Prix = (decimal)sqlDataReader["Prix"];

                        //Adresse
                        hebergement.Adresse = new Adresse() {
                            IdAdresse = (int)sqlDataReader["IdAdresse"],
                            NomAdresse = (string)sqlDataReader["Nom"],
                            Numero = (string)sqlDataReader["Numero"],
                            Voie = (string)sqlDataReader["Voie"],
                            CodePostal = (string)sqlDataReader["CodePostal"],
                            Ville = (string)sqlDataReader["Ville"]
                        };
                    }

                }

                base.sqlDataReader.Close();
                base.sqlConnection.Close();

            }
            catch (Exception ex)
            {

            }

            return hebergement;
        }

        //public List<Hebergement> GetHebergements("", "")
        //{
        //    return GetHebergements("", "");
        //}

        public List<Hebergement> GetHebergements(string departement, string typeHebergement)
        {


            List<Hebergement> hebergements = null;
            List<SqlParameter> sqlParameters = new List<SqlParameter>();

            if (!string.IsNullOrEmpty(departement))
            {
                sqlParameters.Add(new SqlParameter("@departement", departement));
            }

            if (!string.IsNullOrEmpty(typeHebergement))
            {
                sqlParameters.Add(new SqlParameter("@typeHebergement", typeHebergement));
            }

            try
            {

                //Execution de l'operation sql qui renvoie un tableau
                //Les données sont stockées dans un objet de type DataReader
                base.GetDataReader("sp_getHebergements", sqlParameters.ToArray());

                if (base.sqlDataReader.HasRows)
                {
                    hebergements = new List<Hebergement>();

                    while (base.sqlDataReader.Read())
                    {
                        Hebergement hebergement = new Hebergement();

                        string id = sqlDataReader["IdHebergement"].ToString();
                        string photo = sqlDataReader["Photo"].ToString();
                        string nom = sqlDataReader["Nom"].ToString();
                        string type = sqlDataReader["Type"].ToString();
                        string description = sqlDataReader["Description"].ToString();
                        decimal prix = (decimal)sqlDataReader["Prix"];


                        hebergement.IdHebergement = Convert.ToInt32(id);
                        hebergement.Nom = nom;
                        hebergement.Photo = photo;
                        hebergement.Type = type;
                        hebergement.Description = description;
                        hebergement.Prix = prix;

                        hebergements.Add(hebergement);
                    }

                }

                base.sqlDataReader.Close();
                base.sqlConnection.Close();

            }
            catch (Exception ex)
            {

            }

            return hebergements;

        }
    }
}