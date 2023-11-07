using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EmberekTablazat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Ember> lista = new List<Ember>();
        public MainWindow()
        {
            InitializeComponent();
            lista.Clear();
            lista.Add(new Ember("Gipsz Jakab", 42));
            lista.Add(new Ember("Lakatos Béla", 117));
            lista.Add(new Ember("Kovács Ferenc", 58));

            emberek.ItemsSource = lista;

        }

        private void buttonHozzaad_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxNev.Text) || !int.TryParse(textBoxKor.Text, out int kor) || kor < 0 || kor > 200)
            {
                MessageBox.Show("A név nem lehet üres és a kor 0 és 200 között lehet csak.");
                return;
            }
            lista.Add(new Ember(textBoxNev.Text, int.Parse(textBoxKor.Text)));
            emberek.Items.Refresh();
        }

        private void buttonTorles_Click(object sender, RoutedEventArgs e)
        {
            Ember kijelolt = emberek.SelectedItem as Ember;
            if (kijelolt == null)
            {
                MessageBox.Show("Nem jelöltél ki embert.");
                return;
            }
            MessageBoxResult valasztas = MessageBox.Show($"Biztos, hogy szeretné törölni az alábbi embert: {kijelolt.Nev}?", "Biztos?", MessageBoxButton.YesNo);

            if (valasztas == MessageBoxResult.Yes)
            {
                lista.Remove(kijelolt);
                emberek.Items.Refresh();
            }
        }
    }
}
