using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
namespace adb2_handInProject
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void bt_registerfromform_Click(object sender, EventArgs e)
        {
            if (tb_password.Text == tb_rePassword.Text)
            {
                OracleConnection connection = new OracleConnection();
                connection.ConnectionString = @"Data Source=193.225.33.71;User Id=QPS1MZ;Password=EKE2020;";
                connection.Open();
                OracleCommand command = new OracleCommand();
                command.CommandType = CommandType.Text;
                string cmd = string.Format("INSERT INTO USERS (USERNAME,USERPASSWORD) VALUES ('{0}','{1}')",tb_username.Text,tb_rePassword.Text);
                command.CommandText = cmd;
                command.Connection = connection;
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Sikeres regisztráció");
                    cmd = string.Format("INSERT INTO LOG (LOG_MESSAGE) VALUES ('USER {0} REGISTERED')", tb_username.Text);
                    command.CommandText = cmd;
                    command.ExecuteNonQuery();
                }
                catch (Oracle.ManagedDataAccess.Client.OracleException)
                {
                    MessageBox.Show("Ellenőrizd, hogy létezik -e már ilyen felhasználó");
                }
            }
            else
            {
                MessageBox.Show("nem egyeznek"); 
            }
        }
    }
}
