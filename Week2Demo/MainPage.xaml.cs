using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Week2Demo
{
    public partial class MainPage : ContentPage
    {
        public int counter = 0;
        public MainPage()
        {
            InitializeComponent();
            //Content = new Label
            //{
            //    HorizontalOptions = LayoutOptions.Center,
            //    VerticalOptions = LayoutOptions.Center,
            //    Text = "Hello from Code Behind"
            //};
        }

        //void btu1_Clicked(System.Object sender, System.EventArgs e)
        //{
        //    DisplayAlert("First message", "This is our first Alert", "OK");
        //}

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            counter++;
            myLabel.Text = "This Button clicked for " + Convert.ToString(counter);
        }

        //void Slider_ValueChanged(System.Object sender, Xamarin.Forms.ValueChangedEventArgs e)
        //{
        //    myLabel2.Text = "The slider value is " + e.NewValue;
        //}
    }
}
