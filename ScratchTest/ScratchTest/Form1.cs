using FormsDataAccess;
using MDDDataAccess;
using MDDFoundation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScratchTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var count = DBEngine.Default.SqlGetScalar<int>(textBox1.Text, false);
            MessageBox.Show($"Count of all the Clients: {count}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frm = new frmConnectDatabase(DBEngine.Default.ConnectionString.ConnectionString);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                DBEngine.Default = new DBEngine(frm.ConnectionString, "MDDScratchTest");
                DBEngine.Default.AllowAdHoc = true;
            }
        }
    }
}
