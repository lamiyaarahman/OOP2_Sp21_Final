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
using System.Collections;

namespace SuperShop
{
    public partial class Deleteinfo : Form
    {
        public Deleteinfo()
        {
            InitializeComponent();
        }

        private void Deleteinfo_Load(object sender, EventArgs e)
        {
            var employee = GetAllInfo();

            dtgvInfo.DataSource = employee;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connString = @"Server=DESKTOP-PBCEPRI;Database=Shop;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            string query = "delete from employee where id=" + eDelete.Text;
            SqlCommand cmd = new SqlCommand(query, conn);
            int d = cmd.ExecuteNonQuery();
            Info i = new Info();

            if (d > 0)
            {
                MessageBox.Show("Successfully deleted");
            }
            else
            {
                MessageBox.Show("Faild to delete");
            }
            conn.Close();

            var employee = GetAllInfo();
            dtgvInfo.DataSource = employee;





        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var employee = GetAllInfo();

            dtgvInfo.DataSource = employee;

        }

        List<Info> GetAllInfo()
        {
            string connString = @"Server=DESKTOP-PBCEPRI;Database=Shop;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connString);
            List<Info> employee = new List<Info>();
            conn.Open();

            string query = "select * from employee";
            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Info i = new Info();
                i.id = reader.GetInt32(reader.GetOrdinal("id"));
                i.employeename = reader.GetString(reader.GetOrdinal("employeename"));
                i.address = reader.GetString(reader.GetOrdinal("address"));
                i.phone = reader.GetString(reader.GetOrdinal("phone"));
                i.salary = reader.GetString(reader.GetOrdinal("salary"));

                employee.Add(i);
            }




            conn.Close();
            return employee;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            register login = new register();
            login.Show();
        }
        /*private override void OnFormClosing(FormClosingEventArgs e)
        {
            {
                base.OnFormClosing(e);
                if (e.CloseReason != CloseReason.WindowsShutDown)
                    Application.Exit();
            }
        }*/

    }
}
