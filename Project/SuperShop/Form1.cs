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
    public partial class Form1 : Form
    {
        public Form1()
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

        private void Form1_Load(object sender, EventArgs e)
        {

            var employee = GetAllInfo();
            dtgvInfo.DataSource = employee;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            /*  string ename = eName.Text;
               string address = eAddress.Text;
               string phone = ePhone.Text;
               string salary= eSalary.Text;*/

            string ename = "";
            string address = "";
            string phone = "";
            string salary = "";

            string ErrMsg = null;

            if (eName.Text.Equals(""))
            {
                ErrMsg += "Customer name please*";
            }
            else
            {
                ename = eName.Text;
            }
            if (eAddress.Text.Equals(""))
            {
                ErrMsg += "\n Fill up the Address*";
            }
            else
            {
                address = eAddress.Text;
            }
            if (ePhone.Text.Equals(""))
            {
                ErrMsg += "\nCorrect PhoneNumber*";
            }
            else
            {
                phone = ePhone.Text;
            }

            if (eSalary.Text.Equals(""))
            {
                ErrMsg += "\nFill this Form*";
            }
            else
            {
                salary = eSalary.Text;
            }

            if (ErrMsg == null)
            {
                string connString = @"Server=DESKTOP-PBCEPRI;Database=Shop;Integrated Security=true;";
                SqlConnection conn = new SqlConnection(connString);

                conn.Open();
                string query = string.Format("insert into employee values('{0}','{1}','{2}','{3}')", ename, address, phone, salary);
                SqlCommand cmd = new SqlCommand(query, conn);

                int r = cmd.ExecuteNonQuery();

                if (r > 0)
                {
                    MessageBox.Show("Employee Inserted");
                }
                else
                {
                    MessageBox.Show("Faild to Inserted");
                }
                conn.Close();
            }

            else
            {
                MessageBox.Show(ErrMsg);
            }

           

            
          

            var employee = GetAllInfo();
            dtgvInfo.DataSource = employee;
        }

        private void infoData_Click(object sender, EventArgs e)
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

        private void btnSearch_Click(object sender, EventArgs e)
        {

            string connString = @"Server=DESKTOP-PBCEPRI;Database=Shop;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            int id= Int32.Parse(eSearch.Text);
           
           
            string query = "select * from employee where id=" + id;
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            Info i = new Info();
            reader.Read();

            i.id = reader.GetInt32(reader.GetOrdinal("id"));

            i.employeename = reader.GetString(reader.GetOrdinal("employeename"));
            i.salary = reader.GetString(reader.GetOrdinal("salary"));


            enUpdate.Text = i.employeename;
            eUpdate.Text = i.salary;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(eSearch.Text);
            string salary = eUpdate.Text;


            string connString = @"Server=DESKTOP-PBCEPRI;Database=Shop;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            string query = string.Format("update employee set salary='{0}'where id={1}", salary, id);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            var employee = GetAllInfo();

            dtgvInfo.DataSource = employee;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Deleteinfo().Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            register login = new register();
            login.Show();
        }

       
    }
}
