using SistemaContatosBD.BancosDeDados;
using SistemaContatosBD.Dados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Gui
{
    public partial class VisualizarContato : Form
    {
        Thread t1;

        public VisualizarContato()
        {
            InitializeComponent();

            List<Contato> listaContato = new List<Contato>();

            listaContato = Carregar.CarregarContatos();

            DtContato.DataSource = listaContato;
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(AbrirMenuInicial);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void AbrirMenuInicial(Object obj)
        {
            Application.Run(new MenuInicial());
        }
    }
}
