namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private const double PrecioPorPar = 5.0;
        private const double TasaImpuestos = 0.05;
        private const double CargosEnvio = 1.5;
        private const int LimiteEnvioGratis = 20;
        private const double DescuentoPorPedidoMayor500 = 0.07;
        public Form1()
        {
            InitializeComponent();

            textBox1.KeyPress += new KeyPressEventHandler(textBox1_KeyPress);
            textBox6.KeyPress += new KeyPressEventHandler(textBox6_KeyPress);
            textBox7.KeyPress += new KeyPressEventHandler(textBox7_KeyPress);
            textBox8.KeyPress += new KeyPressEventHandler(textBox8_KeyPress);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (double.TryParse(textBox6.Text, out double cantidadDados))
                {
                    double resultado = cantidadDados * 6.25;
                    richTextBox1.Text = $"{resultado}";
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (double.TryParse(textBox6.Text, out double cantidadDados))
                {
                    double resultado = cantidadDados * 6.25;
                    richTextBox1.Text = $"{resultado}";
                }
            }
            else
            {
                richTextBox1.Text = string.Empty;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) ||
                (string.IsNullOrEmpty(textBox6.Text) && string.IsNullOrEmpty(textBox7.Text) && string.IsNullOrEmpty(textBox8.Text)))
            {
                MessageBox.Show("Por favor, complete al menos un detalle del cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double resultadoRichTextBox1, resultadoRichTextBox2, resultadoRichTextBox3;

            if (double.TryParse(richTextBox1.Text.Replace("$", ""), out resultadoRichTextBox1) &&
                double.TryParse(richTextBox2.Text.Replace("$", ""), out resultadoRichTextBox2) &&
                double.TryParse(richTextBox3.Text.Replace("$", ""), out resultadoRichTextBox3))
            {
                double totalResultados = resultadoRichTextBox1 + resultadoRichTextBox2 + resultadoRichTextBox3;

                double impuestos = totalResultados * TasaImpuestos;

                double descuento = 0.0;
                if (totalResultados > 500)
                {
                    descuento = totalResultados * DescuentoPorPedidoMayor500;
                }

                double totalConEnvio = totalResultados;
                int cantidadTotalDados = int.Parse(textBox6.Text) + int.Parse(textBox7.Text) + int.Parse(textBox8.Text);

                if (cantidadTotalDados > LimiteEnvioGratis)
                {
                    totalConEnvio += CargosEnvio;
                }

                double totalFinal = totalResultados + impuestos - descuento + (totalConEnvio - totalResultados);

                richTextBox4.Text = $"{totalFinal:C2}";

                double impuestos5Porciento = totalFinal * TasaImpuestos;
                richTextBox5.Text = $"{impuestos5Porciento:C2}";

                double costoEnvio = cantidadTotalDados > LimiteEnvioGratis ? 0.0 : CargosEnvio;
                richTextBox6.Text = $"{costoEnvio:C2}";

                richTextBox7.Text = $"{descuento:C2}";

                double totalConDescuento = totalFinal - descuento;
                richTextBox8.Text = $"{totalConDescuento:C2}";
            }
            else
            {
                MessageBox.Show("Hubo un problema al obtener los resultados de las cajas de texto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

            private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (double.TryParse(textBox6.Text, out double cantidadDados))
                {
                    double resultado = cantidadDados * 5.00;
                    richTextBox1.Text = $"{resultado}";
                }
            }
            else
            {
                richTextBox1.Text = string.Empty; 
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                if (double.TryParse(textBox7.Text, out double cantidadDados))
                {
                    double resultado = cantidadDados * 5.00;
                    richTextBox2.Text = $"{resultado}";
                }
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                if (double.TryParse(textBox8.Text, out double cantidadDados))
                {
                    double resultado = cantidadDados * 7.50;
                    richTextBox3.Text = $"{resultado}";
                }
            }
            else
            {
                richTextBox1.Text = string.Empty;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                if (double.TryParse(textBox8.Text, out double cantidadDados))
                {
                    double resultado = cantidadDados * 7.50;
                    richTextBox3.Text = $"{resultado}";
                }
            }
        }
    }
}
