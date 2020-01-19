using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App8.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App8
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Hotels : ContentPage
    {
        List<Ville> pay1 = new List<Ville>()
        {
              new Ville
              {
                  idpays = 1,
                  idvile = 1,
                  Namepays = "maroc",
                  Namevile = "Nador",
                  im = ImageSource.FromFile("nador.png")

              },
              new Ville
              {
                  idpays = 1,
                  idvile = 2,
                  Namepays = "maroc",
                  Namevile = "fes",
                  im = ImageSource.FromFile("fes.jpg")
              },

              new Ville
              {
                  idpays = 1,
                  idvile = 3,
                  Namepays = "maroc",
                  Namevile = "Rabat",
                  im = ImageSource.FromFile("")
              },

              new Ville
              {
                  idpays = 1,
                  idvile = 4,
                  Namepays = "maroc",
                  Namevile = "Casablanca",
                  im = ImageSource.FromFile("casa.jpg")
              },

              new Ville
              {
                  idpays = 1,
                  idvile = 5,
                  Namepays = "maroc",
                  Namevile = "Tanger",
                  im = ImageSource.FromFile("")
              },
                new Ville
              {
                  idpays = 1,
                  idvile = 5,
                  Namepays = "maroc",
                  Namevile = "Berkan",
                  im = ImageSource.FromFile("")
              },
        };


        public Hotels()
        {
            InitializeComponent();
            src.TextChanged += (sender, e) =>
            {
                var vil = (from a in pay1
                           where a.Namepays == src.Text.ToLower()
                           select a).ToList();
                ls.ItemsSource = vil;
            };
        }
    }
}