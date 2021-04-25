using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace form
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
           
            if (!string.IsNullOrEmpty(a.Text) && !string.IsNullOrEmpty(b.Text) && !string.IsNullOrEmpty(c.Text))
            {
                var A = double.Parse(a.Text);
                var B = double.Parse(b.Text);
                var C = double.Parse(c.Text);
                var B2 = B * B - 4 * A * C;
                var D = Math.Sqrt(B * B) -(4 * A * C);
                if ( B2 < 0){
                    DisplayAlert("Numeros Imaginarios", "Los números son imaginarios", "ok");
                    var B3 = -B2;
                    var form = (-B + Math.Sqrt(B3))/ (2 * A);
                    var form2 = (-B - Math.Sqrt(B3)) / (2 * A);
                    res1.Text = form.ToString();
                    res2.Text = form2.ToString();
                }
                else
                {
                    var form = (-B + Math.Sqrt(B2)) / (2 * A);
                    var form2 = (-B - Math.Sqrt(B2)) / (2 * A);
                    res1.Text = form.ToString();
                    res2.Text = form2.ToString();
                }                        
            }
            else
            {
                DisplayAlert("datos erroneos", "escribe todos los datos", "ok");
            }
        }
    }
}
