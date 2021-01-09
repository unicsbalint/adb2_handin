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
         * students, borrows fül felépítése az eddigiek alapján.
         * authorid tartomány: 1-1000, bookid tartomány 1001-2000, borrowid tartomány: 2001-3000, studentid tartomány: 3001-,         
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
                //users tab
                label_privilege.Text = "USER";
                bt_usersList.Enabled = false;
                bt_user_list_delete.Enabled = false;
                //author tab
                bt_author_Add.Enabled = false;
                button2.Enabled = false; //delete
                bt_author_dummyData.Enabled = false;
                bt_author_modify.Enabled = false;
                //books tab
                bt_books_Add.Enabled = false;
                bt_books_delete.Enabled = false;
                bt_books_modify.Enabled = false;
                bt_books_dummyData.Enabled = false;
                //students tab
                bt_students_add.Enabled = false;
                bt_Students_delete.Enabled = false;
                bt_students_modify.Enabled = false;
                bt_students_dummyData.Enabled = false;
                //borrows tab
                bt_Borrows_add.Enabled = false;
                bt_borrows_delete.Enabled = false;
                bt_Borrows_Modify.Enabled = false;
                bt_borrows_DummyData.Enabled = false;
            }
            else
            {
                label_privilege.Text = "ADMINISTRATOR";
            }
            label_currectUser.Text = loginForm.loggedInUser;
            ListAuthors();
            ListBooks();
            ListStudents();
            ListBorrows();
            maxIDs();
            label_maxauthorID.Text = maxAuthorID.ToString();
            label_maxBooksID.Text = maxBookID.ToString();
        }


        static int maxAuthorID = 0;
        static int maxBookID = 0;
        static int maxStudentID = 0;
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
            cmd = string.Format("SELECT MAX(STUDENTID) FROM STUDENTS");
            command.CommandText = cmd;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                maxStudentID = int.Parse(reader["MAX(STUDENTID)"].ToString());
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
                try
                {
                    command.ExecuteNonQuery();
                }            
                catch (OracleException)
                {
                    MessageBox.Show(" integrity constraint violated");
                }
            }
            ListAuthors();
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
            maxIDs();
            Random rnd = new Random();
            for (int i = 0; i < int.Parse(tb_books_N_Dummydata.Text); i++)
            {
                string cmd = string.Format("INSERT INTO BOOKS (BOOKNAME,AUTHORID) VALUES ('{0}',{1})", randomBookName(), rnd.Next(1, maxAuthorID));
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
            ListBooks();
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


        //users tab
        #region
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
        private void bt_user_list_delete_Click(object sender, EventArgs e)
        {
            string selected = users_List.SelectedItem.ToString();
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
            string cmd = string.Format("DELETE FROM USERS WHERE USERNAME='{0}'", id);
            command.CommandText = cmd;
            command.Connection = connection;
            try
            {
                command.ExecuteNonQuery();
            }

            catch (OracleException)
            {
                MessageBox.Show("Nem törölhető adat");
            }
            cmd = string.Format("INSERT INTO LOG (LOG_MESSAGE) VALUES ('USER {0} DELETED BY {1}')", id, loginForm.loggedInUser);
            command.CommandText = cmd;
            command.ExecuteNonQuery();
        }

        #endregion

        //Students tab
        #region

        public void ListStudents()
        {
            students_List.Items.Clear();
            OracleConnection connection = new OracleConnection();
            connection.ConnectionString = @"Data Source=193.225.33.71;User Id=QPS1MZ;Password=EKE2020;";
            connection.Open();
            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.Text;
            string cmd = string.Format("SELECT * FROM STUDENTS ORDER BY STUDENTID");
            command.CommandText = cmd;
            command.Connection = connection;
            OracleDataReader reader = command.ExecuteReader();
            students_List.Items.Add("StudentID | Student Name | age");
            while (reader.Read())
            {
                students_List.Items.Add(string.Format("{0}| {1} | {2}", reader["STUDENTID"].ToString(), reader["STUDENTNAME"].ToString(), reader["STUDENTAGE"].ToString()));
            }
        }
        private void bt_Students_list_Click(object sender, EventArgs e)
        {
            ListStudents();
        }

        private void bt_Students_delete_Click(object sender, EventArgs e)
        {

            string selected = students_List.SelectedItem.ToString();
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
            string cmd = string.Format("DELETE FROM STUDENTS WHERE STUDENTID = {0}", id);
            command.CommandText = cmd;
            command.Connection = connection;
            try
            {
                command.ExecuteNonQuery();
                ListStudents();
            }

            catch (OracleException)
            {
                MessageBox.Show("Nem törölhető adat, mert egy másik táblában idegen kulcsként szolgál.");
            }
        }

        private void bt_students_add_Click(object sender, EventArgs e)
        {
            OracleConnection connection = new OracleConnection();
            connection.ConnectionString = @"Data Source=193.225.33.71;User Id=QPS1MZ;Password=EKE2020;";
            connection.Open();
            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.Text;
            string cmd = string.Format("INSERT INTO STUDENTS (STUDENTNAME,STUDENTAGE) VALUES ('{0}',{1})", tb_students_add_student_name.Text, tb_students_add_age.Text);
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
            ListStudents();
        }

        private void bt_students_modify_Click(object sender, EventArgs e)
        {
            OracleConnection connection = new OracleConnection();
            connection.ConnectionString = @"Data Source=193.225.33.71;User Id=QPS1MZ;Password=EKE2020;";
            connection.Open();
            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            string cmd = string.Format("UPDATE STUDENTS SET STUDENTNAME = '{0}', STUDENTAGE = {1} WHERE STUDENTID = {2}", tb_students_modify_studentName.Text,tb_students_modify_studentAge.Text,tb_students_modify_studentId.Text);
            command.CommandText = cmd;
            command.ExecuteNonQuery();
            ListStudents();
        }
        static string randomStudents()
        {
            List<string> first_name = new List<string>();
            List<string> last_name = new List<string>();
            Random a = new Random();

            first_name.Add("Nagy");
            first_name.Add("Dummy");
            first_name.Add("Baráthy");
            first_name.Add("Holecz");
            first_name.Add("Fekete");
            first_name.Add("Lakatos");
            first_name.Add("Cserneczky");
            first_name.Add("Oravecz");
            first_name.Add("Bakos");
            first_name.Add("Surányi");
            first_name.Add("Váradi");

            last_name.Add("Bálint");
            last_name.Add("Fruzsina");
            last_name.Add("Levente");
            last_name.Add("Norbert");
            last_name.Add("Márk");
            last_name.Add("Renáta");
            last_name.Add("Tünde");
            last_name.Add("Erik");
            last_name.Add("Balázs");
            last_name.Add("Zoltán");




            return first_name[a.Next(0,first_name.Count)] + " " + last_name[a.Next(0, last_name.Count)];
        }
        private void bt_students_dummyData_Click(object sender, EventArgs e)
        {
            OracleConnection connection = new OracleConnection();
            connection.ConnectionString = @"Data Source=193.225.33.71;User Id=QPS1MZ;Password=EKE2020;";
            connection.Open();
            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            Random rnd = new Random();
            for (int i = 0; i < int.Parse(tb_students_N_dummyData.Text); i++)
            {
                string cmd = string.Format("INSERT INTO STUDENTS (STUDENTNAME,STUDENTAGE) VALUES ('{0}',{1})", randomStudents(), rnd.Next(7,15));
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
            ListStudents();
        }
        #endregion

        //borrows tab
        #region
        public void ListBorrows()
        {
            borrows_List.Items.Clear();
            OracleConnection connection = new OracleConnection();
            connection.ConnectionString = @"Data Source=193.225.33.71;User Id=QPS1MZ;Password=EKE2020;";
            connection.Open();
            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.Text;
            string cmd = string.Format("SELECT * FROM BORROWS ORDER BY BORROWID");
            command.CommandText = cmd;
            command.Connection = connection;
            OracleDataReader reader = command.ExecuteReader();
            borrows_List.Items.Add("BORROW_ID | STUDENT_ID | BOOK_ID");
            while (reader.Read())
            {
                borrows_List.Items.Add(string.Format("{0}| {1} | {2}", reader["BORROWID"].ToString(), reader["STUDENTID"].ToString(), reader["BOOKID"].ToString()));
            }
        }
        private void bt_borrows_list_Click(object sender, EventArgs e)
        {
            ListBorrows();
        }

        private void bt_borrows_delete_Click(object sender, EventArgs e)
        {
            string selected = borrows_List.SelectedItem.ToString();
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
            string cmd = string.Format("DELETE FROM BORROWS WHERE BORROWID = {0}", id);
            command.CommandText = cmd;
            command.Connection = connection;
            try
            {
                command.ExecuteNonQuery();
                ListBorrows();
            }

            catch (OracleException)
            {
                MessageBox.Show("Nem törölhető adat, mert egy másik táblában idegen kulcsként szolgál.");
            }
        }

        private void bt_Borrows_add_Click(object sender, EventArgs e)
        {
            OracleConnection connection = new OracleConnection();
            connection.ConnectionString = @"Data Source=193.225.33.71;User Id=QPS1MZ;Password=EKE2020;";
            connection.Open();
            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.Text;
            string cmd = string.Format("INSERT INTO BORROWS (STUDENTID,BOOKID) VALUES ('{0}',{1})", tb_borrows_add_studentId.Text,tb_borrows_add_bookId.Text);
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
            ListBorrows();
        }

        private void bt_Borrows_Modify_Click(object sender, EventArgs e)
        {
            OracleConnection connection = new OracleConnection();
            connection.ConnectionString = @"Data Source=193.225.33.71;User Id=QPS1MZ;Password=EKE2020;";
            connection.Open();
            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            string cmd = string.Format("UPDATE BORROWS SET STUDENTID = '{0}', BOOKID = {1} WHERE BORROWID = {2}", tb_borrows_modify_studentId.Text,tb_borrows_modify_bookId.Text,tb_borrows_modify_borrowid.Text);
            command.CommandText = cmd;
            try
            {
                command.ExecuteNonQuery();
            }       
            catch(OracleException)
            {
                MessageBox.Show("Nem változtathatod meg! Ellenőzird az esetleges egyezéseket a többi táblában.");
            }
            ListBorrows();
        }

        private void bt_borrows_DummyData_Click(object sender, EventArgs e)
        {
            OracleConnection connection = new OracleConnection();
            connection.ConnectionString = @"Data Source=193.225.33.71;User Id=QPS1MZ;Password=EKE2020;";
            connection.Open();
            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            Random rnd = new Random();
            maxIDs();

            for (int i = 0; i < int.Parse(tb_borrows_N_dummyData.Text); i++)
            {
                string cmd = string.Format("INSERT INTO BORROWS (STUDENTID,BOOKID) VALUES ('{0}',{1})", maxStudentID++, maxBookID++);
                command.CommandText = cmd;
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (OracleException)
                {
                    
                }
            }
            ListBorrows();
        }

        #endregion

        private void bt_call_function_Click(object sender, EventArgs e)
        {
            OracleConnection connection = new OracleConnection();
            connection.ConnectionString = @"Data Source=193.225.33.71;User Id=QPS1MZ;Password=EKE2020;";
            connection.Open();
            string id = tb_sfcall_id.Text;
            OracleCommand command = new OracleCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "checkID";
            command.Connection = connection;
            OracleParameter returnValue = new OracleParameter()
            {
                Direction = System.Data.ParameterDirection.ReturnValue,
                DbType = System.Data.DbType.String
            };
            command.Parameters.Add(returnValue);
            OracleParameter checkIDparam = new OracleParameter()
            {
                ParameterName = "p_a",
                Direction = System.Data.ParameterDirection.Input,
                DbType = System.Data.DbType.Int32,
                Value = id
            };
            command.Parameters.Add(checkIDparam);
            
            command.ExecuteNonQuery();
            //MessageBox.Show(returnValue.Value.ToString());
            
        }
    }
}
