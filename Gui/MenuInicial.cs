using System.Threading;

namespace Gui
{
    public partial class MenuInicial : Form
    {
        Thread t1;
        public MenuInicial()
        {
            InitializeComponent();
        }

        private void BtnAdicionarContato_Click(object sender, EventArgs e) 
        {
            this.Close();
            t1 = new Thread(AbrirAdicionarContato);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void BtnVerContato_Click(Object sender, EventArgs e) 
        {
            this.Close();
            t1 = new Thread(AbrirVerContato);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void AbrirVerContato(Object obj)
        {
            Application.Run(new VisualizarContato());
        }

        private void AbrirAdicionarContato (Object obj) 
        {
            Application.Run(new AdicionarContato());
        }
    }
}
