using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace bmi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NextPage1 : ContentPage
    {
        private float weight;

        public NextPage1()
        {
            InitializeComponent();
            BACKBUTTON.Clicked += BACKBUTTON_Clicked;
        }

        private void BACKBUTTON_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        public NextPage1(float weight)
        {
            InitializeComponent();
            this.weight = weight;
            labelBMI.Text = "BMI:"+weight;
            BACKBUTTON.Clicked += BACKBUTTON_Clicked;
        }



    }
}
