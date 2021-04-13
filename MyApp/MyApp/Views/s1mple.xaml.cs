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
    public partial class s1mple : ContentPage
    {

        Button btn1, btn2;
        public s1mple()
        {
            BackgroundColor = Color.White;
            AbsoluteLayout absoluteLayout = new AbsoluteLayout();
            absoluteLayout.Children.Add(
                new Label { Text = "Oleksandr s1mple Kostyliev", FontSize = 30, TextColor = Color.Black },
                new Rectangle(20, 20, 200, 120)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "Александр «s1mple» Костылев (родился 2 октября 1997 года) - украинский профессиональный игрок в Counter-Strike: Global Offensive, который в настоящее время играет за Natus Vincere в качестве awp. Он считается одним из лучших игроков в CS: GO в мире. ", FontSize = 20, TextColor = Color.Black },
                new Rectangle(20, 170, 350, 250)
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
                img = new Image { Source = "s1mple2.png" },
                new Rectangle(170, 0.1, 200, 200)
            );
            Image img1;
            absoluteLayout.Children.Add(
                img1 = new Image { Source = "s1mple1.png" },
                new Rectangle(180, 400, 200, 200)
            );

            Content = absoluteLayout;

            
        }


        private void Btn1_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Награды", "1.Was ranked the 4th best player of 2016 by HLTV.\n" +
                "  2.Was ranked the 8th best player of 2017 by HLTV\n" +
                "  3.Was ranked the best player of 2018 by HLTV.\n" +
                "  4.Was ranked the 2nd best player of 2019 by HLTV.\n" +
                "  5.Was ranked the 2nd best player of 2020 by HLTV.\n" +
                "  6.Was ranked the 2nd best player of 2016 by Thorin.\n" +
                "  7.Was ranked the 3rd best player of 2017 by Thorin.\n" +
                "  8.Was ranked the best player of 2018 by Thorin.\n" +
                "  9.Was ranked the 2nd best player of 2019 by Thorin.\n" +
                "  10.Awarded as eSports Player of the Year 2016 by Red Bull.\n" +
                "  11.Awarded as Player of the Year 2018 by Stockholm International Esports Awards.\n" +
                "  12.Awarded as Esports PC Player of the Year 2018 by Esports Awards.\n" +
                "  13.Was ranked the best player of 2018 by betway.\n" +
                "  14.Awarded as Best Player of FPL 2017 by FACEIT.\n", "Понятно");
        }

        private void Btn2_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Карьера", "Карьера Александра «s1mple» Костылева началась в 2013 году. s1mple побывал в таких коллективах как LAN DODGERS, A-Gaming, Courage Gaming. " +
                "1 февраля 2014 года s1mple получил бан от ESL на 2 года за читерство и попытку обхода бана. В результате игрок не смог выступать на официальных турнирах, которые поддерживаются Valve до 2016 года", "Понятно");
        }

       
    }
}