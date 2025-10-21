# .NET MAUI Pet Adoption App (Lab 2)

This is a simple pet adoption app built with .NET MAUI for a mobile development lab (CSS3344). It demonstrates core .NET MAUI concepts including UI layout, navigation, data binding, and user interaction.

The main goal of this project was to replicate a specific UI design for a pet details page and add basic functionality.

---

## Features

* **Welcome Page:** A simple greeting screen with a button to navigate to the pet listings.
* **Pet Listings Page:** A `CollectionView` in a grid layout showing pets available for adoption.
* **Pet Details Page:** A detailed view of a selected pet, featuring a complex layout built with `Grid` and `Border` controls.
* **Heart Animation:** A "like" button (heart icon) that performs a "pop" animation (`ScaleTo`) when tapped.
* **Adoption Alert:** A `DisplayAlert` congratulatory pop-up message when the "Adoption" button is pressed.

---

## Technology Stack

* **.NET 9**
* **.NET MAUI** (Multi-platform App UI)
* **C#**
* **XAML** (for UI design)
* **Controls:** Uses modern .NET 9 controls like `Border` (replacing the obsolete `Frame`) and `VerticalStackLayout`.

---

## How to Run This Project

1.  **Clone the repository:**
    ```bash
    git clone [https://github.com/YOUR_USERNAME/YOUR_REPOSITORY_NAME.git](https://github.com/YOUR_USERNAME/YOUR_REPOSITORY_NAME.git)
    ```
    *(Remember to replace `YOUR_USERNAME` and `YOUR_REPOSITORY_NAME` with your own!)*

2.  **Open in Visual Studio:**
    * Open the `Lab_2_layout.sln` file in Visual Studio 2022.
    * Wait for Visual Studio to restore all the required NuGet packages.

3.  **Run the App:**
    * Select your desired target from the debug dropdown menu (e.g., Android Emulator, iOS Simulator, or Windows Machine).
    * Press the "Run" (green play) button to build and deploy the application.

---

## Project Screenshot

This application's detail page is based on the following UI design:

*(You can drag and drop your `image_04fc06.png` file here on GitHub to show it!)*
![Pet Details Page UI](image_04fc06.png)
