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
    public partial class Perfecto : ContentPage
    {

        Button btn1, btn2;
        public Perfecto()
        {
            BackgroundColor = Color.White;
            AbsoluteLayout absoluteLayout = new AbsoluteLayout();
            absoluteLayout.Children.Add(
                new Label { Text = "Ilya\nPerfecto\nZalutskiy", FontSize = 30, TextColor = Color.Black },
                new Rectangle(20, 20, 200, 120)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "Денис Шарипов (род. 2 сентября 1998) — профессиональный российский киберспортсмен, также известный как «electronic». Один из лучших игроков мира в дисциплине Counter-Strike: Global Offensive. ", FontSize = 20, TextColor = Color.Black },
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
                img = new Image { Source = "perfecto1.jpg" },
                new Rectangle(170, 0.1, 200, 200)
            );
            Image img1;
            absoluteLayout.Children.Add(
                img1 = new Image { Source = "perfecto2.jpg" },
                new Rectangle(180, 400, 200, 200)
            );

            Content = absoluteLayout;


        }


        private void Btn1_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Награды", "1.Was ranked the 4th best player of 2018 by HLTV.\n" +
                "  2.Was ranked the 6th best player of 2019 by HLTV.\n" +
                "  3.Was ranked the 5th best player of 2020 by HLTV.\n" +
                "  4.Was ranked the 5th best player of 2018 on Thorin's Top 10 CS:GO Players ranking.", "Понятно");
        }

        private void Btn2_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Карьера", "В Counter-Strike: Global Offensive начал играть с 2017 года. Первой профессиональной командой стала российская команда «Atlants». Свой первый матч, который освещался на HLTV (англ.)русск., сыграл 20 мая 2018 года против «Shooting Stars». В том best of 3 матче Илья набрал 1.52 КД. За Atlants Perfecto в общей сложности сыграл 19 матчей, которые освещались на HLTV." +
                "В новой команде Денис продолжил демонстрировать высокий индивидуальный уровень игры, благодаря чему привлёк к себе внимание Natus Vincere. В составе Рождённых Побеждать electronic заменил Дениса «seized» Костина и проявил себя с первых турниров." +
                "В октябре 2018 его заметила команда Syman. Играя за эту команду Илья получил большой игровой опыт: принял участие в семи LAN-турнирах и прошёл на StarLadder Berlin Major 2019. На отборочном СНГ-миноре Илья стал лучшим игроком команды с рейтингом 1.08 Вместе с коллективом он выиграл турнир на 35.000 долларов США NEST Pro Series 2019. Молодого игрока заметил тренер команды Na'Vi Андрей Городенский и пригласил в стан «рожденных побеждать»." +
                "С 24 января 2020 года выступает за одну из лучших команд мира Natus Vincere. Свой первый матч за «рожденных побеждать» сыграл 1 февраля 2020 года против Godsent Тот матч он закончил с рейтингом 1.01." +
                "В октябре 2020 заразился COVID-19, в связи с чем произошел конфликт с командой forZe. Все дело в том, что матч был перенесен без согласия с forZe. Игроки команды начали обвинять команду Na'Vi в злоупотреблении своим влиянием на профессиональной сцене. Игроки украинской организации позже заявили, что все претензии нужно высказывать турнирному организатору.", "Понятно");
        }


    }
}