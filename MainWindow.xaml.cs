using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace Tema2_CalculadoraBasica
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BotonCalcular_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                int operador1 = Int32.Parse(op1.Text);
                int operador2 = Int32.Parse(op2.Text);

                switch (Operador.Text)
                {
                    case "/":
                        resultado.Text = $"{operador1 / operador2}";
                        break;

                    case "+":
                        resultado.Text = $"{operador1 + operador2}";
                        break;

                    case "-":
                        resultado.Text = $"{operador1 - operador2}";
                        break;

                    case "*":
                        resultado.Text = $"{operador1 * operador2}";
                        break;
                }

            }
            catch (Exception )
            {
                MessageBox.Show("Has introducido un caracter incorrecto", "Error");
            }

        }

            private void Operador_TextChanged(object sender, TextChangedEventArgs e)
            {
                if (Operador.Text == "/" || Operador.Text == "+" || Operador.Text == "-" || Operador.Text == "*")
                {
                    BotonCalcular.IsEnabled = true;
                }
                else
                { BotonCalcular.IsEnabled = false; }
            }

            private void Limpiar_Click(object sender, RoutedEventArgs e)
            {
                op1.Text = "";
                op2.Text = "";
                Operador.Text = "";
                resultado.Text = "";
            }
        }
    }
