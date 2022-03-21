using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using MySql.Data.MySqlClient;

namespace FinalProject
{
    class UserCheck
    {
        //Load the required classes
        myDataBase db = new myDataBase();

        //Checks if the username already exists
        public bool usernameExist(string username, string operation, int userid = 0)
        {
            string query = "";
            if (operation == "register") //If user is trying to register a new account
            {
                //select from user database
               query = "SELECT * FROM `user` WHERE `username`=@un";
            }
            else if(operation == "edit") //if user is trying to edit current account
            {
                //select from the user database and the users ID
                query = "SELECT * FROM `user` WHERE `username`=@un AND id<>@uid";
            }

            //MYsql command to select from the current string query and get the current database connection
            MySqlCommand command = new MySqlCommand(query, db.getConnection);
            command.Parameters.Add("@un", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@uid", MySqlDbType.UInt32).Value = userid;

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            //Creates a datatable a fills it
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            if(dataTable.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Inserts a new user into the database
        public bool insertUser(string fname, string lname, string username, string password, MemoryStream Photo)
        {
            //Mysql command to add a new user to the database with the current information from the variabels
            MySqlCommand command = new MySqlCommand("INSERT INTO `user`(`fname`, `lname`, `username`, `pass`, `photo`) VALUES (@fn,@ln,@un,@pass,@photo)", db.getConnection);
            
            //Sets the correct information to the correct rows
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@un", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;
            command.Parameters.Add("@photo", MySqlDbType.Blob).Value = Photo.ToArray();

            db.OpenConnection(); //opens connection to the database

            if(command.ExecuteNonQuery() == 1)
            {
                db.CloseConnection(); //closes connection to the database
                return true;
            }
            else
            {
                db.CloseConnection(); //closes the connection to the database
                return false;
            }
        }

        //Datatable to get the current users ID
        public DataTable getUserID(Int32 userID)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            DataTable dataTable = new DataTable();

            //mysql command to grab the current userID from the database
            MySqlCommand command = new MySqlCommand("SELECT * FROM `user` WHERE `id`=@uid", db.getConnection);
            command.Parameters.Add("@uid", MySqlDbType.UInt32).Value = userID;

            adapter.SelectCommand = command;
            adapter.Fill(dataTable);

            return dataTable;
        }

        //function to update the users profile
        public bool UpdateUserProfile(int userID, string fname, string lname, string username, string password, MemoryStream Photo)
        {
            //mysql command to update the first name, lastnem, username, password and photo
            MySqlCommand command = new MySqlCommand("UPDATE `user` SET `fname`=@fn,`lname`=@ln,`username`=@un,`pass`=@pass,`photo`=@photo WHERE `id`=@uid", db.getConnection);

            //Sets the datbase information to the correct information from the form
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@un", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;
            command.Parameters.Add("@photo", MySqlDbType.Blob).Value = Photo.ToArray();
            command.Parameters.Add("@uid", MySqlDbType.Int32).Value = userID;

            db.OpenConnection(); //open conenction the database

            if (command.ExecuteNonQuery() == 1)
            {
                db.CloseConnection(); //Closes the connection
                return true;
            }
            else
            {
                db.CloseConnection(); //Closes the connection
                return false;
            }
        }

        //Updates only the users profile photo
        public bool UpdateUserProfilePhoto(int userID, MemoryStream Photo)
        {
            //Mysql command to update the users photo depending on what ID the user has
            MySqlCommand command = new MySqlCommand("UPDATE `user` SET `photo`=@photo WHERE `id`=@uid", db.getConnection);

            command.Parameters.Add("@photo", MySqlDbType.Blob).Value = Photo.ToArray();
            command.Parameters.Add("@uid", MySqlDbType.Int32).Value = userID;

            db.OpenConnection(); //Open connection to the database

            if (command.ExecuteNonQuery() == 1)
            {
                db.CloseConnection(); //Closes the connection to the database
                return true;
            }
            else
            {
                db.CloseConnection(); //Closes the connection to the database
                return false;
            }
        }
    }
}