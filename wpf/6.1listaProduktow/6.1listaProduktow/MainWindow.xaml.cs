using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace _6._1listaProduktow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    class Produkt
    {
        public string Symbol { get; set; }
        public string Nazwa { get; set; }
        public int LiczbaSztuk { get; set; }
        public string Magazyn { get; set; }
        public Produkt(string sym, string naz, int lszt, string mag)
        {
            Symbol = sym;
            Nazwa = naz;
            LiczbaSztuk = lszt;
            Magazyn = mag;
        }
        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3}", Symbol, Nazwa, LiczbaSztuk,
               Magazyn);
        }
    }

    public partial class MainWindow : Window
    {
        private ObservableCollection<Produkt> ListaProduktow = null;
        public MainWindow()
        {
            InitializeComponent();
            PrzygotujWiazanie();

        }
        private void PrzygotujWiazanie()
        {
            ListaProduktow = new ObservableCollection<Produkt>();
            ListaProduktow.Add(new Produkt("O1-11", "ołówek", 8, "Katowice 1"));
            ListaProduktow.Add(new Produkt("PW-20", "pióro wieczne", 75, "Katowice 2"));
            ListaProduktow.Add(new Produkt("DZ-10", "długopis żelowy", 1121,"Katowice 1"));
            ListaProduktow.Add(new Produkt("DZ-12", "długopis kulkowy", 280,"Katowice 2"));
            lstProdukty.ItemsSource = ListaProduktow;
            CollectionView widok =(CollectionView)CollectionViewSource.GetDefaultView(lstProdukty.ItemsSource);
            widok.SortDescriptions.Add(new SortDescription("Magazyn",ListSortDirection.Ascending));
            widok.Filter = FiltrUzytkownika;
        }
        private bool FiltrUzytkownika(object item)
        {
            if (String.IsNullOrEmpty(txtFilter.Text))
                return true;
            else
                return ((item as Produkt).Nazwa.IndexOf(txtFilter.Text,
                   StringComparison.OrdinalIgnoreCase) >= 0);
        }
        private void txtFilter_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(lstProdukty.ItemsSource).Refresh();
        }
        
    }
}
