namespace TP_Aula02
{
    public partial class calcIMC : Form
    {
        public calcIMC()
        {
            InitializeComponent();
        }

        private void txtboxPeso_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxAltura_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double inputPeso, inputAltura;

            inputPeso = Double.Parse(txtboxPeso.Text);
            inputAltura = Double.Parse(txtboxAltura.Text);

            var (descricaoIMC, resIMC) = CalculoIMC(inputPeso, inputAltura / 100);
            lblResult.Text = $"RESULTADO:\n{descricaoIMC}\nSeu IMC é de {resIMC:F1}";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtboxAltura.Text = String.Empty;
            txtboxPeso.Text = String.Empty;
        }

        private (string, double) CalculoIMC(double peso, double altura)
        {
            double imc =  peso / (altura * altura);

            var resultado = imc switch
            {
                < 20 => "Abaixo do peso",
                >= 20 and < 25 => "Peso ideal",
                >= 25 and < 30 => "Sobrepeso",
                >= 30 and < 40 => "Obesidade grau II",
                > 40 => "Obesidade grau III"
            };

            return (resultado, imc);
        }


    }
}