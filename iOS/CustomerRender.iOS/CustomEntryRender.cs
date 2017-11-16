using System;
using Login.CustomRender;
using Login.iOS.CustomerRender.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRender))]
namespace Login.iOS.CustomerRender.iOS
{
    public class CustomEntryRender : EntryRenderer
    {
        public CustomEntryRender()
        {
            
        }

    }
}
