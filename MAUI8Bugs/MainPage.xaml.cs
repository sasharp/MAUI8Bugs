
namespace MAUI8Bugs
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var list = new List<Animal>() { 
                new Animal() {Name = "Capuchin Monkey"}, 
                new Animal() {Name = "Squirrel Monkey"},
                new Animal() {Name = "Howler Monkey"},
                new Animal() {Name = "Japanese Monkey"},
                new Animal() {Name = "Mandrill"},
                new Animal() {Name = "Capuchin Monkey"},
                new Animal() {Name = "Squirrel Monkey"},
                new Animal() {Name = "Howler Monkey"},
                new Animal() {Name = "Japanese Monkey"},
                new Animal() {Name = "Mandrill"}
            };
            for (int i = 0; i < 250; i++)
            {
                list.Add(new Animal()
                {
                    Name = "Mandrill"
                });
            }
            collectionView.ItemsSource = list;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("subpage");
        }

        private async void collectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            await Shell.Current.GoToAsync("subpage");
        }
    }

}
