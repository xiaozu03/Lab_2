using Lab_2_layout.Models;

namespace Lab_2_layout;

public partial class PetDetailsPage : ContentPage
{
    private bool isHeartFilled = false;

    public PetDetailsPage(Pet pet)
    {
        InitializeComponent(); // This error will be fixed now
        BindingContext = pet;
    }

    private async void OnHeartTapped(object sender, TappedEventArgs e)
    {
        // These errors will be fixed
        await HeartFrame.ScaleTo(1.2, 100, Easing.Linear);
        await HeartFrame.ScaleTo(1.0, 100, Easing.Linear);

        isHeartFilled = !isHeartFilled;

        // This fixes the "Use pattern matching" warning
        if (HeartImage is Image heartImage)
        {
            if (isHeartFilled)
            {
                // We change the Source, not TintColor
                heartImage.Source = "heart_icon.png";
                await DisplayAlert("Like", "You liked this pet!", "OK");
            }
            else
            {
                // Change the Source back
                heartImage.Source = "heart_icon.png";
                await DisplayAlert("Unlike", "You unliked this pet.", "OK");
            }
        }
    }

    private async void OnAdoptionButtonClicked(object sender, EventArgs e)
    {
        var currentPet = BindingContext as Pet;

        if (currentPet != null)
        {
            await DisplayAlert(
                "Congratulations!",
                $"You've successfully started the adoption process for {currentPet.Name}!",
                "Yay!");
        }
        else
        {
            await DisplayAlert("Error", "Could not retrieve pet details.", "OK");
        }
    }
}