using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        //[Obsolete]
        public MainPage()
        {
            InitializeComponent();

            //設定不同裝置的值
            //Padding = new OnPlatform<Thickness> { 
            //    Android =new Thickness(0),
            //    iOS = new Thickness(0,20,0,0)
            //};


        }
    }
}
