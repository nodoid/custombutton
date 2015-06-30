using CustomRenderer;
using CustomRenderer.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(NewButton), typeof(NewButtonRenderer))]
namespace CustomRenderer.iOS
{
    public class NewButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.BackgroundColor = UIColor.FromRGB(130, 186, 132);
                Control.SetTitleColor(UIColor.White, UIControlState.Normal);
                Control.Layer.BorderWidth = 0.8f;
                Control.Layer.BorderColor = UIColor.FromRGB(45, 176, 51).CGColor;
                Control.Layer.CornerRadius = 10f;
            }
        }
    }
}

