# FlexiGallery

## About
This is a Xamarin Forms app that recreates the grid view look of popular podcasts app such as AntennaPod and Pocket Casts.

## Purpose
This was done to make the PodcastDirectoryPage of [Hanselman.Forms](https://github.com/jamesmontemagno/Hanselman.Forms) to have each podcast rendered as a square and to match the look of above mentioned apps. This is being tracked in [Pull Request #112](https://github.com/jamesmontemagno/Hanselman.Forms/pull/122).

## How It Works

* It uses the [FlexLayout](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/layouts/flex-layout) control to render the squares. 
* The `FlexLayout` uses [Bindable Layouts](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/layouts/bindable-layouts) concept to bind to a collection of items, creating a list of squares.
* Here each square has a side calculated as  `Width Of Device` divided by the `Number Of Squares`

### AIM
![AntennaPod_portrait](https://raw.githubusercontent.com/manutdkid77/FlexiGallery/master/screenshots/antennapod_1.png)

![AntennaPod_landscape](https://raw.githubusercontent.com/manutdkid77/FlexiGallery/master/screenshots/antennapod_2.png.png)

### RESULT
![FlexiGallery_Screenshot_GIF](https://raw.githubusercontent.com/manutdkid77/FlexiGallery/master/screenshots/flexigallery.gif)

![FlexiGallery_Screenshot_Android](https://raw.githubusercontent.com/manutdkid77/FlexiGallery/master/screenshots/flexigallery_android.png)

![FlexiGallery_Screenshot_iOS](https://raw.githubusercontent.com/manutdkid77/FlexiGallery/master/screenshots/flexigallery_iOS.png)