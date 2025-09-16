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
            Products.Add(new Item { Name = Name.Text, Quantity = int.Parse(Quantity.Text) });
        }
    }
}
