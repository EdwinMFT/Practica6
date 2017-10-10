using Android.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainCarouselPage : CarouselPage
    {
        //public Image Content;
        int d1,d2;
        int e1, e2;
        int im3, nim3;
        int im4, nim4;
        int im5, nim5;
        int im6, nim6;
        int im7, nim7;
        int im8, nim8;
        int im9, nim9;
        int im10, nim10;

        public MainCarouselPage()
        {
            InitializeComponent();
            //var imagenDS = new Image
            //{
            //    //Source = (ImageSource.FromResource("Practica6.ParaYoshi.png"))
            //    Source =ImageSource.FromUri(new Uri("https://cdn.google.com/images/google.png"))// desde internet 
            //};
            //Content = imagenDS;

        }

        private void Like1_Clicked(object sender, EventArgs e)
        {

            if (MG1.IsEnabled)
            {
                d1 = 1;
                if (d1 == 1)
                {
                    d2 = 1;
                    MG1.IsEnabled = false;
                    NMG1.IsEnabled = true;
                    //DisplayAlert("", "1:"+d1, "OK");
                }
                
            }
            
            
        }
        private void NoLike1_Clicked(object sender, EventArgs e)
        {
            
                if (NMG1.IsEnabled)
                {
                    d2 = 0;
                    //MG1.IsEnabled = true;
                    if (d2 == 0)
                    {
                    d1 = 0;
                        NMG1.IsEnabled = false;
                        MG1.IsEnabled = true;
                      //  DisplayAlert("", "Cero", "OK");
                    }
                
            }
        }
        private void Like2_Clicked(object sender, EventArgs e)
        {
            e1 = 1;
            if (e1 == 1)
            {
                e2 = 1;
                MG2.IsEnabled = false;
                NMG2.IsEnabled = true;
                //DisplayAlert("", "1", "OK");
            }
        }
        private void NoLike2_Clicked(object sender, EventArgs e)
        {
            if (NMG2.IsEnabled)
            {
                e2 = 0;
                //MG1.IsEnabled = true;
                if (e2 == 0)
                {
                    e1 = 0;
                    NMG2.IsEnabled = false;
                    MG2.IsEnabled = true;
                  //  DisplayAlert("", "Cero", "OK");
                }
            }
        }
        private void Like3_Clicked(object sender, EventArgs e)
        {
            if (MG3.IsEnabled) { 
            im3 = 1;
            if (im3 == 1)
            {
                nim3 = 1;
                MG3.IsEnabled = false;
                NMG3.IsEnabled = true;
                //DisplayAlert("", "1", "OK");
            }
            }
        }
        private void NoLike3_Clicked(object sender, EventArgs e)
        {
            if (NMG3.IsEnabled)
            {
                nim3 = 0;
                //MG1.IsEnabled = true;
                if (nim3 == 0)
                {
                    im3 = 0;
                    NMG3.IsEnabled = false;
                    MG3.IsEnabled = true;
                  //  DisplayAlert("", "Cero", "OK");
                }
            }
        }
        private void Like4_Clicked(object sender, EventArgs e)
        {
            if (MG4.IsEnabled) { 
            im4 = 1;
            if (im4 == 1)
            {
                nim4 = 1;
                MG4.IsEnabled = false;
                NMG4.IsEnabled = true;
                //DisplayAlert("", "1", "OK");
            }
            }
        }
        private void NoLike4_Clicked(object sender, EventArgs e)
        {
            if (NMG4.IsEnabled)
            {
                nim4 = 0;
                //MG1.IsEnabled = true;
                if (nim4 == 0)
                {
                    im4 = 0;
                    NMG4.IsEnabled = false;
                    MG4.IsEnabled = true;
                  //  DisplayAlert("", "Cero", "OK");
                }
            }
        }
        private void Like5_Clicked(object sender, EventArgs e)
        {
            if (MG5.IsEnabled) { 
            im5 = 1;
            if (im5 == 1)
            {
                nim5 = 1;
                MG5.IsEnabled = false;
                NMG5.IsEnabled = true;
                //DisplayAlert("", "1", "OK");
             }
            }
        }
        private void NoLike5_Clicked(object sender, EventArgs e)
        {
            if (NMG5.IsEnabled)
            {
                nim5 = 0;
                //MG1.IsEnabled = true;
                if (nim5 == 0)
                {
                    im5 = 0;
                    NMG5.IsEnabled = false;
                    MG5.IsEnabled = true;
                  //  DisplayAlert("", "Cero", "OK");
                }
            }
        }
        private void Like6_Clicked(object sender, EventArgs e)
        {
            if (MG6.IsEnabled)
            {
                im6 = 1;
                if (im6 == 1)
                {
                    nim6 = 1;
                    MG6.IsEnabled = false;
                    NMG6.IsEnabled = true;
                    //DisplayAlert("", "1", "OK");
                }
            }
        }
        private void NoLike6_Clicked(object sender, EventArgs e)
        {
            if (NMG6.IsEnabled)
            {
                nim6 = 0;
                //MG1.IsEnabled = true;
                if (nim6 == 0)
                {
                    im6 = 0;
                    NMG6.IsEnabled = false;
                    MG6.IsEnabled = true;
                   // DisplayAlert("", "Cero", "OK");
                }
            }
        }
        private void Like7_Clicked(object sender, EventArgs e)
        {
            if (MG7.IsEnabled)
            {
                im7 = 1;
                if (im7 == 1)
                {
                    nim7 = 1;
                    MG7.IsEnabled = false;
                    NMG7.IsEnabled = true;
                    //DisplayAlert("", "1", "OK");
                }
            }
        }
        private void NoLike7_Clicked(object sender, EventArgs e)
        {
            if (NMG7.IsEnabled)
            {
                nim7 = 0;
                //MG1.IsEnabled = true;
                if (nim7 == 0)
                {
                    im7 = 0;
                    NMG7.IsEnabled = false;
                    MG7.IsEnabled = true;
                   // DisplayAlert("", "Cero", "OK");
                }
            }
        }
        private void Like8_Clicked(object sender, EventArgs e)
        {
            if (MG8.IsEnabled)
            {
                im8 = 1;
                if (im8 == 1)
                {
                    nim8 = 1;
                    MG8.IsEnabled = false;
                    NMG8.IsEnabled = true;
                    //DisplayAlert("", "1", "OK");
                }
            }
        }
        private void NoLike8_Clicked(object sender, EventArgs e)
        {
            if (NMG8.IsEnabled)
            {
                nim8 = 0;
                //MG1.IsEnabled = true;
                if (nim8 == 0)
                {
                    im8 = 0;
                    NMG8.IsEnabled = false;
                    MG8.IsEnabled = true;
                    //DisplayAlert("", "Cero", "OK");
                }
            }
        }
        private void Like9_Clicked(object sender, EventArgs e)
        {
            if (MG9.IsEnabled)
            {
                im9 = 1;
                if (im9 == 1)
                {
                    nim9 = 1;
                    MG9.IsEnabled = false;
                    NMG9.IsEnabled = true;
                    //DisplayAlert("", "1", "OK");
                }
            }
        }
        private void NoLike9_Clicked(object sender, EventArgs e)
        {
            if (NMG9.IsEnabled)
            {
                nim9 = 0;
                //MG1.IsEnabled = true;
                if (nim9 == 0)
                {
                    im9 = 0;
                    NMG9.IsEnabled = false;
                    MG9.IsEnabled = true;
                    //DisplayAlert("", "Cero", "OK");
                }
            }
        }
        private void Like10_Clicked(object sender, EventArgs e)
        {
            if (MG10.IsEnabled)
            {
                im10 = 1;
                if (im10 == 1)
                {
                    nim10 = 1;
                    MG10.IsEnabled = false;
                    NMG10.IsEnabled = true;
                    //DisplayAlert("", "1", "OK");
                }
            }
        }
        private void NoLike10_Clicked(object sender, EventArgs e)
        {
            if (NMG10.IsEnabled)
            {
                nim10 = 0;
                //MG1.IsEnabled = true;
                if (nim10 == 0)
                {
                    im10 = 0;
                    NMG10.IsEnabled = false;
                    MG10.IsEnabled = true;
                    //DisplayAlert("", "Cero", "OK");
                }
            }
        }

        public void imagenesValidacion()
        {
            if (d1 == 1)
            {
                DisplayAlert("", "imagen1 me gusta", "ok");
            }
            if (e1 == 1)
            {
                DisplayAlert("", "imagen2 me gusta", "ok");
            }
            if (d2 == 0)
            {
                DisplayAlert("", "imagen1 no me gusta", "ok");
            }
            if (e2 == 0)
            {
                DisplayAlert("", "imagen2 no me gusta", "ok");
            }
            if (im3 == 1)
            {
                DisplayAlert("", "imagen3 me gusta", "ok");
            }
            if (nim3 == 0)
            {
                DisplayAlert("", "imagen3 no me gusta", "ok");
            }
            if (im4 == 1)
            {
                DisplayAlert("", "imagen4 me gusta", "ok");
            }
            if (nim4 == 0)
            {
                DisplayAlert("", "imagen4 no me gusta", "ok");
            }
            if (im5 == 1)
            {
                DisplayAlert("", "imagen5 me gusta", "ok");
            }
            if (nim5 == 0)
            {
                DisplayAlert("", "imagen5 no me gusta", "ok");
            }
            if (im6 == 1)
            {
                DisplayAlert("", "imagen6 me gusta", "ok");
            }
            if (nim6 == 0)
            {
                DisplayAlert("", "imagen6 no me gusta", "ok");
            }
            if (im7 == 1)
            {
                DisplayAlert("", "imagen7 me gusta", "ok");
            }
            if (nim7 == 0)
            {
                DisplayAlert("", "imagen7 no me gusta", "ok");
            }
            if (im8 == 1)
            {
                DisplayAlert("", "imagen8 me gusta", "ok");
            }
            if (nim8 == 0)
            {
                DisplayAlert("", "imagen8 no me gusta", "ok");
            }
            if (im9 == 1)
            {
                DisplayAlert("", "imagen9 me gusta", "ok");
            }
            if (nim9 == 0)
            {
                DisplayAlert("", "imagen9 no me gusta", "ok");
            }
            if (im10 == 1)
            {
                DisplayAlert("", "imagen10 me gusta", "ok");
            }
            if (nim10 == 0)
            {
                DisplayAlert("", "imagen10 no me gusta", "ok");
            }
        }
        private void Validar_Clicked(object sender, EventArgs e)
        {
            imagenesValidacion();
        }
    }
}
