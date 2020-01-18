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
        List<Pays> pay1 = new List<Pays>()
        {
            new Pays
            {
                id = 1,
                Name = "maroc",
                vilelist = new List<Ville>
                {
                    new Ville
                    {
                        id = 1,
                        Name = "Nador"
                    },
                    new Ville
                    {
                        id = 2,
                        Name = "Fes"
                    },
                    new Ville
                    {
                        id = 3,
                        Name = "Rabat"
                    },
                    new Ville
                    {
                        id = 4,
                        Name = "Casablanca"
                    }
                }
            }
        };
        public Hotels()
        {
            InitializeComponent();
            ls.ItemsSource = pay1;
        
        }
    }
}