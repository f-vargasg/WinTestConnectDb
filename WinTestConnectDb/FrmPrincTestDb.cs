using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTestConnectDb
{
    public partial class FrmPrincTestDb : Form
    {
        public FrmPrincTestDb()
        {
            InitializeComponent();
        }

        private void TestConnBut_Click(object sender, EventArgs e)
        {
            try
            {
                TestDL testDL = new TestDL();

                List<TestBE> lst = testDL.LoadData();
                foreach (var item in lst)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
