using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FinalProject
{
    class myDataBase
    {
        //Creates a mysql connection to the database
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=csharp_contacts_db");

        //Function to get the current connction to the database
        public MySqlConnection getConnection
        {
            get
            {
                return con;
            }
        }

        //Open a connection to the database
        public void OpenConnection()
        {
            if(con.State == ConnectionState.Closed) //If the state is closed
            {
                con.Open(); //open the connection
            }
        }
        public void CloseConnection()
        {
            if (con.State == ConnectionState.Open) //If the state is open
            {
                con.Close(); //Close the connection
            }
        }
    }
}
