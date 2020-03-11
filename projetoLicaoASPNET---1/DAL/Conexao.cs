using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace projetoLicaoASPNET___1.DAL
{
    public class Conexao
    {

        private SqlConnection con;

        public Conexao()
        {

            con = new SqlConnection();

            con.ConnectionString = @"DATA SOURCE=(local);
                                     INITIAL CATALOG=LICAO1;
                                     INTEGRATED SECURITY=true;";

        }

        public SqlConnection conectar()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

            return con;

        }

        public void disconectar()
        {

            if (con.State == ConnectionState.Open)
                con.Close();

        }

    }
}