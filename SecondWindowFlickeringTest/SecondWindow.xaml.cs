using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Intrinsics.Arm;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace SecondWindowFlickeringTest
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SecondWindow : Window
    {
        public SecondWindow()
        {
            this.InitializeComponent();
        }

        private void ToggleSwitch_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            Debug.WriteLine("ToggleSwitch_PointerEntered");
        }

        private void Button_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            Debug.WriteLine("Button_PointerEntered");
        }
    }
}
