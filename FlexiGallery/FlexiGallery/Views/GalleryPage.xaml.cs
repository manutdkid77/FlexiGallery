using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XE = Xamarin.Essentials;
using Debug = System.Diagnostics.Debug;

namespace FlexiGallery.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GalleryPage : ContentPage
    {
        public GalleryPage()
        {
            InitializeComponent();
            this.SizeChanged += GalleryPage_SizeChanged;
        }

        private void GalleryPage_SizeChanged(object sender, EventArgs e)
        {
            //var dbDeviceWidth = XE.DeviceDisplay.MainDisplayInfo.Width;
            //Debug.WriteLine($"{nameof(dbDeviceWidth)} is {dbDeviceWidth}");
            //var fltFlexBasis = (float)((dbDeviceWidth / 3) / 100);
            //var fltFlexBasis = (float)(dbDeviceWidthSplit / 3) / 100;

            var fltFlexBasis = (((float)100 / 3) / 100);

            foreach (var child in flxContainer.Children)
            {
                FlexLayout.SetBasis(child, new FlexBasis(fltFlexBasis, isRelative:true));
            }
        }
    }
}