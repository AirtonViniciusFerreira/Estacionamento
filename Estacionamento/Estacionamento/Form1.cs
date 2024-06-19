using Estacionamento.Geral.Controles;

namespace Estacionamento
{
    public partial class Form1 : Form
    {
        MenuControle menuControle = new MenuControle();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuControle.Dock = DockStyle.Fill;
            tlpPainelFundo
                .Controls
                .Add(menuControle, 0, 0);
        }
    }
}
