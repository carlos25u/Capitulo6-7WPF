using Capitulo6_7WPF.Capitulo_6;
using Capitulo6_7WPF.Capitulo_7;
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

namespace Capitulo6_7WPF
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio1 ejer1 = new Ejercicio1();
            ejer1.Show();
        }

        private void ejercicio4_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio4 ejer4 = new Ejercicio4();
            ejer4.Show();
        }

        private void ejercicio5_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio5 ejer5 = new Ejercicio5();
            ejer5.Show();
        }

        private void ejercicio1C7_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio1cap7 ejer1c7 = new Ejercicio1cap7();
            ejer1c7.Show();
        }

        private void ejercicio2c7_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio2 ejer2 = new Ejercicio2();
            ejer2.Show();
        }

        private void Ejercicio5c7_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio5Cap7 ejer5c7 = new Ejercicio5Cap7();
            ejer5c7.Show();
        }
    }
}
