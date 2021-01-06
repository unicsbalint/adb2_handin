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
/*
         * Teendők:
         * Dummy adatokkal feltöltés megvalósítása C# -on belül, auto increment implementálása oracleben, 
         * authorid tartomány: 1-1000, bookid tartomány 1001-2000, borrowid tartomány: 2001-3000, studentid tartomány: 3001-9000,         
         * */
namespace adb2_handInProject
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            if (loginForm.isAdmin != "1")
            {
                bt_usersList.Enabled = false;
                bt_user_list_delete.Enabled = false;
            }
            maxIDs();
            label_maxauthorID.Text = maxAuthorID.ToString();
            label_maxBooksID.Text = maxBookID.ToString();
        }


        static int maxAuthorID = 0;
        static int maxBookID = 0;
        public void maxIDs()
        {
            //

            OracleConnection connection = new OracleConnection();
            connection.ConnectionString = @"Data Source=193.225.33.71;User Id=QPS1MZ;Password=EKE2020;";
            connection.Open();
            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            string cmd = string.Format("SELECT MAX(AUTHORID) FROM AUTHOR");
            command.CommandText = cmd;

            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                maxAuthorID = int.Parse(reader["MAX(AUTHORID)"].ToString());
            }
            cmd = string.Format("SELECT MAX(BOOKID) FROM BOOKS");
            command.CommandText = cmd;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                maxBookID = int.Parse(reader["MAX(BOOKID)"].ToString());
            }
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
            
            string cmd = string.Format("UPDATE AUTHOR SET authorname = '{1}', numberofbooks = {2} WHERE authorid = {0}", tb_author_modify_authorID.Text, tb_author_modify_authorName.Text, tb_author_modify_booksWritten.Text);
            command.CommandText = cmd;          
            command.ExecuteNonQuery();
            
            
        }

       

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
        #endregion

        //Books tab
        #region
        public void ListBooks()
        {
            bookList.Items.Clear();
            OracleConnection connection = new OracleConnection();
            connection.ConnectionString = @"Data Source=193.225.33.71;User Id=QPS1MZ;Password=EKE2020;";
            connection.Open();
            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.Text;
            string cmd = string.Format("SELECT * FROM BOOKS ORDER BY bookid");
            command.CommandText = cmd;
            command.Connection = connection;
            OracleDataReader reader = command.ExecuteReader();
            bookList.Items.Add("BookID | BookName | AuthorID");
            while (reader.Read())
            {
                bookList.Items.Add(string.Format("{0}| {1} | {2}", reader["BOOKID"].ToString(), reader["BOOKNAME"].ToString(), reader["AUTHORID"].ToString()));
            }
        }
        private void bt_books_list_Click(object sender, EventArgs e)
        {
            ListBooks();   
        }

        private void bt_books_delete_Click(object sender, EventArgs e)
        {

            string selected = bookList.SelectedItem.ToString();
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
            string cmd = string.Format("DELETE FROM BOOKS WHERE bookID = {0}", id);
            command.CommandText = cmd;
            command.Connection = connection;
            try
            {
                command.ExecuteNonQuery();
                ListBooks();
            }

            catch (OracleException)
            {
                MessageBox.Show("Nem törölhető adat, mert egy másik táblában idegen kulcsként szolgál.");
            }
        }

        static string randomBookName()
        {
            Random a = new Random();
            List<string> name1 = new List<string>();
            List<string> name2 = new List<string>();
            name1.Add("The");
            name1.Add("For the");
            name1.Add("Fight");
            name1.Add("It is");
            name1.Add("Challange");
            name1.Add("Extraordinary");
            name1.Add("Unbelieveable");
            name1.Add("Chapter");
            name1.Add("Dummy");

            name2.Add("Text");
            name2.Add("Light");
            name2.Add("Night");
            name2.Add("Dummy");
            name2.Add("Idea");
            name2.Add("Book");
            name2.Add("Hey");
            return name1[a.Next(0, name1.Count)] + " " + name2[a.Next(0, name2.Count)];
        }
        private void bt_books_dummyData_Click(object sender, EventArgs e)
        {
            OracleConnection connection = new OracleConnection();
            connection.ConnectionString = @"Data Source=193.225.33.71;User Id=QPS1MZ;Password=EKE2020;";
            connection.Open();
            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            Random rnd = new Random();
            for (int i = 0; i < int.Parse(tb_books_N_Dummydata.Text); i++)
            {
                string cmd = string.Format("INSERT INTO BOOKS (BOOKNAME,AUTHORID) VALUES ('{0}',{1})", randomBookName(), rnd.Next(1, maxAuthorID-1));
                command.CommandText = cmd;
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (OracleException)
                {
                   
                    MessageBox.Show("Valami nem jó");
                }
            }
        }

        private void bt_books_Add_Click(object sender, EventArgs e)
        {
            OracleConnection connection = new OracleConnection();
            connection.ConnectionString = @"Data Source=193.225.33.71;User Id=QPS1MZ;Password=EKE2020;";
            connection.Open();
            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.Text;
            string cmd = string.Format("INSERT INTO BOOKS (BOOKNAME,AUTHORID) VALUES ('{0}',{1})",tb_books_bookName.Text,tb_books_authorId.Text);
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
             ListBooks();
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            
        }

        private void bt_books_modify_Click(object sender, EventArgs e)
        {
            OracleConnection connection = new OracleConnection();
            connection.ConnectionString = @"Data Source=193.225.33.71;User Id=QPS1MZ;Password=EKE2020;";
            connection.Open();
            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            string cmd = string.Format("UPDATE BOOKS SET bookname = '{0}', authorid = {1} WHERE bookid = {2}", tb_books_book_name.Text, tb_books_author_id.Text, tb_books_bookId.Text);
            command.CommandText = cmd;
            command.ExecuteNonQuery();
        }

        private void tab_Users_Click(object sender, EventArgs e)
        {

        }


        #endregion

        //Student tab

        //users tab
        private void bt_usersList_Click(object sender, EventArgs e)
        {
            users_List.Items.Clear();
            OracleConnection connection = new OracleConnection();
            connection.ConnectionString = @"Data Source=193.225.33.71;User Id=QPS1MZ;Password=EKE2020;";
            connection.Open();
            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.Text;
            string cmd = string.Format("SELECT * FROM USERS");
            command.CommandText = cmd;
            command.Connection = connection;
            OracleDataReader reader = command.ExecuteReader();
            users_List.Items.Add("USERNAME | IS ADMIN? (if nothing is shown it means no) ");
            while (reader.Read())
            {
                users_List.Items.Add(string.Format("{0}| {1}", reader["USERNAME"].ToString(), reader["ISADMIN"].ToString()));
            }
        }
        private void bt_register_Click(object sender, EventArgs e)
        {
            
            register reg = new register();
            reg.Show();
            
        }
    }
}
