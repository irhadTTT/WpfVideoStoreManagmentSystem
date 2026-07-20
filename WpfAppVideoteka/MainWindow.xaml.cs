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

namespace WpfAppVideoteka
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

        private void buttonClanovi_Click(object sender, RoutedEventArgs e)
        {
            WindowClan wc = new WindowClan();
            wc.ShowDialog();
        }

        private void buttonFilmovi_Click(object sender, RoutedEventArgs e)
        {
            WindowFilm wf = new WindowFilm();
            wf.ShowDialog();
        }

        private void buttonIz_Click(object sender, RoutedEventArgs e)
        {
            WindowsIznajmljivanje wi = new WindowsIznajmljivanje();
            wi.ShowDialog();
        }
    }
}
