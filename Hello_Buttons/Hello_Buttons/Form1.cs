namespace Hello_Buttons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnyes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("It's wonderful!");
        }

        private void btnno_MouseMove(object sender, MouseEventArgs e)
        {
            btnno.Top -= e.Y;
            btnno.Left += e.X;
            if (btnno.Top < -10 || btnno.Top > 100)
                btnno.Top = 60;
            if (btnno.Left < -80 || btnno.Left > 250)
                btnno.Left = 120;
        }

        private void btnext_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2(this);
            newForm.Show();
        }

        private void btnmdi_Click(object sender, EventArgs e)
        {
            Form3 newForm3 = new Form3();
            newForm3.Show();
        }
    }
}