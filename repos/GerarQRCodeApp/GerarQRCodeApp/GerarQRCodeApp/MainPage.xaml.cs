using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using ZXing.Net.Mobile.Forms;

namespace GerarQRCodeApp
{

    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        ZXingBarcodeImageView barcode;
        //ZXingBarcodeImageView barcode2;
        StackLayout stackPrinc;
        Entry MyEntry;
        public MainPage()
        {
            InitializeComponent();

            var MyLabel = new Label
            {
                Text = "請在下方輸入文字",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.Center
            };
            MyEntry = new Entry
            {
                Placeholder = "輸入文字",
                PlaceholderColor = Color.Olive,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.Center
            };
            var MyButton = new Button
            {
                Text = "QRCode",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.Center
            };
            MyButton.Clicked += MyButton_Clicked;

            barcode = new ZXingBarcodeImageView
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                AutomationId = "zxingBarcodeImageView",
            };
            barcode.BarcodeFormat = ZXing.BarcodeFormat.QR_CODE;
            barcode.BarcodeOptions.Width = 30;
            barcode.BarcodeOptions.Height = 30;
            barcode.BarcodeOptions.Margin = 10;
            barcode.BarcodeValue = "AAA";
            barcode.IsVisible = false;

            stackPrinc = new StackLayout
            {
                Spacing = 0.1,
                Children =
                {
                    MyLabel,
                    MyEntry,
                    MyButton,
                    barcode
                }
            };

            Content = stackPrinc;

            //barcode2 = new ZXingBarcodeImageView
            //{
            //    HorizontalOptions = LayoutOptions.FillAndExpand,
            //    VerticalOptions = LayoutOptions.FillAndExpand,
            //    AutomationId = "zxingBarcodeImageView",
            //};
            //barcode2.BarcodeFormat = ZXing.BarcodeFormat.CODE_39;
            //barcode2.BarcodeOptions.Width = 60;
            //barcode2.BarcodeOptions.Height = 20;
            //barcode2.BarcodeOptions.Margin = 10;
            //barcode2.BarcodeValue = "10611515";


            //stackPrinc.Children.Add(barcode2);
        }

        private void MyButton_Clicked(object sender, EventArgs e)
        {
            barcode.IsVisible = true;
            barcode.BarcodeValue = MyEntry.Text;
        }

    }
}
