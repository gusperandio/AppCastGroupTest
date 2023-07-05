using AppCastGroupTest.Service;
using AppCastGroupTest.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCastGroupTest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        private Random random = new Random();
        public HomePage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            // Chame sua função de consulta à API aqui
            await LoadDataFromApi();
        }

        private async Task LoadDataFromApi()
        {
            dogListView.IsVisible = false;
            progressBar.IsVisible = true;
    
            List<Dogs> dogList = new List<Dogs>();
            for (int i = 0; i < 10; i++)
            {
                Dogs dogs = await ApiDogService.GetDogs();
                progressBar.Progress += 0.1;
                dogs.Name = GetRandomDogName();
                dogs.Age = $"Idade: {random.Next(1, 16)}";

                dogList.Add(dogs);
            }

            dogListView.ItemsSource = dogList;
            progressBar.IsVisible = false;
            dogListView.IsVisible = true;
            progressBar.Progress = 0;
        }

        private async void Reload(object sender, EventArgs e)
        {
            await LoadDataFromApi();
        }


        public string GetRandomDogName()
        {
            List<string> listaDogs = new List<string>();
            string[] allDogNames = { "Rocky", "Bella", "Maximus", "Daisy", "Zeus", "Lola", "Buddy", "Luna", "Charlie", "Stella", "Cooper", "Roxy", "Oliver", "Lucy", "Teddy", "Sadie", "Milo", "Sophie", "Tucker", "Ruby" };

            List<string> avaliar = allDogNames.Except(listaDogs).ToList();

            if (avaliar.Count == 0)
            {
                listaDogs.Clear();
                avaliar = allDogNames.ToList();
            }

            int randomIndex = random.Next(avaliar.Count);
            string randomName = avaliar[randomIndex];

            listaDogs.Add(randomName);

            return randomName;
        }
    }
}