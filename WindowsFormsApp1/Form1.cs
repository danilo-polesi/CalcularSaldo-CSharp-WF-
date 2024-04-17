using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MaterialSkin;
using MaterialSkin.Controls;

namespace WindowsFormsApp1
{
    public partial class Form1 : MaterialForm    {
        public Form1()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue800,
                Primary.Blue900,
                Primary.Blue500,
                Accent.LightBlue200, TextShade.WHITE);


         
        }

       private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtSA.Text = "0";
            txtDEP.Text = "0";
            txtSQ.Text = "0";
            lblSF.Text = "0";
            txtSA.Focus();
        }

        private void btbAdicionar_Click(object sender, EventArgs e)
        {
            float n1, n2, n3, result;
            n1 = float.Parse(txtSA.Text);
            n2 = float.Parse(txtDEP.Text);
            n3 = float.Parse(txtSQ.Text);
            result = n1 + n2 - n3;
            lblSF.Text = (result.ToString());


            if (result >= 0)
            {

                lblSF.ForeColor = Color.LimeGreen;
                lblSF.Text = (result.ToString());
                txtSA.Focus();

            }
            else
            {
                lblSF.ForeColor = Color.Red;
                //MessageBox.Show("Saldo Negativo!", "Precisando de empréstimo!?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSA.Focus();

            }

        }

        private void txtSQ_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
            
        }

        private void txtDEP_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
         
        }

        private void txtSA_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);

        }


     

        private void txtSA_MouseClick(object sender, MouseEventArgs e)
        {
            txtSA.Clear();
        }

        private void txtDEP_MouseClick(object sender, MouseEventArgs e)
        {
            txtDEP.Clear();
        }

        private void txtSQ_MouseClick(object sender, MouseEventArgs e)
        {
            txtSQ.Clear();
        }

        private void lblSF_Click(object sender, EventArgs e)
        {

        }
    }
}
