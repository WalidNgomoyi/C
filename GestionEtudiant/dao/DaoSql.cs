using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEtudiant.dao
{
    class DaoSql
    {
        private SqlConnection conn;
        //Execution des Requetes
        private SqlCommand cmd;
        //Convertir les en reigistrements
        private SqlDataAdapter da;

        public DaoSql()
        {
            conn = new SqlConnection();
            cmd = new SqlCommand();
            da = new SqlDataAdapter();
        }

        public void OuvrirConnexionBD()
        {
            if (conn.State == ConnectionState.Closed ||
                conn.State == ConnectionState.Broken)
            {
                conn.ConnectionString = @" Data Source=DESKTOP-S2O545F\MOTEUR1;Initial Catalog=gestion_etudiant;Integrated Security=True ";
                conn.Open();
            }

        }

        public void FermerConnexionBD()
        {
            if(conn.State== ConnectionState.Open ||
                conn.State== ConnectionState.Connecting)
            {
                conn.Close();
            }

        }

        public int ExecuteUpdate(string sql)
        {
            int nbreLigne = 0;

            OuvrirConnexionBD();

            cmd.Connection = conn;
            cmd.CommandText = sql;
            nbreLigne = cmd.ExecuteNonQuery();

            FermerConnexionBD();


            return nbreLigne;
        }

        public DataTable ExecuteSelect(string sql)
        {
            OuvrirConnexionBD();

            cmd.Connection = conn;
            cmd.CommandText = sql;
            //Dataset => Base de donnée enmemoire Centrale(RAM)
            // Dataset est formé de DataTable => Table BD
            DataSet ds = new DataSet();
            da.SelectCommand = cmd;
            da.Fill(ds, "result");

            FermerConnexionBD();

            return ds.Tables["classe"];
        }
    }
}
