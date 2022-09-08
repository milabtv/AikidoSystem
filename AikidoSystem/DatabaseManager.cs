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
        public bool UpdateAccount(Account account, Account acc)
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
            adpt.Dispose();
            return table;
        }
        public string SelectLogin(Account account)
        {
            string result = null;
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT Access FROM ACCOUNTS WHERE Username = @username AND Passsword = @password", connection);
                cmd.Parameters.AddWithValue("@username", account.Username);
                cmd.Parameters.AddWithValue("@password", account.Password);
                SqlDataReader reader1;
                reader1 = cmd.ExecuteReader();
                if (reader1.Read())
                {
                    result = reader1.GetValue(0).ToString();
                }
                reader1.Close();
            }

            catch (Exception)
            {
                result = null;
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
                SqlCommand cmd = new SqlCommand("UPDATE Halls SET Hall_name = @hall, Address = @address WHERE ID = @Id ", connection);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", hall.Id);
                cmd.Parameters.AddWithValue("@hall", hall.Name);
                cmd.Parameters.AddWithValue("@address", hall.Address);
                cmd.Parameters.AddWithValue("@h", h.Id);



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
                SqlCommand cmd = new SqlCommand("DELETE FROM Halls WHERE ID = @hall", connection);

                cmd.Parameters.AddWithValue("@hall", hall.Id);
                cmd.CommandType = CommandType.Text;



                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                successful = false;
            }

            return successful;
        }
        public DataTable SelectHalls()
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
                SqlCommand cmd = new SqlCommand("UPDATE Levels SET Level_name = @level, Level_type = @type WHERE ID = @Id ", connection);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", level.Id);
                cmd.Parameters.AddWithValue("@level", level.Name);
                cmd.Parameters.AddWithValue("@type", level.LevelType);
                cmd.Parameters.AddWithValue("@level", l.Id);



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
                SqlCommand cmd = new SqlCommand("DELETE FROM Levels WHERE ID = @level", connection);

                cmd.Parameters.AddWithValue("@level", level.Id);
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
            adpt.Dispose();

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
                SqlCommand cmd = new SqlCommand("UPDATE PaymentType SET Payment_name = @payment, Price = @pricee WHERE ID = @Id ", connection);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@payment", type.TypeName);
                cmd.Parameters.AddWithValue("@pricee", type.Price);
                cmd.Parameters.AddWithValue("@ID", t.Id);



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
                SqlCommand cmd = new SqlCommand("DELETE FROM PaymentType WHERE ID = @payment", connection);

                cmd.Parameters.AddWithValue("@payment", type.Id); ;
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM Kartoteki WHERE First_name LIKE str OR Last_name LIKE @str", connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@str", str);
            string selectquery = "SELECT * FROM Kartoteki WHERE First_name LIKE str OR Last_name LIKE @str";
            SqlDataAdapter adpt = new SqlDataAdapter(selectquery, connection);
            DataTable table = new DataTable();
            adpt.Fill(table);

            return table;
        }
        public DataTable SelectKartoteki()
        {
            SqlCommand cmd = new SqlCommand("SELECT EGN,First_name+' '+Last_name AS FULLNAME FROM Kartoteki", connection);
            cmd.CommandType = CommandType.Text;
            string selectquery = "SELECT EGN,First_name+' '+Last_name AS FULLNAME FROM Kartoteki";
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
                SqlCommand cmd = new SqlCommand("UPDATE Seminars SET Instructor_Name = @intructor,Place = @place,City = @city,Start_date = @start_d,End_date = @end_d WHERE Instructor_Name = @i AND Start_date = @sd  ", connection);

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
            string selectquery = "SELECT * FROM Seminars WHERE Instructor_Name LIKE str OR Start_date LIKE str OR End_date LIKE str";
            SqlDataAdapter adpt = new SqlDataAdapter(selectquery, connection);
            DataTable table = new DataTable();
            adpt.Fill(table);

            return table;
        }

        public bool InsertPart(int seminar, string kartoteka)
        {
            bool successful = true;

            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO SeminarsParticipation(Kartoteka,Seminar) Values(@kartoteka,@seminar)", connection);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@kartoteka", kartoteka);
                cmd.Parameters.AddWithValue("@seminar", seminar);


                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                successful = false;
            }

            return successful;
        }
        public bool UpdatePart(int seminar, int sem, string kartoteka, string kart)
        {
            bool successful = true;

            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE SeminarsParticipation SET Kartoteka = @kartoteka, Seminar = @seminar WHERE Kartoteka = @kart, Seminar = @sem", connection);

                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@kartoteka", kartoteka);
                cmd.Parameters.AddWithValue("@seminar", seminar);
                cmd.Parameters.AddWithValue("@kar", kart);
                cmd.Parameters.AddWithValue("@sem", sem);

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                successful = false;
            }

            return successful;
        }
        public bool DeletePart(int seminar, string kartoteka)
        {
            bool successful = true;

            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM SeminarsParticipation WHERE Kartoteka = @kartoteka, Seminar = @seminar", connection);

                cmd.Parameters.AddWithValue("@kartoteka", kartoteka);
                cmd.Parameters.AddWithValue("@seminar", seminar);
                cmd.CommandType = CommandType.Text;


                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                successful = false;
            }

            return successful;
        }
        public DataTable SelectPart(string str)
        {
            SqlCommand cmd = new SqlCommand("SELECT Kartoteki.First_name,Kartoteki.Last_Name,Seminars.Instructor_name,Seminars.City,Seminars.Start_Date,Seminars.End_date FROM (Seminars JOIN SeminarParticipation ON SeminarParticipation.Seminar = Seminars.ID) JOIN Kartoteki ON SeminarParticipation.Kartoteka = Kartoteki.EGN", connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@str", str);
            string selectquery = "SELECT Kartoteki.First_name,Kartoteki.Last_Name,Seminars.Instructor_name,Seminars.City,Seminars.Start_Date,Seminars.End_date FROM (Seminars JOIN SeminarParticipation ON SeminarParticipation.Seminar = Seminars.ID) JOIN Kartoteki ON SeminarParticipation.Kartoteka = Kartoteki.EGN";
            SqlDataAdapter adpt = new SqlDataAdapter(selectquery, connection);
            DataTable table = new DataTable();
            adpt.Fill(table);

            return table;
        }

        public bool InsertPayment(Payments payment, string kartoteka)
        {
            bool successful = true;

            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Payment(Kartoteka,Pay_date,Pay_month) Values(@kartoteka,@paydate,@month)", connection);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@kartoteka", kartoteka);
                cmd.Parameters.AddWithValue("@paydate", Convert.ToDateTime(payment.PaymentDate));
                cmd.Parameters.AddWithValue("@month", payment.PaymentMonth);



                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                successful = false;
            }
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO PaymentDetails() Values(@type,(SELECT ID FROM Payment WHERE Kartoteka = @kartoteka AND Pay_date = @paydate AND Pay_month = @month ))", connection);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@type", payment.PaymentType);
                cmd.Parameters.AddWithValue("@kartoteka", kartoteka);
                cmd.Parameters.AddWithValue("@paydate", Convert.ToDateTime(payment.PaymentDate));
                cmd.Parameters.AddWithValue("@month", payment.PaymentMonth);



                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                successful = false;
            }
            return successful;
        }
        public bool UpdatePayment(Payments payment, string kartoteka)
        {
            bool successful = true;

            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Payment SET Kartoteka = @kartoteka,Pay_date = @paydate,Pay_month = @month WHERE ID = @id", connection);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@kartoteka", kartoteka);
                cmd.Parameters.AddWithValue("@paydate", Convert.ToDateTime(payment.PaymentDate));
                cmd.Parameters.AddWithValue("@month", payment.PaymentMonth);
                cmd.Parameters.AddWithValue("id", payment.Id);

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                successful = false;
            }
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE PaymentDetails SET Payment_type = @type,Payment = (SELECT ID FROM Payment WHERE Kartoteka = @kartoteka AND Pay_date = @paydate AND Pay_month = @month )", connection);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@type", payment.PaymentType);
                cmd.Parameters.AddWithValue("@kartoteka", kartoteka);
                cmd.Parameters.AddWithValue("@paydate", Convert.ToDateTime(payment.PaymentDate));
                cmd.Parameters.AddWithValue("@month", payment.PaymentMonth);


                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                successful = false;
            }

            return successful;
        }
        public bool DeletePayments(Payments payment)
        {
            bool successful = true;

            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM PaymentDetails WHERE Payment_type = @type AND Payment = (SELECT ID FROM Payment WHERE Kartoteka = @kartoteka AND Pay_date = @paydate AND Pay_month = @month )", connection);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@type", payment.PaymentType);



                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                successful = false;
            }
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Payment WHERE Kartoteka = @kartoteka AND Pay_date = @paydate AND Pay_month = @month ", connection);

                cmd.CommandType = CommandType.Text;



                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                successful = false;
            }

            return successful;
        }
        public DataTable SelectPayment(string str)
        {

            SqlCommand cmd = new SqlCommand("SELECT Kartoteki.First_name,Kartoteki.Last_name,PaymentType.Payment_name,Payment.Pay_month,Payment.Pay_date FROM ((Kartoteki JOIN Payment ON Kartoteki.EGN = Payment.Kartoteka) JOIN PaymentDetails ON Payment.ID = PaymentDetails.Payment) JOIN PaymentType ON PaymentDetails.Payment_type = PaymentType.ID WHERE Kartoteki.First_name = @str", connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@str", str);

            string selectquery = "SELECT Kartoteki.First_name,Kartoteki.Last_name,PaymentType.Payment_name,Payment.Pay_month,Payment.Pay_date FROM ((Kartoteki JOIN Payment ON Kartoteki.EGN = Payment.Kartoteka) JOIN PaymentDetails ON Payment.ID = PaymentDetails.Payment) JOIN PaymentType ON PaymentDetails.Payment_type = PaymentType.ID WHERE Kartoteki.First_name LIKE '"+str+"'";
            SqlDataAdapter adpt = new SqlDataAdapter(selectquery, connection);
            DataTable table = new DataTable();
            adpt.Fill(table);

            return table;
        }

        public bool InsertGrupList(int group, string kartoteka)
        {
            bool successful = true;

            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO GroupList(Kartoteka,Group_name) Values(@kartoteka,@group)", connection);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@kartoteka", kartoteka);
                cmd.Parameters.AddWithValue("@seminar", group);


                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                successful = false;
            }

            return successful;
        }
        public bool UpdateGroupList(int group, int gr, string kartoteka, string kart)
        {
            bool successful = true;

            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE GroupListn SET Kartoteka = @kartoteka, Group_name = @group WHERE Kartoteka = @kart, Group_name = @gr", connection);

                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@kartoteka", kartoteka);
                cmd.Parameters.AddWithValue("@group", group);
                cmd.Parameters.AddWithValue("@kar", kart);
                cmd.Parameters.AddWithValue("@gr", gr);

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                successful = false;
            }

            return successful;
        }
        public bool DeleteGroupList(int gropup, string kartoteka)
        {
            bool successful = true;

            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM GroupList WHERE Kartoteka = @kart, Seminar = @gr", connection);

                cmd.Parameters.AddWithValue("@kart", kartoteka);
                cmd.Parameters.AddWithValue("@gr", gropup);
                cmd.CommandType = CommandType.Text;


                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                successful = false;
            }

            return successful;
        }
        public DataTable SelectGroupList(string str)
        {
            SqlCommand cmd = new SqlCommand("SELECT Kartoteki.First_name,Kartoteki.Last_Name,Groups.Group_name.FROM (Groups JOIN GroupList ON GroupList.Group_name = Groups.ID) JOIN Kartoteki ON GroupList.Kartoteka = Kartoteka.EGN", connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@str", str);
            string selectquery = "SELECT Kartoteki.First_name,Kartoteki.Last_Name,Groups.Group_name.FROM (Groups JOIN GroupList ON GroupList.Group_name = Groups.ID) JOIN Kartoteki ON GroupList.Kartoteka = Kartoteka.EGN";
            SqlDataAdapter adpt = new SqlDataAdapter(selectquery, connection);
            DataTable table = new DataTable();
            adpt.Fill(table);

            return table;
        }

        public bool InsertTimetable(Practices practice)
        {
            bool successful = true;

            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO GroupList(Instructor,GroupList,Hall,Weekday,Start_time,Duration) Values(@kartoteka,@group)", connection);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@kartoteka", practice.Kartoteka);
                cmd.Parameters.AddWithValue("@gr", practice.Group);
                cmd.Parameters.AddWithValue("@hall", practice.Hall);
                cmd.Parameters.AddWithValue("@week", practice.PracticeDay);
                cmd.Parameters.AddWithValue("@stra", practice.PracticeTime);
                cmd.Parameters.AddWithValue("@dur", practice.Duration);
                


                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                successful = false;
            }

            return successful;
        }
        
        public bool DeleteTimetablet(Practices practice)
        {
            bool successful = true;

            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Timetable WHERE Instructor = @kartoteka,GroupList = @gr,Hall = @hall,Weekday = @week,Start_time = @stra,Duration = @dur", connection);

                
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@kartoteka", practice.Kartoteka);
                cmd.Parameters.AddWithValue("@gr", practice.Group);
                cmd.Parameters.AddWithValue("@hall", practice.Hall);
                cmd.Parameters.AddWithValue("@week", practice.PracticeDay);
                cmd.Parameters.AddWithValue("@stra", practice.PracticeTime);
                cmd.Parameters.AddWithValue("@dur", practice.Duration);


                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                successful = false;
            }

            return successful;
        }
        public DataTable SelectTimetable(string str)
        {
            SqlCommand cmd = new SqlCommand("SELECT Kartoteki.First_name,Kartoteki.Last_Name,Groups.Group_name.FROM (Groups JOIN GroupList ON GroupList.Group_name = Groups.ID) JOIN Kartoteki ON GroupList.Kartoteka = Kartoteka.EGN", connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@str", str);
            string selectquery = "SELECT Kartoteki.First_name,Kartoteki.Last_Name,Groups.Group_name.FROM (Groups JOIN GroupList ON GroupList.Group_name = Groups.ID) JOIN Kartoteki ON GroupList.Kartoteka = Kartoteka.EGN";
            SqlDataAdapter adpt = new SqlDataAdapter(selectquery, connection);
            DataTable table = new DataTable();
            adpt.Fill(table);

            return table;
        }

        public bool InsertExams(Exam exams, string kartoteka)
        {
            bool successful = true;

            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Exams(Kartoteka,Level,Exam_day,Examiner) Values(@kartoteka,@level,@date,@examiner)", connection);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@kartoteka", kartoteka);
                cmd.Parameters.AddWithValue("@level", exams.Level);
                cmd.Parameters.AddWithValue("@date", Convert.ToDateTime(exams.ExamDate));
                cmd.Parameters.AddWithValue("@examiner", exams.Instructor1);


                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                successful = false;
            }

            return successful;
        }
        public bool UpdateExams(Exam exams, string kartoteka,int lev)
        {
            bool successful = true;

            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Exams SET Kartoteka = @kartoteka,Level = @level,Exam_day = @date,Examiner = @examiner WHERE Kartoteka = @kartoteka AND Level = @lev", connection);

                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@kartoteka", kartoteka);
                cmd.Parameters.AddWithValue("@level", exams.Level);
                cmd.Parameters.AddWithValue("@date", Convert.ToDateTime(exams.ExamDate));
                cmd.Parameters.AddWithValue("@examiner", exams.Instructor1);
                cmd.Parameters.AddWithValue("@lev", lev);

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                successful = false;
            }

            return successful;
        }
        public bool DeleteExams(Exam exams, string kartoteka)
        {
            bool successful = true;

            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Exams WHERE Kartoteka = @kart AND Level = @lev", connection);

                cmd.Parameters.AddWithValue("@kart", kartoteka);
                cmd.Parameters.AddWithValue("@lev", exams.Level);
                cmd.CommandType = CommandType.Text;


                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                successful = false;
            }

            return successful;
        }
        public DataTable SelectExams(string str)
        {
            SqlCommand cmd = new SqlCommand("SELECT Kartoteki.First_name,Kartoteki.Last_Name,Levels.Level_name,Exams.Examiner,Exams.Exam_day FROM (Exams JOIN Leveles ON Exams.Level = Levels.Level_name) JOIN Kartoteki ON Exams.Kartoteka = Kartoteka.EGN", connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@str", str);
            string selectquery = "SELECT Kartoteki.First_name,Kartoteki.Last_Name,Levels.Level_name,Exams.Examiner,Exams.Exam_day FROM (Exams JOIN Leveles ON Exams.Level = Levels.Level_name) JOIN Kartoteki ON Exams.Kartoteka = Kartoteka.EGN";
            SqlDataAdapter adpt = new SqlDataAdapter(selectquery, connection);
            DataTable table = new DataTable();
            adpt.Fill(table);

            return table;
        }
    }
}
