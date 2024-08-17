namespace Tarea2
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
                if (txtSueldoNeto.Text.Length == 0 || txtIsr.Text.Length == 0 || txtArs.Text.Length == 0 || txtAfp.Text.Length == 0)
                {
                    MessageBox.Show("Debes llenar todos los campos");
                }
                else
                {
                    NominaModel nominaModel = new NominaModel();
                    nominaModel.SueldoNeto = float.Parse(txtSueldoNeto.Text);
                    nominaModel.PocentajeARS = float.Parse(txtArs.Text);
                    nominaModel.PocentajeAFP = float.Parse(txtAfp.Text);
                    nominaModel.PocentajeISR = float.Parse(txtIsr.Text);

                    NominaServicio nominaServicio = new NominaServicio();

                    lblResultadoDescuento.Text = lblResultadoDescuento.Text + " : " + nominaServicio.calcularTotalDescuento(nominaModel).ToString();
                    lblResultadoIsr.Text = lblResultadoIsr.Text + " : " +  nominaServicio.calcularIsr(nominaModel).ToString();
                    lblAfpResultado.Text = lblAfpResultado.Text + " : " + nominaServicio.calcularAfp(nominaModel).ToString();
                    lblResultadoArs.Text = lblResultadoArs.Text + " : " +  nominaServicio.calcularArs(nominaModel).ToString();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Por favor solo introducir numeros " + ex.Message);
            }
        }
    }
}
