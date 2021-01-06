using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace adb2_handInProject
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        //Authors tab
        #region 
        public void ListAuthors()
        {
            author_List.Items.Clear();
            OracleConnection connection = new OracleConnection();
            connection.ConnectionString = @"Data Source=193.225.33.71;User Id=QPS1MZ;Password=EKE2020;";
            connection.Open();
            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.Text;
            string cmd = string.Format("SELECT * FROM AUTHOR ORDER BY authorid");
            command.CommandText = cmd;
            command.Connection = connection;
            OracleDataReader reader = command.ExecuteReader();
            author_List.Items.Add("AuthorIds | Authorname | Number of released books");
            while (reader.Read())
            {
                author auth = new author();
                auth.AuthorId = int.Parse(reader["AUTHORID"].ToString());
                auth.AuthorName = reader["AUTHORNAME"].ToString();
                auth.NumberOfBooks = int.Parse(reader["NUMBEROFBOOKS"].ToString());
                author_List.Items.Add(string.Format("{0}| {1} | {2}", auth.AuthorId, auth.AuthorName, auth.NumberOfBooks));
            }
        }

        private void bt_author_List_Click(object sender, EventArgs e)
        {
            ListAuthors();
        }

        private void button2_Click(object sender, EventArgs e) //delete gomb
        {

           string selected = author_List.SelectedItem.ToString();
            string id = "";
            for (int i = 0; i < selected.Length; i++)
            {
                if (selected[i] != '|')
                {
                    id = id + selected[i];
                }
                else
                {
                    break;
                }
            }
            
                OracleConnection connection = new OracleConnection();
                connection.ConnectionString = @"Data Source=193.225.33.71;User Id=QPS1MZ;Password=EKE2020;";
                connection.Open();
                OracleCommand command = new OracleCommand();
                command.CommandType = CommandType.Text;
                string cmd = string.Format("DELETE FROM AUTHOR WHERE authorId = {0}", id);
                command.CommandText = cmd;
                command.Connection = connection;
                try
                {
                    command.ExecuteNonQuery();
                    ListAuthors();
                }

                catch (OracleException)
                {
                    MessageBox.Show("Nem törölhető adat, mert egy másik táblában idegen kulcsként szolgál.");
                }                     
        }


        private void tab_Author_Click(object sender, EventArgs e)
        {
            
        }
        /*
         * Teendők:
         * Dummy adatokkal feltöltés megvalósítása C# -on belül, auto increment implementálása oracleben, 
         * authorid tartomány: 1-1000, bookid tartomány 1001-2000, borrowid tartomány: 2001-3000, studentid tartomány: 3001-9000,  
         * 
         * Cserneczky Bálint
         * */
        private void bt_author_Add_Click(object sender, EventArgs e)
        {
            OracleConnection connection = new OracleConnection();
            connection.ConnectionString = @"Data Source=193.225.33.71;User Id=QPS1MZ;Password=EKE2020;";
            connection.Open();
            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.Text;
            string cmd = string.Format("INSERT INTO author (authorName,numberofBooks) VALUES ('{0}',{1})",tb_author_add_authorName.Text,tb_author_add_booksWritten.Text);
            command.CommandText = cmd;
            command.Connection = connection;
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Oracle.ManagedDataAccess.Client.OracleException)
            {

                MessageBox.Show("Ellenőrizd, hogy létezik -e már ilyen kulccsal bejegyzés.");
            }
            
                  
            ListAuthors();
        }
        static string randomName()
        {
            Random x = new Random();
            List<string> first_name = new List<string>();
            List<string> last_name = new List<string>();
            first_name.Add("Laszlo");
            first_name.Add("Csenge");
            first_name.Add("Attila");
            first_name.Add("Jozsef");
            first_name.Add("Evelin");
            first_name.Add("Balint");
            first_name.Add("Balazs");
            first_name.Add("Tihamer");
            first_name.Add("Ferenc");
            first_name.Add("Edina");
            first_name.Add("David");

            last_name.Add("Kiss");
            last_name.Add("Nagy");
            last_name.Add("Fulop");
            last_name.Add("Hatvani");
            last_name.Add("Fekete");
            last_name.Add("Feher");
            last_name.Add("Adam");
            last_name.Add("Cserneczky");
            last_name.Add("Barazsy");
            last_name.Add("Pasztor");
            last_name.Add("Gipsz");

            return last_name[x.Next(0,last_name.Count)] + " " + first_name[x.Next(0,last_name.Count)];
        }
        private void bt_author_modify_Click(object sender, EventArgs e)
        {
           

            OracleConnection connection = new OracleConnection();
            connection.ConnectionString = @"Data Source=193.225.33.71;User Id=QPS1MZ;Password=EKE2020;";
            connection.Open();
            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            
            string cmd = string.Format("INSERT INTO author (authorId,authorName,numberofBooks) VALUES ({0},'{1}',{2})", tb_author_modify_authorID.Text, tb_author_add_authorName.Text, tb_author_add_booksWritten.Text);
            command.CommandText = cmd;          
            command.ExecuteNonQuery();
            
            
        }

        #endregion

        private void bt_author_dummyData_Click(object sender, EventArgs e)
        {

            OracleConnection connection = new OracleConnection();
            connection.ConnectionString = @"Data Source=193.225.33.71;User Id=QPS1MZ;Password=EKE2020;";
            connection.Open();
            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            Random rnd = new Random();
            for (int i = 0; i < int.Parse(tb_author_dummyData.Text); i++)
            {
                string cmd = string.Format("INSERT INTO author (authorName,numberofBooks) VALUES ('{0}',{1})", randomName(),rnd.Next(1,100));
                command.CommandText = cmd;
                command.ExecuteNonQuery();
            }
        }
    }
}
