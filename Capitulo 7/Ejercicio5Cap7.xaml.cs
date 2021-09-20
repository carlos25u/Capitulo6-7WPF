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
    /// Interaction logic for Ejercicio5Cap7.xaml
    /// </summary>
    public partial class Ejercicio5Cap7 : Window
    {
        Hashtable tabla = new Hashtable();
        public Ejercicio5Cap7()
        {
            InitializeComponent();
        }

        private void guardarButton_Click(object sender, RoutedEventArgs e)
        {
            tabla.Add(int.Parse(telefonoTextBox.Text), nombretextBox.Text);
            telefonoTextBox.Text = " ";
            nombretextBox.Text = " ";
        }
    }
}
