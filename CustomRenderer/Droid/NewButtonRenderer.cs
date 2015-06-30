using CustomRenderer;
using CustomRenderer.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(NewButton), typeof(NewButtonRenderer))]
namespace CustomRenderer.Droid
{
    public class NewButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.SetBackgroundResource(Resource.Drawable.RoundedButton);
                Control.SetTextColor(global::Android.Graphics.Color.White);
            }
        }
    }
}

