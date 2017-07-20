using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ProtocolActivation
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

        public void NavigateWithParameters(string target, string color)
        {
            string hexCode = color.Replace("#", string.Empty);
            byte a = (byte)(Convert.ToUInt32(hexCode.Substring(0, 2), 16));
            byte r = (byte)(Convert.ToUInt32(hexCode.Substring(2, 2), 16));
            byte g = (byte)(Convert.ToUInt32(hexCode.Substring(4, 2), 16));
            byte b = (byte)(Convert.ToUInt32(hexCode.Substring(6, 2), 16));

            var brush = new SolidColorBrush(Color.FromArgb(a, r, g, b));

            if (target.ToLower() == "background")
            {
                grdBackground.Background = brush;
            }
            else
            {
                grdForeground.Background = brush;
            }
        }

    }


}
