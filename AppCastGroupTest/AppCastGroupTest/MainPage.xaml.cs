using System.Threading.Tasks;
using System;
using Xamarin.Forms;
using Xamarin.CommunityToolkit.Converters;

namespace AppCastGroupTest
{
    public partial class MainPage : ContentPage
    {
        private readonly string validation01 = "castgroup";
        private readonly string validation02 = "poodle";


        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void Logar(object sender, EventArgs e)
        {
            string user = User.Text;
            string password = Senha.Text;

            if (user == validation01 && password == validation02)
            {
                User.Text = "";
                Senha.Text = "";
                await Navigation.PushAsync(new HomePage());
            }

            string msg = "Usuário ou senha incorretos";

            if (user == "" || password == "")
                msg = "Preencha todos os campos";


            var toastFrame = new Frame
            {
                Style = (Style)Resources["ToastStyle"],
                Opacity = 0
            };

            toastFrame.Content = new Label
            {
                Text = msg,
                TextColor = Color.White
            };

            AbsoluteLayout.SetLayoutBounds(toastFrame, new Rectangle(0.5, 0.9, 0.8, -1));
            AbsoluteLayout.SetLayoutFlags(toastFrame, AbsoluteLayoutFlags.PositionProportional | AbsoluteLayoutFlags.WidthProportional);

            AbsoluteLayout.SetLayoutBounds(toastFrame, new Rectangle(0.5, 0.9, 0.8, -1));
            AbsoluteLayout.SetLayoutFlags(toastFrame, AbsoluteLayoutFlags.PositionProportional | AbsoluteLayoutFlags.WidthProportional);

            AbsoluteLayout.SetLayoutBounds(toastFrame, new Rectangle(0.5, 0.9, 0.8, -1));
            AbsoluteLayout.SetLayoutFlags(toastFrame, AbsoluteLayoutFlags.PositionProportional | AbsoluteLayoutFlags.WidthProportional);

            AbsoluteLayout.SetLayoutBounds(toastFrame, new Rectangle(0.5, 0.9, 0.8, -1));
            AbsoluteLayout.SetLayoutFlags(toastFrame, AbsoluteLayoutFlags.PositionProportional | AbsoluteLayoutFlags.WidthProportional);

            AbsoluteLayout.SetLayoutBounds(toastFrame, new Rectangle(0.5, 0.9, 0.8, -1));
            AbsoluteLayout.SetLayoutFlags(toastFrame, AbsoluteLayoutFlags.PositionProportional | AbsoluteLayoutFlags.WidthProportional);

            AbsoluteLayout.SetLayoutBounds(toastFrame, new Rectangle(0.5, 0.9, 0.8, -1));
            AbsoluteLayout.SetLayoutFlags(toastFrame, AbsoluteLayoutFlags.PositionProportional | AbsoluteLayoutFlags.WidthProportional);

            var stackLayout = (StackLayout)this.Content;
            stackLayout.Children.Add(toastFrame);

            await toastFrame.FadeTo(1, 250);
            await Task.Delay(2000);
            await toastFrame.FadeTo(0, 250);
            stackLayout.Children.Remove(toastFrame);
        }
    }
}

