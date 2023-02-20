using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_Classwork
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void departmentAndEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formEmployee f = new formEmployee();
            f.ShowDialog();
        }

        private void dependentForEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formDeptEmp f = new formDeptEmp();
            f.ShowDialog();
        }

        private void oleDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formOleDB f = new formOleDB();
            f.ShowDialog();
        }

        private void formMain_Load(object sender, EventArgs e)
        {

        }
    }
}
