using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ChildrenRhymes
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Grid_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(jingle));
        }

        private void Grid_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(twinkle));
        }

        private void Grid_Tapped_2(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(piggy));
        }

        private void Grid_Tapped_3(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(jack));
        }

        private void Grid_Tapped_4(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(teddy));
        }

        private void Grid_Tapped_5(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(hickory));
        }

        private void Grid_Tapped_6(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(humpty));
        }

        private void Grid_Tapped_7(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(johny));
        }

        private void Grid_Tapped_8(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(sheep));
        }

        private void Grid_Tapped_9(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(london));
        }

        private void Grid_Tapped_10(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ringa));
        }

        private void Grid_Tapped_11(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(clap));
        }

        private void Grid_Tapped_12(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(developer));
        }
    }
}
