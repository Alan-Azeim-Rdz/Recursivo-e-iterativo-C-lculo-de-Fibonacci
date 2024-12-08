using System.Diagnostics;

namespace Recursivo_e_iterativo__Cálculo_de_Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Stopwatch stopwatch = new Stopwatch();

        private void BtnRecurcivo_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32( TextRecurcive.Text);
            LstViewRecurcivo.Items.Clear();
            stopwatch.Start();
            FibonacciRecursivo(number);
            stopwatch.Stop();
            LblTimeRecursivo.Text = stopwatch.ElapsedMilliseconds + "ms";
        }

        private void BtnIterativo_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(TextIterativo.Text);
            stopwatch.Start();
            LsViewIterativo.Items.Clear();
            FibonacciIterativo(number);
            stopwatch.Stop();
            LblTimeIterativo.Text = stopwatch.ElapsedMilliseconds + "ms";
        }

        int FibonacciIterativo(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            int a = 0, b = 1, c = 0;
            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
                LsViewIterativo.Items.Add(Convert.ToString(b));
            }
            return c;
        }

        int FibonacciRecursivo(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            int result = FibonacciRecursivo(n - 1) + FibonacciRecursivo(n - 2);


            bool encontrado = false;
            foreach (ListViewItem item in LstViewRecurcivo.Items)
            {
                if (item.Text == result.ToString())
                {
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                LstViewRecurcivo.Items.Add(result.ToString());
            }

            return result;
        }
    }
}
