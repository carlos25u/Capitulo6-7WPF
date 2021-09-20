using System;
using System.Collections;
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
using System.Windows.Shapes;

namespace Capitulo6_7WPF.Capitulo_7
{
    /// <summary>
    /// Interaction logic for Ejercicio1cap7.xaml
    /// </summary>
    public partial class Ejercicio1cap7 : Window
    {
        private List<double> lista = new List<double>();
        public Ejercicio1cap7()
        {
            InitializeComponent();
        }

        private void AgregarButton_Click(object sender, RoutedEventArgs e)
        {
            lista.Add(double.Parse(calificaciontextBox.Text));
            calificaciontextBox.Text = " ";
        }

        private void Calcularbutton_Click(object sender, RoutedEventArgs e)
        {
            double suma = 0.0, promedio = 0.0, minima = 0.0, maxima = 0.0 ;
            
            for(int i = 0; i < lista.Count; i++)
            {
                minima = lista[0];
                suma = suma + lista[i];

                if(lista[i] > maxima)
                {
                    maxima = lista[i];
                    maximaTextBox.Text = maxima.ToString();
                }

                if(lista[i] < minima)
                {
                    minima = lista[i];
                    minimaTextBox.Text = minima.ToString();
                }
            }

            promedio = suma / lista.Count;

            promedioTextBox.Text = promedio.ToString();
        }
    }
}
