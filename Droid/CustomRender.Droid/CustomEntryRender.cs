using System;
using Login.CustomRender;
using Login.Droid.CustomRender.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRender))]    
namespace Login.Droid.CustomRender.Droid
{

    public class CustomEntryRender : EntryRenderer
    {
        public CustomEntryRender()
        {
            this.TextAlignment = Android.Views.TextAlignment.Center; 
        }
    }
}
