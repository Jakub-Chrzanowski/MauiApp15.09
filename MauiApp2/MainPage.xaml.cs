using System.Collections.ObjectModel;

namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<Item> Products { get; set; }
        public MainPage()
        {   
            InitializeComponent();
            Products = new ObservableCollection<Item>();
            BindingContext = this;
        }

        
    }
}
