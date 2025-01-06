using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;


//using System.Net.Http;
using System.Text;
using System.Text.Json;
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

namespace APIKlient
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

        private async Task Get_Async()
        {
            HttpClient client = new HttpClient();
            Car x = await client.GetFromJsonAsync<Car>("https://localhost:7079/api/Car/GetById");
            //var stringTask = client.GetStringAsync("https://localhost:7079/api/Car/GetById");

            //var msg = stringTask.Result;
            ////Stream s = new MemoryStream(Encoding.UTF8.GetBytes(msg));
            //Car x = JsonSerializer.Deserialize<Car>(msg);
            MessageBox.Show("Make:" + x.Make + ", Model:" + x.Model);

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            HttpClient client = new HttpClient();
            Car car = new Car("Tesla", "3", 4);
            StringContent content = new StringContent(JsonSerializer.Serialize(car), Encoding.UTF8, "application/json");
            //Eller brug den nye JsonContent
            var stringTask = client.PostAsync("http://localhost:5115/api/Car", content);

            HttpResponseMessage result = stringTask.Result;
            if (result.StatusCode == System.Net.HttpStatusCode.Created)
            {
                MessageBox.Show("Oprettet");
            } else
            {
                MessageBox.Show("Fejl:" + result.StatusCode);
            }
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            HttpClient client = new HttpClient();
            var stringTask = client.GetStringAsync("http://www.tronalddump.io/search/quote?tag=Barack");
            var msg = stringTask.Result;
            
            //Get_Async();
        }
    }
}
