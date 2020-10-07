using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TestDialog
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

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var folderPicker = new FolderPicker();
            folderPicker.SuggestedStartLocation = PickerLocationId.Desktop;
            folderPicker.FileTypeFilter.Add("*");
            StorageFolder folder = await folderPicker.PickSingleFolderAsync();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            var dialog = new CustomDialog();
            dialog.ShowAsync();
        }

        private void StackPanel_PointerWheelChanged(object sender, PointerRoutedEventArgs e)
        {

        }

        private void StackPanel_ManipulationStarting(object sender, ManipulationStartingRoutedEventArgs e)
        {

        }

        private void StackPanel_ManipulationDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            var s =  e.Delta.Scale;
        }
    }
}
