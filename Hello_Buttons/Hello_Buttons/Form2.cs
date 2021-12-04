using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_Buttons
{
    public partial class Form2 : Form
    {
        private Form1 pF;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form1 f)
        {
            InitializeComponent();
            f.BackColor = Color.Yellow;
            pF = f;
        }

        private void btnyes_Click(object sender, EventArgs e)
        {
            Form1 newForm1 = new Form1();
            newForm1.BackColor = Color.Blue;
            newForm1.Show();
        }

        private void btnno_Click(object sender, EventArgs e)
        {
            try
            {
                pF.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Oops! No Parent form");
            }
            finally { this.Close(); }
        }
    }
}
