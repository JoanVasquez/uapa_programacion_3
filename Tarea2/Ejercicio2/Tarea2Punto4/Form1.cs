namespace Tarea2Punto4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtActitudesValores.Text.Length == 0 || txtExamen.Text.Length == 0 || txtPlataforma.Text.Length == 0 || txtTrabajoFinal.Text.Length == 0)
                {
                    MessageBox.Show("Debes llenar todos los campos");
                } else {
                    CalificacionModelo calificacionModelo = new CalificacionModelo();
                    calificacionModelo.TrabajoFinal = int.Parse(txtTrabajoFinal.Text);
                    calificacionModelo.Plataforma = int.Parse(txtPlataforma.Text);
                    calificacionModelo.Examen = int.Parse(txtExamen.Text);
                    calificacionModelo.ActitudesValores = int.Parse(txtActitudesValores.Text);

                    CalificacionServicio calificacionServicio = new CalificacionServicio();
                    lblCalificacionLiteral.Text = lblCalificacionLiteral.Text + " : " + calificacionServicio.calcularLiteral(calificacionModelo);
                    lblNota.Text = lblNota.Text + " : " + calificacionServicio.calcularNota(calificacionModelo);
                    lblResultado.Text = lblResultado.Text + " : " + calificacionServicio.calcularResultado(calificacionModelo);
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Insertar solo numeros " + ex.Message);
            }
        }
    }
}
