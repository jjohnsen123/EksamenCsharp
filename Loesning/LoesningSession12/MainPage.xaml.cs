using CommunityToolkit.Maui.Views;
using LoesningSession7.ViewModel;
using System.Collections.ObjectModel;

namespace LoesningSession7
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<Bil> biler = new ObservableCollection<Bil>();
        public MainPage()
        {
            InitializeComponent();
            biler.Add(new Bil("Ford Ka", 50, false));
            biler.Add(new Bil("Model S", 800, true));
            BilListe.ItemsSource = biler;
        }

        private void VisBiler_Clicked(object sender, EventArgs e)
        {
            foreach (var bil in biler)
            {
                DisplayAlert("Bil", "Model:" + bil.Model + ", Hk:" + bil.Hk + "Elbil:" + bil.Elbil, "OK");
            }
        }

        private void Ret_bil_Clicked(object sender, EventArgs e)
        {
            biler[0].Model = "Berlingo";
        }

        private async void ShowEditDialog_Clicked(object sender, EventArgs e)
        {
            EditDialog popup = new EditDialog((Bil)BilListe.SelectedItem);
            await this.ShowPopupAsync(popup);
        }

        private void BilListe_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            EditArea.BindingContext= BilListe.SelectedItem;
        }
    }

}
