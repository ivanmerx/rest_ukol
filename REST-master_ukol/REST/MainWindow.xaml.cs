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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Rest webClient = new Rest();

        ObservableCollection<Uzivatel> persons = new ObservableCollection<Uzivatel>();
        public MainWindow()
        {
            InitializeComponent();
        }

        public async Task GetUsersAsync()
        {
            persons = await webClient.GetPersonsListAsync();
            ListBox.ItemsSource = persons;
        }

        public async Task GetUsersAsyncByID()
        {
            persons = await webClient.GetpersonsListByIdAsync(Int32.Parse(selectid.Text));
            ListBox.ItemsSource = persons;
        }
        private async void GetPersonListAndPopulateAsync()
        {
            //App.Database.ResetTable();
            //Console.WriteLine("Is current thread in background: " + Thread.CurrentThread.IsBackground);
            //FOR TEST
            //List<Photo> data = await webClient.GetPersonsListAsync(this);
            //if (data != null && data.Count != 0)
            //{
            //    if (!String.IsNullOrEmpty(selectid.Text))
            //    {
            //        ObservableCollection<Photo> pl = new ObservableCollection<Photo>(data);
            //        await App.Database.SaveItemsAsync(data);
            //        ListBox.ItemsSource = App.Database.GetItemsNotDoneAsync2(Int32.Parse(selectid.Text)).Result;
            //    }
            //    else
            //    {
            //        ObservableCollection<Photo> pl = new ObservableCollection<Photo>(data);
            //        await App.Database.SaveItemsAsync(data);
            //        ListBox.ItemsSource = App.Database.GetItemsNotDoneAsync().Result;
            //    }
            //}

        }
        private async void GetData_Click2(object sender, RoutedEventArgs e)
        {
            await GetUsersAsync();
        }

        private void GetData_Click3(object sender, RoutedEventArgs e)
        {
            GetUsersAsyncByID();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Uzivatel uzivatel = ListBox.SelectedItem as Uzivatel;
            frame.Navigate(new Uprava_Uzivatele(uzivatel,ListBox,persons));
            frame.NavigationUIVisibility = System.Windows.Navigation.NavigationUIVisibility.Hidden;
        }

        private void GetData_Click4(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new VytvoritUzivatele(ListBox, persons));
            frame.NavigationUIVisibility = System.Windows.Navigation.NavigationUIVisibility.Hidden;
        }
    }
}
