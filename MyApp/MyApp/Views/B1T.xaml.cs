using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class B1T : ContentPage
    {

        Button btn1, btn2;
        public B1T()
        {
            BackgroundColor = Color.White;
            AbsoluteLayout absoluteLayout = new AbsoluteLayout();
            absoluteLayout.Children.Add(
                new Label { Text = "Valeriy\nB1T\nVakhovskiy", FontSize = 30, TextColor = Color.Black },
                new Rectangle(20, 20, 200, 120)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "Валерий «B1T» Ваховский (родился 5 января 2003 г.) - украинский профессиональный игрок в Counter-Strike: Global Offensive, который в настоящее время играет за Natus Vincere Junior. ", FontSize = 20, TextColor = Color.Black },
                new Rectangle(20, 200, 350, 250)
            );
            absoluteLayout.Children.Add(
                btn1 = new Button { Text = "Награды", FontSize = 20, BackgroundColor = Color.LightSkyBlue },
                new Rectangle(20, 450, 120, 50)
            );
            btn1.Clicked += Btn1_Clicked;
            absoluteLayout.Children.Add(
                btn2 = new Button { Text = "Карьера", FontSize = 20, BackgroundColor = Color.LightSkyBlue },
                new Rectangle(20, 550, 120, 50)
            );
            btn2.Clicked += Btn2_Clicked;
            Image img;
            absoluteLayout.Children.Add(
                img = new Image { Source = "b1t1.png" },
                new Rectangle(170, 0.1, 200, 200)
            );
            Image img1;
            absoluteLayout.Children.Add(
                img1 = new Image { Source = "b1t2.jpg" },
                new Rectangle(180, 400, 200, 200)
            );

            Content = absoluteLayout;


        }


        private void Btn1_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Награды", "1.Was ranked the BLAST Premier: Global Final 2020", "Понятно");
        }

        private void Btn2_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Карьера", "Карьера молодого Валерия началась 2020 году. Молодого игрока подписала организация Natus Vincere.", "Понятно");
        }


    }
}