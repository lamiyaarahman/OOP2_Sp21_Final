using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SuperShop
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

       /* private override void OnFormClosing(FormClosingEventArgs e)
        {
            {
                base.OnFormClosing(e);
                if (e.CloseReason != CloseReason.WindowsShutDown)
                    Application.Exit();
            }
        }*/

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string username = uName.Text;
            string password = uPass.Text;
            string role = rCombo.Text;
            string ErrMsg = null;

            if (rCombo.Text.Equals(""))
            {
                ErrMsg += "Invalid Role";
            }
            else
            {
                username = rCombo.Text;
            }
            if (uName.Text.Equals(""))
            {
                ErrMsg += "\nUserName Required";
            }
            else
            {
                username = uName.Text;
            }



            if (uPass.Text.Equals(""))
            {
                ErrMsg += "\nPassword Required";
            }
            else
            {
                password = uPass.Text;
            }



            if (ErrMsg == null)
            {
                //MessageBox.Show("Login Successful");
            }
            else
            {
                MessageBox.Show(ErrMsg);
            }


            string connString = @"Server=DESKTOP-PBCEPRI;Database=Shop;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();



            string query = string.Format("SELECT * FROM LOGIN WHERE username= '{0}'and role='{1}'and password='{2}'", username, role, password);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            {



                if (reader.Read())
                {
                    this.Hide();
                    MessageBox.Show("Login Successful");
                    new Form1().Show();
                }
                else
                {
                    MessageBox.Show("Invalid user");
                }
                conn.Close();



            }

        }

        private void register_Load(object sender, EventArgs e)
        {

        }
        private void Loginbutton_Click(object sender, EventArgs e)
        {
            


        }



        private void Exitbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        


    }
}
    

