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

namespace JogoDaForca
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

        private void btnOk_Palavra_Click(object sender, RoutedEventArgs e)
        {
            string TxtPalavra = txt_Palavra.Text;
            int TxtTamanho = txt_Palavra.Text.Length;
            string block = "";
            string vazio = " ";
            for (int i = 0; i < TxtTamanho; i++)
            {   
                if (TxtPalavra[i] != vazio[0])
                {
                    block = block + "*";
                }
                else
                {
                    block = block + " ";
                }   
            }
            txtblock_Palavra.Text = block;
        }

        private void txt_Palavra_MouseEnter_1(object sender, MouseEventArgs e)
        {
            txt_Palavra.Clear();
        }

        private void txt_Letra_MouseEnter_1(object sender, MouseEventArgs e)
        {
            txt_Letra.Clear();
        }
    }
}
