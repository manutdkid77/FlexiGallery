using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Debug = System.Diagnostics.Debug;

namespace FlexiGallery.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GalleryPage : ContentPage
    {
        private int iNumOfSquares = 3;
        public GalleryPage()
        {
            InitializeComponent();
            BindFlexLayout();
        }

        private void GalleryPage_SizeChanged(object sender, EventArgs e)
        {
            AdjustSquareDimensions();
        }
        private void BindFlexLayout()
        {
            var items = new List<string>();
            for(var i = 1; i < 26; i++)
            {
                items.Add($"https://picsum.photos/200?random={i}");
            }
            BindableLayout.SetItemsSource(flxContainer, items);
            AdjustSquareDimensions();
        }

        private void AdjustSquareDimensions()
        {
            if (Width <= 0 || iNumOfSquares<=0)
                return;

            var dbSide = Width / iNumOfSquares;

            foreach (var child in flxContainer.Children)
            {
                if (child is Frame frame)
                {
                    frame.WidthRequest = dbSide;
                    frame.HeightRequest = dbSide;
                }
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            SizeChanged += GalleryPage_SizeChanged;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            SizeChanged -= GalleryPage_SizeChanged;
        }

        private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            iNumOfSquares = (int)e.NewValue;
            AdjustSquareDimensions();
        }
    }
}