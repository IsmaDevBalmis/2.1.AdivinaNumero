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

namespace _2._1.AdivinaNumero
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int numeroGenerado;
        public MainWindow()
        {
            InitializeComponent();
            numeroGenerado = GenerarNumeroAleatorio();
        }

       

        private int GenerarNumeroAleatorio()
        {
            Random r = new Random();
            int randomNumber = r.Next(0, 101);
            return randomNumber;
        }



        private void ComprobarButton_Click(object sender, RoutedEventArgs e)
        {
            int numeroIntroducido = int.Parse(numeroTextBox.Text);

            if (numeroIntroducido == numeroGenerado)
            {
                respuestaTextBlock.Text = "Has acertado!";
            }
            else
            {
                if (numeroIntroducido > numeroGenerado)
                {
                    respuestaTextBlock.Text = "Te has pasado";
                }
                else
                {
                    respuestaTextBlock.Text = "Te has quedado corto";
                }
            }
        }

        private void ReiniciarButton_Click(object sender, RoutedEventArgs e)
        {
            GenerarNumeroAleatorio();
            MessageBox.Show("Se ha reiniciado");
            respuestaTextBlock.Text = "";
            numeroTextBox.Text = "";
        }
    }
}
