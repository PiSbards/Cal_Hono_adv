using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cal_Honorários_adv
{
    public partial class frmApp : Form
    {
        public frmApp()
        {
            InitializeComponent();
            frmSplash splash = new frmSplash();
            splash.Show();
            Application.DoEvents();
            Thread.Sleep(1000);
            splash.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            double valor,porcento,final;
            if (txtNumProcesso.Text=="" && txtPorcento.Text=="" && txtValorCausa.Text=="")
            {
                MessageBox.Show("NÃO HÁ INFORMAÇÕES, PREENCHA TODOS OS CAMPOS.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                porcento = Convert.ToDouble(txtPorcento.Text);
                valor = Convert.ToDouble(txtValorCausa.Text);
                final = porcento * (valor/100);
                lblValor.Text = "R$" + final.ToString();
                lblProcesso.Text = txtNumProcesso.Text;
            }
        }

        private void txtNumProcesso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtNumProcesso;
            txtNumProcesso.Focus();
        }
    }
}
