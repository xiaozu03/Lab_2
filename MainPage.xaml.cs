namespace Lab_2_layout
{
    public partial class MainPage : ContentPage
    {
      
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnFindYourPetButtonClicked(object? sender, EventArgs e)
        {
            await Navigation.PushAsync(new PetListingsPage());
        }
    }
}
