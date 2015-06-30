using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WinPhone;
using System.Windows.Controls;
using CustomRenderer;
using WinPhone;
using System.Windows;

[assembly: ExportRenderer(typeof(NewButton), typeof(NewButtonRenderer))]
namespace WinPhone
{
    class NewButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
 	        base.OnElementChanged(e);
            if (Control != null)
            {
                var myControl = Control as System.Windows.Controls.Button;

                var border = new Border
                {
                    CornerRadius = new System.Windows.CornerRadius(10),
                    Background = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 130, 186, 132)),
                    BorderBrush = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255,45,176,51)),
                    BorderThickness = new System.Windows.Thickness(0.8),
                };
                            
                myControl.Foreground = new SolidColorBrush(Colors.White);

                border.Child = myControl;
            }
        }
    }
}
