using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace bmi
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ButtonBMI.Clicked += ButtonBMI_Clicked;
            ButtonBMI2.Clicked += ButtonBMI2_Clicked;
        }

        private void ButtonBMI2_Clicked(object sender, EventArgs e)
        {
            float height = float.Parse(EntryHeight.Text);
            float weight = float.Parse(EntryWeight.Text);

            if (height < 3)
            {
                height = height * height;
                weight = weight / height;

                Navigation.PushModalAsync(new NavigationPage(new NextPage1(weight)));
            }
            else
            {
                height = height / 100;
                height = height * height;
                weight = weight / height;

                Navigation.PushModalAsync(new NavigationPage(new NextPage1(weight)));
            }
        }

        private void ButtonBMI_Clicked(object sender, EventArgs e)
        {
            float height = float.Parse(EntryHeight.Text);
            float weight = float.Parse(EntryWeight.Text);

            if (height < 3)
            {
                height = height * height;
                weight = weight / height;
                LabelResult.Text = "BMI:" + weight;
            }
            else
            {
                height = height / 100;
                height = height * height;
                weight = weight / height;
                LabelResult.Text = "BMI:" + weight;
            }
        }

    }
}
