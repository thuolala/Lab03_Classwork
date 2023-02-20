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
    public partial class formDeptEmp : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString);
        public formDeptEmp()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Load Data 
        private void LoadData()
        {
            try
            {
                int index = dataGridViewDepartment.SelectedCells[0].RowIndex;
                if(index < 0 || index > dataGridViewDepartment.Rows.Count)
                {
                    MessageBox.Show("Please select a Department first!");
                    return; 
                }
                DataGridViewRow row = dataGridViewDepartment.Rows[index];
                //Get DNumber from DataGrid 
                int iDNo = int.Parse(row.Cells[1].Value.ToString());

                SqlCommand cmd = new SqlCommand("SELECT * FROM Employee WHERE DNo = " + iDNo, conn);
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
                dataGridViewEmployee.Refresh();
            }
            catch (Exception)
            {

            }
        }

        private void dataGridViewDepartment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadData();
            dataGridViewDepartment.Refresh();
            dataGridViewEmployee.Refresh();
        }

        private void dataGridViewEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void formDeptEmp_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Department", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridViewDepartment.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No Data!");
            }
            adapter.Dispose();
            LoadData();
        }
    }
}
