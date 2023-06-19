using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using StudioManager;

namespace Jahresprojekt
{
    internal class SqlCommunication
    {

        static string connectionString = "server = (localdb)\\MSSQLLocalDB; integrated security = true; ";
       

        static SqlConnection con = new SqlConnection(connectionString);
        static SqlCommand cmd = new SqlCommand(" ", con);
        public string username = "";

        #region CreateDatabase
        public void CreateDatabase()
        {
            //create Database and check if there is already one 
            string nameDB = "MayrhoferAngelina";
            bool databaseExists = CheckDatabaseExists(connectionString, nameDB);

            //create Database and create tables
            if (databaseExists == false)
            {
                try
                {
                    con.Open();
                    cmd.CommandText = "Create Database " + nameDB;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    con.ConnectionString += "database =" + nameDB + ";";
                    con.Open();
                    cmd.CommandText = "Create Table login(" + "[username] NvarChar(50)," + "[password] NvarCHAR(100)," + "[userNum] integer, [crystal] integer)";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "Create Table shop(" + "[userNum] integer, [item] nvarchar(50))";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "Create Table score([rank] integer, [username] nvarchar(50), [highestScore] integer)";
                    cmd.ExecuteNonQuery();
                    //cmd.CommandText = "create table crystals([num] integer, [condition] nvarchar(50))";
                    cmd.CommandText = "insert into login (username, password, userNum, crystal) values ('admin', 'admin', 1, 10);";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "insert into score values (1, 'admin', 3);";
                    cmd.ExecuteNonQuery();

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    if (con.State != ConnectionState.Closed)
                        con.Close();
                }
            }
            else
            {

                con.ConnectionString += "database = " + nameDB + "; ";

            }

        }

        public static bool CheckDatabaseExists(string connectionString, string nameDB)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand($"SELECT db_id('{nameDB}')", connection))
                {
                    connection.Open();
                    return (command.ExecuteScalar() != DBNull.Value);
                    //ExecuteScalar schaut ob erste Spalte - erste Zeile null ist

                }
            }
        }
        #endregion

        #region Shop
        public void Crystals(int crystals, string username)
        {
            try
            {
                //update crystals to new value
                con.Open();
                cmd.CommandText = "update login set crystal = crystal + " +  crystals + "  where username = '" + username + "';";
                cmd.ExecuteNonQuery();
                con.Close();  
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
        }

        public int ShowCrystals(string username)
        {
            //look how much crystals the user has and show them in the shop
            int crystal = 0;
            try
            {
                con.Open();
                cmd.CommandText = "select crystal from login where username = '" + username + "';";
                SqlDataReader read = cmd.ExecuteReader();

                read.Read();
                if(read.HasRows)
                {
                    crystal = read.GetInt32(0);
                }
                read.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
            return crystal;
        }


        public bool OwnsItem(string username, string buyingObject)
        {
            //look if user already has the item and if yes return bool true
            int userNum = 0;
            bool owner = false;
            try
            {
                con.Open();
                cmd.CommandText = "select userNum from login where username = '" + username + "';";
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    userNum = reader.GetInt32(0);
                }
                reader.Close();
                if (userNum == 0)
                {
                    MessageBox.Show("There is no user.");
                }
                else
                {
                    cmd.CommandText = "select item from shop where userNum = " + userNum + "; ";
                    SqlDataReader read = cmd.ExecuteReader();
                    read.Read();
                    if (read.HasRows)
                    {
                        if (buyingObject.Equals(read[0].ToString()))
                        {

                            owner = true;
                        }

                    }
                    read.Close();

                    con.Close();
                }
                return owner;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
            return owner;
        }

        public void BuyObject(string buyingObject, string username)
        {

            //look if user has already this item and if not add it to his items 
            int userNum = 0;
            try
            {
                con.Open();
               
                cmd.CommandText = "select userNum from login where username = '" + username + "';";
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if(reader.HasRows)
                {
                    userNum = reader.GetInt32(0);
                }
                reader.Close();
                if(userNum == 0)    
                {
                    MessageBox.Show("There is no user.");
                }
                else
                {
                    cmd.CommandText = "select item from shop where userNum = " + userNum + "; ";
                    SqlDataReader read = cmd.ExecuteReader();
                    read.Read();
                    while (read.HasRows)
                    {
                        if (buyingObject.Equals(read[0].ToString()))
                        {
                            MessageBox.Show("This item is already in your collection!");
                            return;
                        }

                    }
                    read.Close();
                    cmd.CommandText = "insert into shop (userNum, item) values (" + userNum + ", '" + buyingObject + "');";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Congratulations! This item is now yours!");
                }
                con.Close();
            }
            catch(Exception ex)        
            {
                MessageBox.Show(ex.ToString());
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
            
        }
        #endregion

        #region Score 
        public void NewScore(TextBox rank, TextBox username, TextBox score)
        {
            //show score of everyone in Score Forms
            try
            {
                con.Open();
                cmd.CommandText = "Select username, highestScore from score order by highestScore desc;";
                SqlDataReader reader = cmd.ExecuteReader();
                string newLine = Environment.NewLine;
                int num = 1;

                if(reader.HasRows)
                {
                    while (reader.Read())
                    {
                        rank.Text += "" + num + newLine;
                        username.Text += reader[0].ToString() + newLine;
                        score.Text += reader[1].ToString() + newLine;
                        num++;

                    }
                    

                }

                con.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
        }

        public void AddToTable(int score, string username)
        {
            //look if current score is higher than older score if yes update to current score 
            try
            {
                con.Open();

                cmd.CommandText = "select username, highestScore from score where username = '" + username + "';";
                SqlDataReader read = cmd.ExecuteReader();
                read.Read();

                if(read.HasRows)
                {
                    if(score > read.GetInt32(1) )
                    {
                        read.Close();
                        cmd.CommandText = "update score set highestScore =  " + score + " where username = '" + username + "';";
                        cmd.ExecuteNonQuery();
                        con.Close();
                        return;
                    }
                    else { con.Close(); return;  }

                    
                }
                else
                {
                    read.Close();
                    int rank = 1;

                    cmd.CommandText = "select max(rank) from score;";
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    
                        if(reader.HasRows)
                        {
                            rank = reader.GetInt32(0) + 1;
                        }
                    
                    reader.Close();

                    cmd.CommandText = "insert into score(rank, username, highestScore) values (" + rank + ", '" + username + "'," + score + ");";
                    cmd.ExecuteNonQuery();

                }
                read.Close();
                con.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
        }

        //public DataTable ShowScore(DataGridView dgv)
        //{
        //    DataTable dataTable = new DataTable();
        //    try
        //    {
        //        con.Open();
        //        //put data from tables into DataGridView

        //        SqlDataAdapter adapter = new SqlDataAdapter("Select * from score order by highestScore desc", con);

        //        adapter.Fill(dataTable);

        //        dgv.DataSource = dataTable;
        //        con.Close();

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        MessageBox.Show(ex.ToString());
        //        if (con.State != ConnectionState.Closed)
        //            con.Close();
        //    }
        //    return dataTable;
        //}
        //public void AddDataDGV(DataGridView dataOverview, DataTable dataTable)
        //{
        //    SqlBulkCopy sql = new SqlBulkCopy(con);

        //    try
        //    {
        //        //delete from table so that we can insert all data at ones
        //        con.Open();
        //        cmd.CommandText = "delete from score";
        //        cmd.ExecuteNonQuery();

        //        //chooses in which table the data will be saved
        //        sql.DestinationTableName = "score";
        //        //it writes the data into dataTable 
        //        sql.WriteToServer(dataTable);
        //        MessageBox.Show("Daten wurden gespeichert!");
        //        con.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        if (con.State != ConnectionState.Closed)
        //        {
        //            con.Close();
        //        }

        //    }
        //}
        #endregion

        #region Login 
        public bool SignIn (string username, string password)
        {
            this.username = username;
            //look in database if username and password are existing
            bool correct = false;

            try
            {
                
                if(string.IsNullOrEmpty(username)|| string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Username or Password are Empty!");
                    return correct; 
                }
                con.Open();
                cmd.CommandText = "select password from login where username = '" + username + "';";
                
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string hashedPassword = reader.GetString(0);
                        if(BCrypt.CheckPassword(password, hashedPassword))
                        {
                            correct = true;
                        }
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
            return correct;

        }
        #endregion

        #region Register
        public void Register(string username,string password)
        {

            //look if username already exists and if not create new "account"
            int userNum = 1;
            try

            {
                BCrypt hallo = new BCrypt();
                string hashedPassword = BCrypt.HashPassword(password, BCrypt.GenerateSalt());
                con.Open();

                cmd.CommandText = "select username from login where username = '" + username + "';";
                //look if command gives 0 back 

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("Username already exists. Please enter a new one.");
                    reader.Close();
                    con.Close();

                }
                else
                {
                    reader.Close();

                    cmd.CommandText = "select max(userNum) from login;";
                    SqlDataReader read = cmd.ExecuteReader();
                    read.Read();
                    if (read.HasRows)
                    {
                        userNum = read.GetInt32(0) + 1;
                    }
                    read.Close();

                    cmd.CommandText = "insert into login (username, password, userNum) values ('" + username + "', '" + hashedPassword + "'," + userNum + ");";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User was successfully created!");
                }
                con.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
           

            
        }
        #endregion
    }
}
