namespace PrArrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVector_Click(object sender, EventArgs e)
        {
            //Declaracion de variables

            int[] notas = new int[5];

            //Especificar notas

            notas[0] = 15;
            notas[1] = 13;
            notas[2] = 11;
            notas[3] = 16;
            notas[4] = 18;

            int suma = 0;
            double promedio;

            //Proceso

            cboNotas.Items.Clear();

            // Recorrer nuestro vector
            for (int i = 0; i <= 4; i++)
            {
                //Mostrar las notas en nuestro combobox
                cboNotas.Items.Add(notas[i]);
                suma = suma + notas[i];

            }
            promedio = suma / 5;

            //Salida de la informacion

            txtPromedio.Text = Convert.ToString(promedio);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtPromedio.Clear();
            cboNotas.Items.Clear();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}