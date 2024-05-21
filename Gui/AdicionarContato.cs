using SistemaContatosBD.BancosDeDados;
using SistemaContatosBD.Dados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Gui
{
    public partial class AdicionarContato : Form
    {
        Thread t1;
        public AdicionarContato()
        {
            InitializeComponent();
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            if (txtNome.Text == "" || cbTipo.Text == "")
            {
                MessageBox.Show("Faltam informações para salvar o Contato.", "Campos vazios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Contato contato = new Contato(txtNome.Text, txtCelular.Text, txtTelefone.Text, txtEmail.Text, cbTipo.Text);

            Salvar.SalvarContato(contato);

            ConfirmacaoModal confirmacao = new ConfirmacaoModal();
            DialogResult result = confirmacao.ShowDialog();

            if (result == DialogResult.No)
            {
                this.Close();
                t1 = new Thread(AbrirMenu);
                t1.SetApartmentState(ApartmentState.STA);
                t1.Start();
                return;
            }

            txtNome.Text = "";
            txtTelefone.Text = "";
            txtCelular.Text = "";
            txtEmail.Text = "";
            cbTipo.Text = "";

        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(AbrirMenu);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void AbrirMenu(object obj) 
        {
            Application.Run(new MenuInicial());
        }
    }
}
