using airbnb.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace airbnb.DAO
{
    public class DataAcess
    {
        public SqlConnection sqlConnection;
        public SqlDataReader sqlDataReader;
        public string ErrorMsg { get; set; }

        public DataAcess()
        {
            //Chaine de connexion a la BDD
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=AirLocal;Integrated Security=True";

            //Objet pour se connecter à la BDD
            sqlConnection = new SqlConnection(connectionString);

        }

        public bool GetDataReader(string sqlQuery, SqlParameter[] sqlParameters)
        {
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlDataReader = null;
            bool isError = false;

            try
            {
                //On se connecte à la BDD
                sqlConnection.Open();

                if(sqlParameters != null && sqlParameters.Length > 0)
                {
                    sqlCommand.Parameters.AddRange(sqlParameters);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                }

                //Execution de l'operation sql qui renvoie un tableau
                //Les données sont stockées dans un objet de type DataReader
                sqlDataReader = sqlCommand.ExecuteReader();


            }
            catch (Exception ex)
            {
                isError = true;
                ErrorMsg = ex.Message;
                throw ex;
            }
            finally
            {

            }

            return isError;
        }

        public bool ExecuteQuery(string sqlQuery, SqlParameter[] sqlParameters)
        {
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            bool isError = false;

            try
            {
                //On se connecte à la BDD
                sqlConnection.Open();

                if (sqlParameters != null && sqlParameters.Length > 0)
                {
                    sqlCommand.Parameters.AddRange(sqlParameters);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                }

                //Execution de l'operation sql qui renvoie un tableau
                //Les données sont stockées dans un objet de type DataReader
                sqlCommand.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                isError = true;
                ErrorMsg = ex.Message;
                throw ex;
            }
            return isError;
        }

    }
}