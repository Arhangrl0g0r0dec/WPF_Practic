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
    /// Логика взаимодействия для Private_Cabinet.xaml
    /// </summary>
    public partial class Private_Cabinet : Window
    {
        public Private_Cabinet()
        {
            InitializeComponent();
        }

        private void Bio_Click(object sender, RoutedEventArgs e)
        {
            Biomat biomat = new Biomat();
            biomat.Owner = this;
            biomat.Show();
        }

        private void DoOtchet_Click(object sender, RoutedEventArgs e)
        {
            Otchet otchet = new Otchet();
            otchet.Owner = this;
            otchet.Show();
        }
    }
}
