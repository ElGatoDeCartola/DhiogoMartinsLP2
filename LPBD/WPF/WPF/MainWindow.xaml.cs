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

namespace WPF
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnmostrartamanho_Click(object sender, RoutedEventArgs e)
        {
            string s = txtcaixa.Text;
            int tamanho = s.Replace(" ", "").Length;
            string resposta = string.Format("O texto tem {0} caracteres" , tamanho);
            MessageBox.Show(Convert.ToString(txtcaixa.Text.Length));
            MessageBox.Show(String.Format("O Texto tem {0} caracteres.", txtcaixa.Text.Length));
        }

        private void btnApagar_Click(object sender, RoutedEventArgs e)
        {
        }

    }
}
