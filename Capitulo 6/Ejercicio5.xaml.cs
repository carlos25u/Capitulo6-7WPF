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
    /// Interaction logic for Ejercicio5.xaml
    /// </summary>
    public partial class Ejercicio5 : Window
    {
        private int[] numeros = new int[10];
        private int indice = 0;
        public Ejercicio5()
        {
            InitializeComponent();
        }

        private void agregarButton_Click(object sender, RoutedEventArgs e)
        {
            indice += 1;
            numeros[indice] = Convert.ToInt32(numeroTextBox.Text);
            numeroTextBox.Text = " ";
        }

        private void imprimirTextBox_Click(object sender, RoutedEventArgs e)
        {
            imprimirArreglo(numeros);
        }

        private void imprimirArreglo(int[] num)
        {
            for(int i = 0; i < numeros.Length; i++)
            {
                arregloListBox.Items.Add(numeros[i]);
            }
        }
    }
}
