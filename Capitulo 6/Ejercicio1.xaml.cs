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
using System.Windows.Shapes;

namespace Capitulo6_7WPF.Capitulo_6
{
    /// <summary>
    /// Interaction logic for Ejercicio1.xaml
    /// </summary>
    public partial class Ejercicio1 : Window
    {
        private int[] calificaciones = new int[25];
        private int indice = 0;
        public Ejercicio1()
        {
            InitializeComponent(); 
        }
        
        private void agregarButton_Click(object sender, RoutedEventArgs e)
        {
            int cali = Convert.ToInt32(calificacionTextBox.Text);
            indice = indice + 1;

            if(indice <= 25)
            {
                calificaciones[indice] = cali;
                calificacionTextBox.Text = " ";
            }
            else
            {
                MessageBox.Show("No se permite mas calificacion", "Calificaciones llenas", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            
        }

        private void calcularButton_Click(object sender, RoutedEventArgs e)
        {
            int suma = 0;
            float promedio = 0.0f;
            int control = 0;
            int mayor = 0;
            int menor = 0;

            for(int i = 0; i < calificaciones.Length; i++)
            {
                suma += calificaciones[i];
                menor = calificaciones[0];
                control = control + 1;
                promedio = suma / control;
                if(calificaciones[i] > mayor)
                {
                    mayor = calificaciones[i];
                    mayorTextBox.Text = mayor.ToString();
                }

                if(calificaciones[i] < menor)
                {
                    menor = calificaciones[i];
                    menorTextBox.Text = menor.ToString();
                }
            }

            promedioTextBox.Text = promedio.ToString();
        }
    }
}
