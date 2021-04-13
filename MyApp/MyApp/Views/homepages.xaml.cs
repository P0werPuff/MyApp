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
    public partial class homepages : ContentPage
    {
        Button btn1, btn2;
        public homepages()
        {
            BackgroundColor = Color.White;
            AbsoluteLayout absoluteLayout = new AbsoluteLayout();
            absoluteLayout.Children.Add(
                new Label { Text = "Natus Vincere", FontSize = 30, TextColor = Color.Black },
                new Rectangle(20, 20, 100, 120)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "«Natus Vincere (лат.« Рожденный побеждать », часто сокращенно NAVI, ранее Na`Vi) - украинская профессиональная киберспортивная организация.", FontSize = 20, TextColor = Color.Black },
                new Rectangle(20, 170, 350, 250)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "Логотип", FontSize = 30, TextColor = Color.Black },
                new Rectangle(220, 400, 120, 60)
            );
            absoluteLayout.Children.Add(
                btn1 = new Button { Text = "Больше", FontSize = 20, BackgroundColor = Color.LightSkyBlue },
                new Rectangle(20, 350, 120, 50)
            );
            btn1.Clicked += Btn1_Clicked;
            absoluteLayout.Children.Add(
                btn2 = new Button { Text = "История", FontSize = 20, BackgroundColor = Color.LightSkyBlue },
                new Rectangle(20, 450, 120, 50)
            );
            btn2.Clicked += Btn2_Clicked;
            Image img;
            absoluteLayout.Children.Add(
                img = new Image { Source = "navi.png" },
                new Rectangle(180, 300, 200, 200)
            );
            Image img1;
            absoluteLayout.Children.Add(
                img1 = new Image { Source = "navi2.jpg" },
                new Rectangle(170, 0.1, 200, 200)
            );
            Content = absoluteLayout;
        }

        private void Btn1_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Больше", "В первый состав NAVI вошли Edward, markeloff, starix, ceh9 и Zeus, а менеджером стал ZeroGravity." +
                " Все игроки выделялись высоким индивидуальным мастерством и имели большой опыт турнирных выступлений.", "Понятно");
        }

        private void Btn2_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("История", "17 декабря 2009 года вокруг команды по Counter-Strike была построена организация Natus Vincere (с лат. — рождённые побеждать). " +
                "Примечательно, что изначально аббревиатура NAVI была позаимствована из фильма «Аватар», а свой окончательный вид приобрела после конкурса на лучшую расшифровку, позже проведённого среди фанатов." , "Понятно");
        }
    }
}