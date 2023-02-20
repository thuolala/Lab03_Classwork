using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Lab03_Classwork
{
    public partial class formEmployee : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString);
        public formEmployee()
        {
            InitializeComponent();
        }

        //Load Data 
        private void LoadData()
        {
            try 
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Employee WHERE DNo = " + comboBoxDepartment.SelectedValue, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridViewEmployee.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No Data!");
                }
                adapter.Dispose();
            }
            catch (Exception)
            {

            }
        }

        private void formEmployee_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Department", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                comboBoxDepartment.DataSource = dt;
                comboBoxDepartment.DisplayMember = "DName";
                comboBoxDepartment.ValueMember = "DNumber";
                LoadData();
            }
            else
            {
                MessageBox.Show("No Data!");
            }
            adapter.Dispose();
        }

        private void comboBoxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridViewEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
