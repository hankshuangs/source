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
        ZXingBarcodeImageView barcode2;
        StackLayout stackPrinc1;
        StackLayout stackPrinc2;
        StackLayout stackPrinc3;
        Entry MyEntry;
        Entry MyEntry2;
        public MainPage()
        {
            InitializeComponent();

            var MyLabel = new Label
            {
                Text = "請在下方輸入",
                FontSize = 20,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.Center                
            };
            MyEntry = new Entry
            {
                Placeholder = "請輸入文字或網址",
                FontSize = 20,
                WidthRequest = 300,
                PlaceholderColor = Color.Olive,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.Center
            };
            var MyButton = new Button
            {
                Text = "產生二維條碼",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.Center
            };
            MyButton.Clicked += MyButton_Clicked;

            var MyLabel0 = new Label
            {
                Text = "",
                FontSize = 20,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center
            };
            var MyLabel01 = new Label
            {
                Text = "",
                FontSize = 20,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center
            };

            barcode = new ZXingBarcodeImageView
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                AutomationId = "zxingBarcodeImageView",

            };
            barcode.BarcodeFormat = ZXing.BarcodeFormat.QR_CODE;
            barcode.BarcodeOptions.Width = 100;
            barcode.BarcodeOptions.Height = 100;
            barcode.BarcodeValue = "http://yahoo.com.tw";
            barcode.RelScaleTo(2.5);
            barcode.IsVisible = false;



            var MyLabel2 = new Label
            {
                Text = "請在下方輸入",
                FontSize = 20,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.Center
            };
            MyEntry2 = new Entry
            {
                Placeholder = "請輸入數字或員編",
                FontSize = 20,
                WidthRequest = 200,
                PlaceholderColor = Color.Olive,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.Center
            };
            var MyButton2 = new Button
            {
                Text = "產生一維條碼",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.Center
            };
            MyButton2.Clicked += MyButton2_Clicked;

            barcode2 = new ZXingBarcodeImageView
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                AutomationId = "zxingBarcodeImageView2",
            };
            barcode2.BarcodeFormat = ZXing.BarcodeFormat.CODE_39;
            barcode2.BarcodeOptions.Width = 600;
            barcode2.BarcodeOptions.Height = 150;
            barcode2.BarcodeOptions.Margin = 10;
            barcode2.BarcodeValue = "12345678";
            barcode2.IsVisible = false;





            stackPrinc1 = new StackLayout
            {
                
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions= LayoutOptions.CenterAndExpand,
                Spacing = 10,
                Children =
                {
                    MyLabel,
                    MyEntry,
                    MyButton,
                    MyLabel0,
                    MyLabel01,
                    barcode,
                    
                }
            };
            stackPrinc2 = new StackLayout
            {
                
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Spacing = 10,
                Children =
                {
                    MyLabel2,
                    MyEntry2,
                    MyButton2,
                    barcode2
                }
            };

            stackPrinc3 = new StackLayout
            {
                VerticalOptions = LayoutOptions.Start,
                Spacing = 50,
                Children =
                {
                    stackPrinc1,
                    stackPrinc2
                }
            };


            Content = stackPrinc3;


        }

        private void MyButton_Clicked(object sender, EventArgs e)
        {

            barcode.IsVisible = true;
            barcode.BarcodeValue = MyEntry.Text;
        }
        private void MyButton2_Clicked(object sender, EventArgs e)
        {

            barcode2.IsVisible = true;
            barcode2.BarcodeValue = MyEntry2.Text;
        }
    }
}
