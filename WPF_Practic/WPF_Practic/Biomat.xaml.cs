using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF_Practic
{
    /// <summary>
    /// Логика взаимодействия для Biomat.xaml
    /// </summary>
    public partial class Biomat : Window
    {
        public Biomat()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FormZak formZak = new FormZak();
            formZak.Owner = this;
            formZak.Show();
        }
    }
}
