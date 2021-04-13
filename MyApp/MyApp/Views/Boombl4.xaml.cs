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
                new Label { Text = "Boombl4 начал свою игровую карьеру в Elements Pro Gaming. После нескольких месяцев игры в EPG Boombl4 и двое его товарищей по команде перешли в Quantum Bellator Fire. Какое-то время команда показывала посредственные результаты, пока не заняла второе место на CIS Minor Championship - Boston 2018. QBF были среди аутсайдеров на этом мероприятии, но, несмотря на все прогнозы, команда попала в топ-8, шокировав всех и обеспечив статус легенды. . В середине 2018 года Кирилл перешел в Winstrike Team, где взял на себя обязанности капитана и играл до перехода в Natus Vincere. ", FontSize = 10, TextColor = Color.Black },
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
                img1 = new Image { Source = "electronic2.jpg" },
                new Rectangle(180, 400, 200, 200)
            );

            Content = absoluteLayout;


        }


        private void Btn1_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Награды", "1.Was ranked the 4th best player of 2018 by HLTV.\n" +
                "  2.Was ranked the 6th best player of 2019 by HLTV.\n" +
                "  3.Was ranked the 5th best player of 2020 by HLTV.\n" +
                "  4.Was ranked the 5th best player of 2018 on Thorin's Top 10 CS:GO Players ranking.\n" +
                "  5.Was named an honorable mention on Thorin's Top 5 CS:GO Players of 2019 ranking.\n" +
                "  6.Was named the MVP of Ice Challenge 2020 by HLTV.\n" +
                "  7.Became a father on February 28, 2019.\n", "Понятно");
        }

        private void Btn2_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Карьера", "Карьера Дениса началась в середине 2015 года, он начал играть в команде ACES вместе с Дмитрием «hooch» Богдановым. Позже он участвовал в таких коллективах как Rebels, Team Empire, NokSuKao. Шарипов часто менял команды, пока организация Flipsid3 Tactics не взяла игрока на испытательный срок." +
                "В новой команде Денис продолжил демонстрировать высокий индивидуальный уровень игры, благодаря чему привлёк к себе внимание Natus Vincere. В составе Рождённых Побеждать electronic заменил Дениса «seized» Костина и проявил себя с первых турниров.", "Понятно");
        }


    }
}