namespace Calculadora_funcional
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            FormCalculadora formCalculadora = new FormCalculadora();

            formCalculadora.Show();
        }
    }
}
