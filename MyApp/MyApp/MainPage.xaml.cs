using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MyApp
{
    public partial class MainPage : MasterDetailPage 
    {
        Button btn1, btn2, btn3, btn4, btn5, btn6;

        public MainPage()
        {
            InitializeComponent();
            profileImage.Source = ImageSource.FromFile("navi.png"); //
            aboutList.ItemsSource = GetMenuList();
            var homePage = typeof(Views.homepages);
            Detail = new NavigationPage((Page)Activator.CreateInstance(homePage));
            IsPresented = false;

            btn1 = new Button();
            btn1.Text = "Тест по игре";
            btn1.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button));
            btn1.BackgroundColor = Color.Gray;
            btn1.TextColor = Color.Orange;
            btn1.WidthRequest = 160;
            btn1.HeightRequest = 60;
            btn1.Margin = 5;
            btn1.Clicked += Btn1_Clicked;

        }

        public List<MasterMenuItems> GetMenuList()
        {
            var list = new List<MasterMenuItems>();
            list.Add(new MasterMenuItems()
            {
                Text = "Homepage",
                Detail = "Natus Vincere",
                ImagePath = "navi.png",
                TargetPage = typeof(Views.homepages)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Aleksandr Kostyliev",
                Detail = "s1mple",
                ImagePath = "s1mple.png",
                TargetPage = typeof(Views.s1mple)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Egor Vasilyev", 
                Detail = "flamie",
                ImagePath = "flamie.png",
                TargetPage = typeof(Views.flamie)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Kirill Mikhailov",
                Detail = "Boombl4",
                ImagePath = "Boombl4.png",
                TargetPage = typeof(Views.Boombl4)
            });
            list.Add(new MasterMenuItems()
            {
                Text = " Denis Sharipov",
                Detail = "electronic",
                ImagePath = "electronic.png",
                TargetPage = typeof(Views.electronic)
            });
            list.Add(new MasterMenuItems()
            {
                Text = " Ilya Zalutskiy",
                Detail = "Perfecto",
                ImagePath = "Perfecto.png",
                TargetPage = typeof(Views.Perfecto)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Valeriy Vakhovskiy",
                Detail = "B1T",
                ImagePath = "B1T.png",
                TargetPage = typeof(Views.B1T)
            });
            return list;
        }

        private void aboutList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedMenuItem = (MasterMenuItems)e.SelectedItem;
            Type selectedPage = selectedMenuItem.TargetPage;
            Detail = new NavigationPage((Page)Activator.CreateInstance(selectedPage));
            IsPresented = false;
        }

        private void Btn1_Clicked(object sender, EventArgs e)
        {
            Uri halflife = new Uri("https://vgtimes.ru/tests/36-test-naskolko-horosho-ty-znaesh-mir-half-life.html");
            Browser.OpenAsync(halflife);
        }

    }
}
