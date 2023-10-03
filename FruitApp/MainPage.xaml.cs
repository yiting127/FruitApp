using System.ComponentModel;

namespace FruitApp
{
    public partial class MainPage : ContentPage
    {
        List<Fruit> list = new List<Fruit>()
       {
           new Fruit(){ Name="Apple",Image="apple.png",Description="This is an apple."},
           new Fruit(){ Name="Banana",Image="banana.png",Description="This is an banana."},
           new Fruit(){ Name="Grapes",Image="grape.png",Description="This is an grapes."},
           new Fruit(){ Name="Kiwi",Image="kiwi.png",Description="This is an kiwi."},
           new Fruit(){ Name="Orange",Image="orange.png",Description="This is an orange."},
           new Fruit(){ Name="Pineapple",Image="pineapple.png",Description="This is an pineapple."},
           new Fruit(){ Name="Strawberry",Image="strawberry.png",Description="This is an strawberry."},
           new Fruit(){ Name="Watermelon",Image="watermelon.png",Description="This is an watermelon."}
       };

        public MainPage()
        {
            InitializeComponent();
            FruitListView.ItemsSource = list;
        }

        private void FruitListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            { return; }
            var selectedItem = e.SelectedItem as Fruit;
            Navigation.PushAsync(new FruitDetailed(selectedItem.Name, selectedItem.Image, selectedItem.Description));
        }

        internal class Fruit
        {
            public string Name { get; set; }
            public string Image { get; set; }
            public string Description { get; set; }
        }
    }
}