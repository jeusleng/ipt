﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SplashScreenLadera
{
    class Connection
    {
        private SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\MARKA\SOURCE\REPOS\IPT\SPLASHSCREEN\SAMPLEDB.MDF");

        public SqlConnection getConnection()
        {
            return con;
        }

        public SqlCommand createCommand()
        {
            return con.CreateCommand();
        }

        public void openConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public void closeConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
