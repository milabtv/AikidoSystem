using AikidoSystem.Objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AikidoSystem
{
    sealed class DatabaseManager : IDisposable
    {
        private static DatabaseManager instance = null;
        private string connectionString;
        private SqlConnection connection;
        public DatabaseManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DatabaseManager();
                }
                return instance;
            }
        }

        public DatabaseManager()
        {
            try
            {
                connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"" + Path.GetFullPath(Directory.GetCurrentDirectory() + "\\..\\..\\Database\\AikiData.mdf") + "\";Integrated Security=True";
                connection = new SqlConnection(connectionString);
                connection.Open();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void Dispose()
        {
            connection.Close();
            instance = null;
        }
        public bool InsertAccount(Account account)
        {
            bool successful = true;

            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Accounts (Username,Passsword,Access)VALUES(@username, @password, @access)", connection);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@username", account.Username);
                cmd.Parameters.AddWithValue("@password", account.Password);
                cmd.Parameters.AddWithValue("@access", account.Access);


                cmd.ExecuteNonQuery();
        }
            catch (Exception)
            {
                successful = false;
            }

            return successful;
        }
        public bool UpdateAccount(Account account,Account acc)
        {
            bool successful = true;

            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Accounts SET Username = @username,Passsword = @password, Access=@access WHERE Username = @accnew ", connection);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@username", account.Username);
                cmd.Parameters.AddWithValue("@password", account.Password);
                cmd.Parameters.AddWithValue("@access", account.Access);
                cmd.Parameters.AddWithValue("@accnew", acc.Username);

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                successful = false;
            }

            return successful;
        }
        public bool DeleteAccount(Account account)
        {
            bool successful = true;

            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Accounts WHERE Username = @username", connection);

                cmd.Parameters.AddWithValue("@username", account.Username);
                cmd.CommandType = CommandType.Text;
                    
                

                cmd.ExecuteNonQuery();
        }
            catch (Exception)
            {
                successful = false;
            }

            return successful;
        }
        public DataTable SelectAccounts()
        {                       
                SqlCommand cmd = new SqlCommand("SELECT * FROM ACCOUNTS", connection);
                cmd.CommandType = CommandType.Text;
                string selectquery = "SELECT * FROM ACCOUNTS";
                SqlDataAdapter adpt = new SqlDataAdapter(selectquery, connection);
                DataTable table = new DataTable();
                adpt.Fill(table);            
                        
            return table;
        }
        public bool SelectLogin(Account account,string status)
        {
            bool result = false;
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT * FROM ACCOUNTS WHERE Username == @username AND Passsword == @password", connection);
                cmd.Parameters.AddWithValue("@username", account.Username);
                cmd.Parameters.AddWithValue("@password", account.Password);
                cmd.ExecuteNonQuery();
                SqlDataReader reader1;
                reader1 = cmd.ExecuteReader();
                if (reader1.Read())
                {
                    status = reader1.GetValue(3).ToString();
                }
            }

            catch (Exception)
            {
                result = false;
            }

            return result;
        }

        public bool InsertHalls(Hall hall)
        {
            bool successful = true;

            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Halls (Hall_name,Address)VALUES(@hall, @address)", connection);

                cmd.CommandType = CommandType.Text;
                
                cmd.Parameters.AddWithValue("@hall", hall.Name);
                cmd.Parameters.AddWithValue("@address", hall.Address);


                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                successful = false;
            }

            return successful;
        }
        public bool UpdateHalls(Hall hall, Hall h)
        {
            bool successful = true;

            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Halls SET Hall_name = @hall, Address = @address WHERE Hall_name = @h, Address = @a ", connection);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", hall.Id);
                cmd.Parameters.AddWithValue("@hall", hall.Name);
                cmd.Parameters.AddWithValue("@address", hall.Address);
                cmd.Parameters.AddWithValue("@h", h.Name);
                cmd.Parameters.AddWithValue("@a", h.Address);


                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                successful = false;
            }

            return successful;
        }
        public bool DeleteHalls(Hall hall)
        {
            bool successful = true;

            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Halls WHERE Hall_namee = @hall", connection);

                cmd.Parameters.AddWithValue("@hall", hall.Name);
                cmd.CommandType = CommandType.Text;



                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                successful = false;
            }

            return successful;
        }
        public DataTable SelectHalls ()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Halls", connection);
            cmd.CommandType = CommandType.Text;
            string selectquery = "SELECT * FROM Halls";
            SqlDataAdapter adpt = new SqlDataAdapter(selectquery, connection);
            DataTable table = new DataTable();
            adpt.Fill(table);

            return table;
        }

        public bool InsertLevels(KyuLevels level)
        {
            bool successful = true;

            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Halls (Level_name,Level_type)VALUES( @level, @type)", connection);

                cmd.CommandType = CommandType.Text;
               
                cmd.Parameters.AddWithValue("@level", level.Name);
                cmd.Parameters.AddWithValue("@type", level.LevelType);


                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                successful = false;
            }

            return successful;
        }
        public bool UpdateLevels(KyuLevels level, KyuLevels l)
        {
            bool successful = true;

            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Levels SET Level_name = @level, Level_type = @type WHERE Level_name = @l, Level_type = @t ", connection);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", level.Id);
                cmd.Parameters.AddWithValue("@level", level.Name);
                cmd.Parameters.AddWithValue("@type", level.LevelType);
                cmd.Parameters.AddWithValue("@level", l.Name);
                cmd.Parameters.AddWithValue("@type", l.LevelType);


                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                successful = false;
            }

            return successful;
        }
        public bool DeleteLevels(KyuLevels level)
        {
            bool successful = true;

            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Levels WHERE Level_name = @level", connection);

                cmd.Parameters.AddWithValue("@level", level.Name);
                cmd.CommandType = CommandType.Text;



                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                successful = false;
            }

            return successful;
        }
        public DataTable SelectLevels()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Levels", connection);
            cmd.CommandType = CommandType.Text;
            string selectquery = "SELECT * FROM Levels";
            SqlDataAdapter adpt = new SqlDataAdapter(selectquery, connection);
            DataTable table = new DataTable();
            adpt.Fill(table);

            return table;
        }

        public bool InsertPaymentType(PaymentType type)
        {
            bool successful = true;

            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO PaymentType (Payment_name,Price)VALUES(@payment, @pricee)", connection);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@payment", type.TypeName);
                cmd.Parameters.AddWithValue("@pricee", type.Price);


                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                successful = false;
            }

            return successful;
        }
        public bool UpdatePaymentType(PaymentType type, PaymentType t)
        {
            bool successful = true;

            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE PaymentType SET Payment_name = @payment, Price = @pricee WHERE Payment_name = @pay, Price = @pr ", connection);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", type.Id);
                cmd.Parameters.AddWithValue("@payment", type.TypeName);
                cmd.Parameters.AddWithValue("@pricee", type.Price);
                cmd.Parameters.AddWithValue("@pay", type.TypeName);
                cmd.Parameters.AddWithValue("@pr", type.Price);


                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                successful = false;
            }

            return successful;
        }
        public bool DeletePaymentType(PaymentType type)
        {
            bool successful = true;

            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM PaymentType WHERE Payment_name = @payment", connection);

                cmd.Parameters.AddWithValue("@payment", type.TypeName); ;
                cmd.CommandType = CommandType.Text;



                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                successful = false;
            }

            return successful;
        }
        public DataTable SelectPaymentType()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM PaymentType", connection);
            cmd.CommandType = CommandType.Text;
            string selectquery = "SELECT * FROM PaymentType";
            SqlDataAdapter adpt = new SqlDataAdapter(selectquery, connection);
            DataTable table = new DataTable();
            adpt.Fill(table);

            return table;
        }


        public bool InsertKartoteka(Kartotekas kartoteka)
        {
            bool successful = true;

            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Kartoteki(EGN,First_name,Middle_name,Last_name,Telephone,Email_,Address) Values(@EGN,@first_name,@middle_name,@last_name,@telephone,@email_,@address)", connection);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@EGN", kartoteka.Egn);
                cmd.Parameters.AddWithValue("@firstName", kartoteka.FirstName);
                cmd.Parameters.AddWithValue("@middle_name", kartoteka.MiddleName);
                cmd.Parameters.AddWithValue("@lastName", kartoteka.LastName);
                cmd.Parameters.AddWithValue("@telephone", kartoteka.PhoneNumber);
                cmd.Parameters.AddWithValue("@email_", kartoteka.Email);
                cmd.Parameters.AddWithValue("@address", kartoteka.Address);


                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                successful = false;
            }

            return successful;
        }
        public bool UpdateKartoteka(Kartotekas kartoteka, Kartotekas k)
        {
            bool successful = true;

            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Kartoteki SET EGN = @EGN,First_name = @firstName,Middle_name = @middle_name,Last_name = @lastName,Telephone = @telephone,Email_ = @email_,Address = @address WHERE EGN = @e", connection);

                cmd.CommandType = CommandType.Text;
                
                cmd.Parameters.AddWithValue("@EGN", kartoteka.Egn);
                cmd.Parameters.AddWithValue("@firstName", kartoteka.FirstName);
                cmd.Parameters.AddWithValue("@middle_name", kartoteka.MiddleName);
                cmd.Parameters.AddWithValue("@lastName", kartoteka.LastName);
                cmd.Parameters.AddWithValue("@telephone", kartoteka.PhoneNumber);
                cmd.Parameters.AddWithValue("@email_", kartoteka.Email);
                cmd.Parameters.AddWithValue("@address", kartoteka.Address);

                cmd.Parameters.AddWithValue("@e", k.Egn);
               


                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                successful = false;
            }

            return successful;
        }
        public bool DeleteKartoteka(Kartotekas kartoteka)
        {
            bool successful = true;

            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Kartoteki WHERE EGN = @EGN", connection);

                cmd.Parameters.AddWithValue("@EGN", kartoteka.Egn);
                cmd.CommandType = CommandType.Text;



                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                successful = false;
            }

            return successful;
        }
        public DataTable SelectKartoteki(string str)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Kartoteki WHERE First_name LIKE str OR Last_name LIKE str", connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@str", str);
            string selectquery = "SELECT * FROM Kartoteki WHERE First_name LIKE str OR Last_name LIKE str";
            SqlDataAdapter adpt = new SqlDataAdapter(selectquery, connection);
            DataTable table = new DataTable();
            adpt.Fill(table);

            return table;
        }

        public bool InsertSeminars(Seminar seminar)
        {
            bool successful = true;

            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Seminars(Instructor_Name,Place,City,Start_date,End_date) Values(@instructor,@place,@city,@start_d,@end_d)", connection);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@intructor", seminar.InstructorName);
                cmd.Parameters.AddWithValue("@place", seminar.PlaceOfSeminar);
                cmd.Parameters.AddWithValue("@city", seminar.City);
                cmd.Parameters.AddWithValue("@start_d", DateTime.Parse(seminar.StartDate));
                cmd.Parameters.AddWithValue("@end_d", DateTime.Parse(seminar.EndDate));               


                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                successful = false;
            }

            return successful;
        }
        public bool UpdateSeminars(Seminar seminar, Seminar s)
        {
            bool successful = true;

            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Kartoteki SET Instructor_Name = @intructor,Place = @place,City = @city,Start_date = @start_d,End_date = @end_d WHERE Instructor_Name = @i AND Start_date = @sd  ", connection);

                cmd.CommandType = CommandType.Text;

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@intructor", seminar.InstructorName);
                cmd.Parameters.AddWithValue("@place", seminar.PlaceOfSeminar);
                cmd.Parameters.AddWithValue("@city", seminar.City);
                cmd.Parameters.AddWithValue("@start_d", DateTime.Parse(seminar.StartDate));
                cmd.Parameters.AddWithValue("@end_d", DateTime.Parse(seminar.EndDate));
                cmd.Parameters.AddWithValue("@i", seminar.InstructorName);
                cmd.Parameters.AddWithValue("@sd", DateTime.Parse(seminar.StartDate));            

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                successful = false;
            }

            return successful;
        }
        public bool DeleteSeminars(Seminar seminar)
        {
            bool successful = true;

            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Seminars WHERE Instructor_Name = @i AND Start_date = @sd", connection);

                cmd.Parameters.AddWithValue("@i", seminar.InstructorName);
                cmd.Parameters.AddWithValue("@sd", DateTime.Parse(seminar.StartDate));
                cmd.CommandType = CommandType.Text;


                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                successful = false;
            }

            return successful;
        }
        public DataTable SelectSeminars(string str)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Seminars WHERE Instructor_Name LIKE str OR Start_date LIKE str OR End_date LIKE str", connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@str", str);
            string selectquery = "SELECT * FROM Kartoteki WHERE First_name LIKE str OR Last_name LIKE str";
            SqlDataAdapter adpt = new SqlDataAdapter(selectquery, connection);
            DataTable table = new DataTable();
            adpt.Fill(table);

            return table;
        }


    }
}
