namespace Lab_2_layout.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; } // "Male" or "Female"
        public string Location { get; set; }
        public string OwnerName { get; set; }
        public string OwnerDate { get; set; } // Date format can be adjusted
        public string Description { get; set; }
        public string ImageUrl { get; set; } // Path to the pet's image
        public string OwnerImageUrl { get; set; } = "jungkook.jpeg"; // Path to owner's image, set default for now
    }
}
