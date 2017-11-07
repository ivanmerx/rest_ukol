using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using REST.Entity;
using REST.Interfaces;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace REST.WebClient
{
    class Rest
    {
        public async Task<ObservableCollection<Uzivatel>> GetPersonsListAsync()
        {
            string url = "https://student.sps-prosek.cz/~merxbiv14/prog/";
            var client = new RestClient(url);
            var request = new RestRequest("prog.php?selectall", Method.GET);
            request.AddHeader("header", "value");

            ObservableCollection<Uzivatel> persons = new ObservableCollection<Uzivatel>();

            IRestResponse response = client.Execute(request);
            persons = JsonConvert.DeserializeObject<ObservableCollection<Uzivatel>>((response.Content));
            return persons;

        }

        public async Task<ObservableCollection<Uzivatel>> GetpersonsListByIdAsync(int id)
        {
            string url = "https://student.sps-prosek.cz/~merxbiv14/prog/";
            var client = new RestClient(url);
            var request = new RestRequest("prog.php?id="+id, Method.GET);
            request.AddHeader("header", "value");

            ObservableCollection<Uzivatel> persons = new ObservableCollection<Uzivatel>();

            IRestResponse response = client.Execute(request);
            persons = JsonConvert.DeserializeObject<ObservableCollection<Uzivatel>>((response.Content));
            return persons;

        }
        public async Task<ObservableCollection<Uzivatel>> UpdatepersonsListByIdAsync(Uzivatel uzivatel)
        {
            string url = "https://student.sps-prosek.cz/~merxbiv14/prog/";
            var client = new RestClient(url);
            var request = new RestRequest("prog.php", Method.POST);
            request.AddHeader("Content-type", "application/json");
            request.AddParameter("update", JsonConvert.SerializeObject(uzivatel));
             
            ObservableCollection<Uzivatel> persons = new ObservableCollection<Uzivatel>();

            IRestResponse response = client.Execute(request);
            persons = JsonConvert.DeserializeObject<ObservableCollection<Uzivatel>>((response.Content));
            return persons;

        }
        public async Task<ObservableCollection<Uzivatel>> DeletepersonslistAsync(int id)
        {
            string url = "https://student.sps-prosek.cz/~merxbiv14/prog/";
            var client = new RestClient(url);
            var request = new RestRequest("prog.php?delete="+id, Method.GET);
            ObservableCollection<Uzivatel> persons = new ObservableCollection<Uzivatel>();

            IRestResponse response = client.Execute(request);
            persons = JsonConvert.DeserializeObject<ObservableCollection<Uzivatel>>((response.Content));
            return persons;

        }
        public async Task<ObservableCollection<Uzivatel>> CreatepersonslistAsync(Uzivatel uzivatel)
        {
            string url = "https://student.sps-prosek.cz/~merxbiv14/prog/";
            var client = new RestClient(url);
            var request = new RestRequest("prog.php", Method.POST);
            request.AddHeader("Content-type", "application/json");
            request.AddParameter("add", JsonConvert.SerializeObject(uzivatel));

            ObservableCollection<Uzivatel> persons = new ObservableCollection<Uzivatel>();

            IRestResponse response = client.Execute(request);
            persons = JsonConvert.DeserializeObject<ObservableCollection<Uzivatel>>((response.Content));
            return persons;

        }
    }
}
