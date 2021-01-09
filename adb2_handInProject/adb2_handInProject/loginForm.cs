using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace adb2_handInProject
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }
        public static string isAdmin = "";
        public static string loggedInUser = "";
        private void bt_newLogin_Click(object sender, EventArgs e)
        {
            OracleConnection connection = new OracleConnection();
            connection.ConnectionString = @"Data Source=193.225.33.71;User Id=QPS1MZ;Password=EKE2020;";
            connection.Open();
            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.Text;
            string cmd = string.Format("SELECT username,userpassword,isadmin FROM users WHERE username = \'{0}\' AND userpassword = \'{1}\'",tb_username.Text,tb_password.Text);
            command.CommandText = cmd;
            command.Connection = connection;
            OracleDataReader reader = command.ExecuteReader();
            
            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    isAdmin = reader["isadmin"].ToString();
                }
                loggedInUser = reader["USERNAME"].ToString();
                connection.Close();
                Thread thread = new Thread(openMain);  
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
                this.Close();
            }
            else
            {
                MessageBox.Show("Hibás felhasználónév vagy jelszó");
            }
        }
        static void openMain()
        {
            Application.Run(new Main());
        }
    }
}
