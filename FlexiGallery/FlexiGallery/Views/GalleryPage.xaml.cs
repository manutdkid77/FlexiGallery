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
            var items = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            BindableLayout.SetItemsSource(flxContainer, items);
            AdjustSquareDimensions();
        }

        private void AdjustSquareDimensions()
        {
            var dbSide = Width / iNumOfSquares;

            foreach (var child in flxContainer.Children)
            {
                if (child is Frame frame)
                {
                    if (dbSide != frame.WidthRequest || dbSide != frame.HeightRequest)
                    {
                        frame.WidthRequest = dbSide;
                        frame.HeightRequest = dbSide;
                    }
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