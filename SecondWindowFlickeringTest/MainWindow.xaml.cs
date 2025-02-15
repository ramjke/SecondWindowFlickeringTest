using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace SecondWindowFlickeringTest
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        private SecondWindow secondWindow;
        public MainWindow()
        {
            this.InitializeComponent();
            ExtendsContentIntoTitleBar = true;  // enable custom titlebar            
        }

        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            secondWindow = new();
            secondWindow.Activate();
            myButton.Content = "Clicked";
        }
    }
}
