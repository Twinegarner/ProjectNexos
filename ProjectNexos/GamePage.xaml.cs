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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProjectNexos
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GamePage : Page
    {
        GameFileReader gameTest = new GameFileReader();

        public GamePage()
        {
            this.InitializeComponent();
            
        }

        private void LeftButton_Click(object sender, RoutedEventArgs e)
        {
            TextViewMain.Text = gameTest.RoomLoader();
        }

        private void RightButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UpButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DownButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
