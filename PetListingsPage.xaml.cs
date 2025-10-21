using Lab_2_layout.Models; // Make sure this 'using' is at the top!
using System.Collections.ObjectModel; // Make sure this is here too!

namespace Lab_2_layout
{
    public partial class PetListingsPage : ContentPage
    {
        public ObservableCollection<Pet> Pets { get; set; }

        public PetListingsPage()
        {
            InitializeComponent();
            LoadPets();
            BindingContext = this;
        }

        private void LoadPets()
        {
            Pets = new ObservableCollection<Pet>
            {
                new Pet { Id = 1, Name = "Stephen", Breed = "LaBuBu", Age = 1, Gender = "Male", Location = "3B,Lorong 88, Taman Rantau Panjang, 96000 Sibu, Sarawak", OwnerName = "Choo Jungkook", OwnerDate = "1.11.2024", Description = "Hi! Stephen is simply a tiny tornado of fur, wrinkles, and endless charm!", ImageUrl = "stephen.jpg" },
                new Pet { Id = 2, Name = "Alvin", Breed = "Kuromi", Age = 2, Gender = "Female", Location = "No.1, Jalan University, 96000, Sibu, Sarawak", OwnerName = "Choo TaeHyung", OwnerDate = "1.10.2024", Description = "Alvin is a friendly and energetic doggie looking for a family to love.", ImageUrl = "alvin.jpeg" }
            };
        }

        // --- THIS IS THE METHOD TO FIX ---
        private async void OnPetSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection != null && e.CurrentSelection.Any())
            {
                // 1. Get the selected item AND cast it to a 'Pet'
                var selectedPet = e.CurrentSelection.FirstOrDefault() as Pet;

                // 2. Check if the cast was successful (it's not null)
                if (selectedPet != null)
                {
                    // 3. This is Line 35. You MUST pass the 'selectedPet' variable.
                    await Navigation.PushAsync(new PetDetailsPage(selectedPet));

                    // Deselect item so it can be tapped again
                    ((CollectionView)sender).SelectedItem = null;
                }
            }
        }
    }
}