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
        
        public MainPage()
        {
            InitializeComponent();

           



        }
       
        private void BttResult_Clicked(object sender, EventArgs e)
        {
            string containerStr = ContainerB.Text;
            string massStr = Mass.Text;
            double containerD = Convert.ToDouble(containerStr);
            double massD = Convert.ToDouble(massStr);
            int numOfContainers = Convert.ToInt32(numofcontainers.Text);
            result.Text = Convert.ToString(TobaccoCount(numOfContainers ,containerD, massD));

        }

    private double TobaccoCount(int numOfContainers, double containerBox,double mass)
        {
            
            return mass - containerBox*numOfContainers;

        }
       
    }
}
