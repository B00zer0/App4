using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xamarin.Forms;
using static Xamarin.Essentials.Permissions;

namespace App4
{
    public partial class MainPage : ContentPage
    {
        
        private double container;
        private double mass;
        private int numOfContainers;
        private string result;
        

        public MainPage()
        {
            InitializeComponent();

        }
        

        private void BttResult_Clicked(object sender, EventArgs e)
        {
            ContainerContentCounting();
            result_output.Text = result;
        }

    private void ContainerContentCounting()
        {
            container = Convert.ToDouble(ContainerB.Text);
            mass = Convert.ToDouble(Mass.Text);
            numOfContainers = Convert.ToInt32(numofcontainers.Text);
            result = Convert.ToString(mass - container * numOfContainers);
            

        }

        private void BtnPlus_Clicked(object sender, EventArgs e)
        {
            
            if(result_output.Text == "0")
            {
                ContainerContentCounting();
                result_output.Text = result;
            }
            else
            {
                ContainerContentCounting();
                result_output.Text = Convert.ToString(Convert.ToDouble(result_output.Text) + Convert.ToDouble(result));
            }
        }

        private void BtnClr_Clicked(object sender, EventArgs e)
        {
            result_output.Text = "0";
        }
    }
}
