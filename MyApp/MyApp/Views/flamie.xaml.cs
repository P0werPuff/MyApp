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
    public partial class flamie : ContentPage
    {

        Button btn1, btn2;
        public flamie()
        {
            BackgroundColor = Color.White;
            AbsoluteLayout absoluteLayout = new AbsoluteLayout();
            absoluteLayout.Children.Add(
                new Label { Text = "Egor\nflamie\nVasilyev", FontSize = 30, TextColor = Color.Black },
                new Rectangle(20, 20, 200, 120)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "Егор Васильев (род. 5 апреля 1997) — профессиональный российский киберспортсмен в дисциплине Counter-Strike: Global Offensive, выступающий под псевдонимом «flamie». Наибольшее признание получил, выступая за команду Natus Vincere. ", FontSize = 20, TextColor = Color.Black },
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
                img = new Image { Source = "flamie1.png" },
                new Rectangle(170, 0.1, 200, 200)
            );
            Image img1;
            absoluteLayout.Children.Add(
                img1 = new Image { Source = "flamie2.jpg" },
                new Rectangle(180, 400, 200, 200)
            );

            Content = absoluteLayout;


        }


        private void Btn1_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Награды", "1.Was ranked the 14th best player of 2015 by HLTV.\n" +
                "  2.Was ranked the 12th best player of 2016 by HLTV.\n" +
                "  3.He attended Copenhagen Games 2018 without being a participant in the event.\n", "Понятно");
        }

        private void Btn2_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Карьера", "Свою карьеру Егор начал с Counter-Strike: Source, где выступал за местные московские команды PinCho, TEAM46, t44 и zNation. После перехода на Counter-Strike: Global Offensive в период с 2013 по 2015 год играл в составах USSR Team, dAT Team, HellRaisers." +
                "Успехи молодого игрока на крупном международном турнире ESL One Katowice 2015 были замечены ведущей киберспортивной организацией Natus Vincere, куда Егор был приглашён на испытательный срок 17 марта 2015 года. 10 апреля 2015 года flamie стал полноправным участником команды", "Понятно");
        }


    }
}