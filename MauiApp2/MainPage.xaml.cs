using System.Collections.ObjectModel;

namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Item> Products { get; set; }
        public MainPage()
        {   
            InitializeComponent();
            Products = new ObservableCollection<Item>();
            BindingContext = this;
        }

        private void Add_Product_Clicked(object sender, EventArgs e)
        {
            int QuantityParsed;
            
            if (int.TryParse(Quantity.Text, out QuantityParsed))
            {
                Products.Add(new Item { Name = Name.Text, Quantity = QuantityParsed});
            }
            else
            {
                DisplayAlert("Błąd", "Podaj poprawną ilość", "OK");
            }
        }

        private void Delete_Product_Clicked(object sender, EventArgs e)
        {
            var selectedItem = Products_Collection_View.SelectedItem as Item;
            if (selectedItem !=  null)
            {
                Products.Remove(selectedItem);
            }
            else
            {
                DisplayAlert("Info", "Nie wybrano żadnego elementu", "OK");
            }
        }
    }
}
