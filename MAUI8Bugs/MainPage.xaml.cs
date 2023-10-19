using System.Data;

namespace MAUI8Bugs
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            collectionView.ItemsSource = new List<Animal>() { 
                new Animal() {Name = "Capuchin Monkey"}, 
                new Animal() {Name = "Squirrel Monkey"},
                new Animal() {Name = "Howler Monkey"},
                new Animal() {Name = "Japanese Monkey"},
                new Animal() {Name = "Mandrill"}
            };
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("subpage");
        }
    }

}
