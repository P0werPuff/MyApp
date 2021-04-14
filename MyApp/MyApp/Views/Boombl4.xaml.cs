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
    public partial class Boombl4 : ContentPage
    {

        Button btn1, btn2;
        public Boombl4()
        {
            BackgroundColor = Color.White;
            AbsoluteLayout absoluteLayout = new AbsoluteLayout();
            absoluteLayout.Children.Add(
                new Label { Text = "Kirill\nBoombl4\nMikhailov", FontSize = 30, TextColor = Color.Black },
                new Rectangle(20, 20, 200, 120)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "Boombl4 начал свою игровую карьеру в Elements Pro Gaming. После нескольких месяцев игры в EPG Boombl4 и двое его товарищей по команде перешли в Quantum Bellator Fire. Какое-то время команда показывала посредственные результаты, пока не заняла второе место на CIS Minor Championship - Boston 2018. QBF были среди аутсайдеров на этом мероприятии, но, несмотря на все прогнозы, команда попала в топ-8, шокировав всех и обеспечив статус легенды. . В середине 2018 года Кирилл перешел в Winstrike Team, где взял на себя обязанности капитана и играл до перехода в Natus Vincere. ", FontSize = 15, TextColor = Color.Black },
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
                img = new Image { Source = "Boombl41.jpg" },
                new Rectangle(170, 0.1, 200, 200)
            );
            Image img1;
            absoluteLayout.Children.Add(
                img1 = new Image { Source = "Boombl42.jpg" },
                new Rectangle(180, 400, 200, 200)
            );

            Content = absoluteLayout;


        }


        private void Btn1_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Награды", "1.Was ranked the 4th best player of 2018 by HLTV.\n" +
                "  2.Was ranked the 6th best player of 2019 by HLTV.", "Понятно");
        }

        private void Btn2_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Карьера", "Карьера Кирилла Михайлова началась в команде Elements Pro Gaming, но спустя несколько месяцев он переходит в команду Quantum Bellator Fire. Долгое время успехов у команды не было, но в 2018 году она занимает 2 место в СНГ Миноре к ELEAGUE Major: Boston 2018. Прогнозы на команду Quantum Bellator Fire были неутешительны, но, тем не менее, команда заняла 5-8 место и обрела статус «Легенды»." +
                "21 октября 2018 года стало известно, что Winstrike переводит всех игроков команды в запас, кроме Кирилла.Это было вызвано неудачным выступлением на FACEIT Major: London 2018, там команда проиграла три карты из трёх и выбыла[4].Он стал капитаном и новая команда была построена вокруг него.В этой команде Кирилл играл вплоть до перехода в Natus Vincere.", "Понятно");

        }
    }
}