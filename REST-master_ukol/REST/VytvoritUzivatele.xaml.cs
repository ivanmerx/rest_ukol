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
    /// Interakční logika pro VytvoritUzivatele.xaml
    /// </summary>
    public partial class VytvoritUzivatele : Page
    {
        Rest Webclient = new Rest();
        ListBox listbox;
        ObservableCollection<Uzivatel> persons;
        public VytvoritUzivatele(ListBox listbox, ObservableCollection<Uzivatel> persons)
        {
            InitializeComponent();
            this.listbox = listbox;
            this.persons = persons;
        }
        public async Task GetUsersAsync()
        {
            persons = await Webclient.GetPersonsListAsync();
            listbox.ItemsSource = persons;
        }

        private void vytvorit_click(object sender, RoutedEventArgs e)
        {
            Uzivatel uzivatel = new Uzivatel();
            uzivatel.jmeno = jmeno.Text;
            uzivatel.prijmeni = prijmeni.Text;
            uzivatel.rod_cislo = Int32.Parse(rod_cislo.Text);
            uzivatel.dat_nar = dat_nar.Text;
            uzivatel.pohlavi = pohlavi.Text;
            Webclient.CreatepersonslistAsync(uzivatel);
            GetUsersAsync();
        }
    }
}
