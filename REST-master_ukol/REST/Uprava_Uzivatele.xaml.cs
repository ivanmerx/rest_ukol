using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
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
using REST.Entity;
using REST.WebClient;
using Newtonsoft.Json;
using System.Windows.Threading;
namespace REST
{
    /// <summary>
    /// Interakční logika pro Uprava_Uzivatele.xaml
    /// </summary>
    public partial class Uprava_Uzivatele : Page
    {
        Rest Webclient = new Rest();
        Uzivatel uzivatel;
        ListBox listbox;
        ObservableCollection<Uzivatel> persons;
        public Uprava_Uzivatele(Uzivatel uzivatel,ListBox listbox,ObservableCollection<Uzivatel> persons)
        {
            InitializeComponent();
            id.Content = uzivatel.id;
            jmeno.Text = uzivatel.jmeno;
            prijmeni.Text = uzivatel.prijmeni;
            rod_cislo.Text = uzivatel.rod_cislo.ToString();
            dat_nar.Text = uzivatel.dat_nar;
            pohlavi.Text = uzivatel.pohlavi;
            this.uzivatel = uzivatel;
            this.listbox = listbox;
            this.persons = persons;
        }

        public async Task GetUsersAsync()
        {
            persons = await Webclient.GetPersonsListAsync();
            listbox.ItemsSource = persons;
        }

        private void ulozit_Click(object sender, RoutedEventArgs e)
        {
            uzivatel.jmeno = jmeno.Text;
            uzivatel.prijmeni = prijmeni.Text;
            uzivatel.rod_cislo = Int32.Parse(rod_cislo.Text.ToString());
            uzivatel.dat_nar = dat_nar.Text;
            uzivatel.pohlavi = pohlavi.Text;
            Webclient.UpdatepersonsListByIdAsync(uzivatel);
            GetUsersAsync();
        }

        private void smazat_Click(object sender, RoutedEventArgs e)
        {
            Webclient.DeletepersonslistAsync(uzivatel.id);
            GetUsersAsync();
        }
    }
}
