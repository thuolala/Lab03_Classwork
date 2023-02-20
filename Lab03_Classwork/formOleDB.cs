using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Security.Policy;

namespace Lab03_Classwork
{
    public partial class formOleDB : Form
    {
        OleDbCommand cmd;
        OleDbDataAdapter da;
        private BindingSource bindingSource = null;
        private OleDbCommandBuilder oleCommandBuilder = null;
        DataTable dt = new DataTable();
        //Read connection string from App.Config with name: MyConnOleDb
        String strConn = ConfigurationManager.ConnectionStrings["MyConnOleDb"].ConnectionString;

        public formOleDB()
        {
            InitializeComponent();
        }

        private void DataBind()
        {
            dataGridView1.DataSource = null;
            dt.Clear();
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            String sSQL = "SELECT * FROM Employee";
            cmd = conn.CreateCommand();
            cmd.CommandText = sSQL;
            try
            {
                da = new OleDbDataAdapter(sSQL, conn);
                oleCommandBuilder = new OleDbCommandBuilder(da);
                da.Fill(dt);
                bindingSource = new BindingSource { DataSource = dt };
                dataGridView1.DataSource = bindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        private void formOleDB_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit(); //very important step
            try
            {
                da.Update(dt); //Update data back to Database
                MessageBox.Show("Updated!");
                DataBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
