using airbnb.Class;
using airbnb.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;

namespace airbnb.DAO
{
    public class DaoPersonne : DataAcess
    {
        public DaoPersonne() : base()
        {

        }

        //Methodes du Client

        public bool CreateClient(string nom, string prenom, string telephone, string email, string login, string password, string nomAdresse, string numero, string voie, string cp, string ville)
        {

            try
            {
                SqlParameter[] sqlParameters = {
                    new SqlParameter("@nom", nom),
                    new SqlParameter("@prenom", prenom),
                    new SqlParameter("@telephone", telephone),
                    new SqlParameter("@email", email),
                    new SqlParameter("@login", login),
                    new SqlParameter("@password", password),
                    new SqlParameter("@nomAdresse", nomAdresse),
                    new SqlParameter("@numero", numero),
                    new SqlParameter("@voie", voie),
                    new SqlParameter("@codePostal", cp),
                    new SqlParameter("@ville", ville)
                };

                //Execution de l'operation sql qui renvoie un tableau
                //Les données sont stockées dans un objet de type DataReader
                base.GetDataReader("sp_CreateClient", sqlParameters);

                base.sqlDataReader.Close();
                base.sqlConnection.Close();

            }
            catch (Exception ex)
            {
                return true;
            }
            return false;
        }

        public Personne GetClient(string login, string password)
        {
            Personne personne = null;

            try
            {
                SqlParameter[] sqlParameters = {
                    new SqlParameter("@login", login),
                    new SqlParameter("@password",password)
                };

                //Execution de l'operation sql qui renvoie un tableau
                //Les données sont stockées dans un objet de type DataReader
                base.GetDataReader("sp_GetClient", sqlParameters);

                if (base.sqlDataReader.HasRows)
                {
                    personne = new Personne();
                    int id = 0;

                    while (base.sqlDataReader.Read())
                    {


                        if (id != Convert.ToInt32(sqlDataReader["IdPersonne"]))
                        {
                            //Insertion dans personne
                            personne.IdPersonne = Convert.ToInt32(sqlDataReader["IdPersonne"]);
                            personne.Nom = (string)sqlDataReader["Nom"];
                            personne.Prenom = (string)sqlDataReader["Prenom"];
                            personne.Login = sqlDataReader["Login"].ToString();
                            personne.Password = sqlDataReader["Password"].ToString();
                            personne.Email = sqlDataReader["Email"].ToString();
                            personne.Telephone = sqlDataReader["Telephone"].ToString();
                            personne.Status = (bool)sqlDataReader["Status"];

                            id = Convert.ToInt32(sqlDataReader["IdPersonne"]);

                        }
                    }
                }


                base.sqlDataReader.Close();
                base.sqlConnection.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return personne;
        }

        public void UpdateClient(Personne user, string telephone, string email, string password)
        {
            try
            {
                SqlParameter[] sqlParameters = {
                    new SqlParameter("@idPersonne", user.IdPersonne),
                    new SqlParameter("@telephone", telephone),
                    new SqlParameter("@email", email),
                    new SqlParameter("@password", password)
                };

                //Execution de l'operation sql qui renvoie un tableau
                //Les données sont stockées dans un objet de type DataReader
                base.ExecuteQuery("sp_UpdatePersonne", sqlParameters);

                base.sqlConnection.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //On réassigne les valeurs à l'utilisateurs pour mettre a jour
            user.Telephone = telephone;
            user.Email = email;
            user.Password = password;
        }


        //Methodes des Favoris du Client

        public List<Hebergement> GetClientFavoris(Personne personne)
        {
            Hebergement favoris = null;
            List<Hebergement> listeFavoris = null;

            try
            {
                listeFavoris = new List<Hebergement>();

                SqlParameter[] sqlParameters = {
                    new SqlParameter("@idPersonne", personne.IdPersonne),
                };

                //Execution de l'operation sql qui renvoie un tableau
                //Les données sont stockées dans un objet de type DataReader
                base.GetDataReader("sp_GetClientFavoris", sqlParameters);

                if (base.sqlDataReader.HasRows)
                {


                    while (base.sqlDataReader.Read())
                    {
                        favoris = new Hebergement();

                        //Liste de favoris de la personne
                        favoris.IdHebergement = (int)sqlDataReader["IdHebergement"];
                        favoris.Nom = (string)sqlDataReader["NomHebergement"];
                        favoris.Photo = (string)sqlDataReader["Photo"];
                        favoris.Type = (string)sqlDataReader["Type"];
                        favoris.Description = (string)sqlDataReader["Description"];
                        favoris.Prix = (decimal)sqlDataReader["Prix"];
                        listeFavoris.Add(favoris);
                    }
                }


                base.sqlDataReader.Close();
                base.sqlConnection.Close();

            }
            catch (Exception ex)
            {

            }

            return listeFavoris;
        }

        public bool AddFavoris(Personne personne, Hebergement hebergement)
        {
            try
            {
                SqlParameter[] sqlParameters = {
                    new SqlParameter("@idPersonne", personne.IdPersonne),
                    new SqlParameter("@idHebergement", hebergement.IdHebergement),
                };

                //Execution de l'operation sql qui renvoie un tableau
                //Les données sont stockées dans un objet de type DataReader
                base.ExecuteQuery("sp_AddFavoris", sqlParameters);

                base.sqlConnection.Close();

            }
            catch (Exception ex)
            {
                return true;
            }

            personne.Favoris.Add(hebergement);

            return false;
        }

        public bool DeleteFavoris(Personne personne, Hebergement hebergement)
        {
            try
            {
                SqlParameter[] sqlParameters = {
                    new SqlParameter("@idPersonne", personne.IdPersonne),
                    new SqlParameter("@idHebergement", hebergement.IdHebergement),
                };

                //Execution de l'operation sql qui renvoie un tableau
                //Les données sont stockées dans un objet de type DataReader
                base.ExecuteQuery("sp_DeleteFavoris", sqlParameters);

                base.sqlConnection.Close();

            }
            catch (Exception ex)
            {
                return true;
            }

            personne.Favoris.Remove(hebergement);

            return false;
        }


        //Methodes des Reservations du Client

        public List<Reservation> GetClientReservations(Personne personne)
        {
            Reservation reservation = null;
            Hebergement hebergementReserv = null;
            List<Reservation> listeReservations = null;

            try
            {
                listeReservations = new List<Reservation>();

                SqlParameter[] sqlParameters = {
                    new SqlParameter("@idPersonne", personne.IdPersonne),
                };

                //Execution de l'operation sql qui renvoie un tableau
                //Les données sont stockées dans un objet de type DataReader
                base.GetDataReader("sp_GetClientReservations", sqlParameters);

                if (base.sqlDataReader.HasRows)
                {

                    while (base.sqlDataReader.Read())
                    {
                        reservation = new Reservation();
                        hebergementReserv = new Hebergement();

                        //Hebergement
                        hebergementReserv.IdHebergement = Convert.ToInt32(sqlDataReader["IdHebergement"]);
                        hebergementReserv.Nom = sqlDataReader["NomHebergement"].ToString();
                        hebergementReserv.Photo = sqlDataReader["Photo"].ToString();
                        hebergementReserv.Type = sqlDataReader["Type"].ToString();
                        hebergementReserv.Description = sqlDataReader["Description"].ToString();
                        hebergementReserv.Prix = Convert.ToDecimal(sqlDataReader["Prix"]);

                        //Reservation
                        reservation.IdReservation = Convert.ToInt32(sqlDataReader["IdReservation"]);
                        reservation.hebergement = hebergementReserv;
                        reservation.DateReservation = (DateTime)sqlDataReader["DateReservation"];
                        reservation.DateDebut = (DateTime)sqlDataReader["DateDebut"];
                        reservation.DateFin = (DateTime)sqlDataReader["DateFin"];

                        //On ajoute la réservation à la liste
                        listeReservations.Add(reservation);
                    }
                }

                base.sqlDataReader.Close();
                base.sqlConnection.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listeReservations;
        }

        public void AddReservation(Personne personne, Hebergement hebergement, DateTime reservDebut, DateTime reservFin)
        {

            try
            {
                SqlParameter[] sqlParameters = {
                    new SqlParameter("@idPersonne", personne.IdPersonne),
                    new SqlParameter("@idHebergement", hebergement.IdHebergement),
                    new SqlParameter("@DateReservation", DateTime.Now ),
                    new SqlParameter("@dateDebut", reservDebut),
                    new SqlParameter("@dateFin", reservFin)
                };

                //Execution de l'operation sql qui renvoie un tableau
                //Les données sont stockées dans un objet de type DataReader
                base.ExecuteQuery("sp_AddReservation", sqlParameters);

                base.sqlConnection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteReservation(Personne personne, Reservation reservation)
        {
            try
            {
                //A faire: ajouter les date de reservation, aussi dans la procédure

                SqlParameter[] sqlParameters = {
                    new SqlParameter("@idReservation", reservation.IdReservation),
                };

                //Execution de l'operation sql qui renvoie un tableau
                //Les données sont stockées dans un objet de type DataReader
                base.ExecuteQuery("sp_DeleteReservation", sqlParameters);

                base.sqlConnection.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            personne.Reservations.Remove(reservation);

        }


        //Methodes des adresses du Client

        public List<Adresse> GetClientAdresses(Personne personne)
        {
            Adresse adresse = null;
            List<Adresse> listeAdresses = null;

            try
            {
                listeAdresses = new List<Adresse>();

                SqlParameter[] sqlParameters = {
                    new SqlParameter("@idPersonne", personne.IdPersonne),
                };

                //Execution de l'operation sql qui renvoie un tableau
                //Les données sont stockées dans un objet de type DataReader
                base.GetDataReader("sp_GetClientAdresses", sqlParameters);

                if (base.sqlDataReader.HasRows)
                {



                    while (base.sqlDataReader.Read())
                    {
                        adresse = new Adresse();

                        //Liste d'adresse de la personne
                        adresse.IdAdresse = (int)sqlDataReader["IdAdresse"];
                        adresse.NomAdresse = sqlDataReader["NomAdresse"].ToString();
                        adresse.Numero = sqlDataReader["Numero"].ToString();
                        adresse.Voie = sqlDataReader["Voie"].ToString();
                        adresse.CodePostal = sqlDataReader["CodePostal"].ToString();
                        adresse.Ville = sqlDataReader["Ville"].ToString();

                        //Ajout dans la liste 
                        listeAdresses.Add(adresse);
                    }
                }

                base.sqlDataReader.Close();
                base.sqlConnection.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listeAdresses;
        }

        public void AddAdresse(Personne personne, string nomAdresse, string numero, string voie, string cp, string ville)
        {
            try
            {
                SqlParameter[] sqlParameters = {
                    new SqlParameter("@idPersonne", personne.IdPersonne),
                    new SqlParameter("@nomAdresse", nomAdresse),
                    new SqlParameter("@numero", numero),
                    new SqlParameter("@voie", voie),
                    new SqlParameter("@cp", cp),
                    new SqlParameter("@ville", ville)
                };

                //Execution de l'operation sql qui renvoie un tableau
                //Les données sont stockées dans un objet de type DataReader
                base.ExecuteQuery("sp_AddAdresse", sqlParameters);

                base.sqlConnection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteAdresse(Personne personne, int idAdresse)
        {
            try
            {
                SqlParameter[] sqlParameters = {
                    new SqlParameter("@idPersonne", personne.IdPersonne),
                    new SqlParameter("@idAdresse", idAdresse),
                };

                //Execution de l'operation sql qui renvoie un tableau
                //Les données sont stockées dans un objet de type DataReader
                base.ExecuteQuery("sp_DeleteAdresse", sqlParameters);

                base.sqlConnection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}