using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MySql.Data.MySqlClient;
using System.Data;

namespace FinalProject
{
    class GroupClass
    {
        myDataBase myDB = new myDataBase(); //Loads the class

        //Inserts a new group into the database
        public bool insertGroup(string gname, int userID)
        {
            //mysql command to insert a group from the name and useriD 
            MySqlCommand command = new MySqlCommand("INSERT INTO `groups`(`name`, `userid`) VALUES (@gn,@uid)", myDB.getConnection);
          
            //gets the information of the varibels
            command.Parameters.Add("@gn", MySqlDbType.VarChar).Value = gname;
            command.Parameters.Add("@uid", MySqlDbType.Int32).Value = userID;


            myDB.OpenConnection(); //opens a connection to the database

            if (command.ExecuteNonQuery() == 1)
            {
                myDB.CloseConnection(); //Closes the connection
                return true;
            }
            else
            {
                myDB.CloseConnection(); //cloes the conection
                return false;
            }
        }
        
        //Funciontion if the group already exists
        public bool groupExists(string gname, string operation, int userID = 0 , int gid = 0)
        {
            string query = "";

            MySqlCommand command = new MySqlCommand();

            //depending if the database should add information or edit it (OPERATION)
            if (operation == "add")
            {
                //selects the information from the groups database
                query = "SELECT * FROM `groups` WHERE `name`=@gn AND `userid`=@uid";
                command.Parameters.Add("@gn", MySqlDbType.VarChar).Value = gname;
                command.Parameters.Add("@uid", MySqlDbType.UInt32).Value = userID;
            }
            else if (operation == "edit")
            {
                //selcts information from the groups database and updates it and uploads it again
                query = "SELECT * FROM `groups` WHERE `name`=@gn AND `userid`=@uid AND `id`<>@gid";
                command.Parameters.Add("@gn", MySqlDbType.VarChar).Value = gname;
                command.Parameters.Add("@uid", MySqlDbType.UInt32).Value = userID;
                command.Parameters.Add("@gid", MySqlDbType.UInt32).Value = gid;

            }

            command.Connection = myDB.getConnection; //sets the connection to the database connection
            command.CommandText = query;


            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            //updates the datable
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //function to get the current groups
        public DataTable getGroups(int userID)
        {
            //selects the groups from the user
            MySqlCommand command = new MySqlCommand("SELECT * FROM `groups` WHERE `userid`=@uid", myDB.getConnection);

            command.Parameters.Add("@uid", MySqlDbType.Int32).Value = userID;

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable datatable = new DataTable();
            adapter.Fill(datatable);

            return datatable;
        }

        //Update the group
        public bool updateGroup(int gid, string gname)
        {   
                //mysql command to update the information of the group
                MySqlCommand command = new MySqlCommand("UPDATE `groups` SET `name`=@name WHERE `id`=@uid", myDB.getConnection);

                //command to set the updated infomation from the varibels
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = gname;
                command.Parameters.Add("@uid", MySqlDbType.Int32).Value = gid;

                myDB.OpenConnection(); //opens a connection to the database

                if (command.ExecuteNonQuery() == 1)
                {
                    myDB.CloseConnection(); //closes the database connection
                    return true;
                }
                else
                {
                    myDB.CloseConnection(); //closes the connection
                    return false;
                }
        }

        //function to remove the group from the databases
        public bool removeGroup(int groupID)
        {
            //Mysql command ereases the database of the selected group from the users groups
            MySqlCommand command = new MySqlCommand("DELETE FROM `groups` WHERE `id`=@id", myDB.getConnection);

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = groupID;

            myDB.OpenConnection(); //opens a connection to the database

            if (command.ExecuteNonQuery() == 1)
            {
                myDB.CloseConnection(); //closes the connection
                return true;
            }
            else
            {
                myDB.CloseConnection(); //closes the connection
                return false;
            }
        }
    }
}