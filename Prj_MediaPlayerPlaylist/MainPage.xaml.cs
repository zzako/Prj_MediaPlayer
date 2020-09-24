using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Playback;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Prj_MediaPlayerPlaylist
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

        private async void AppBarbutton_Click(object sender, RoutedEventArgs e)
        {
            var picker = new FileOpenPicker();
            picker.FileTypeFilter.Add(".mp4");
            picker.FileTypeFilter.Add(".mkv");
            picker.FileTypeFilter.Add(".av1");
            picker.FileTypeFilter.Add(".wav");
            picker.SuggestedStartLocation = PickerLocationId.VideosLibrary;
            var files = await picker.PickSingleFileAsync();
            if (files != null)
            {
                IRandomAccessStream stream = await files.OpenAsync(FileAccessMode.Read);

                mediaElement.SetSource(stream, files.ContentType);
            }

        }

        private void play_Click(object sender, RoutedEventArgs e)
        {
            mediaElement.Play();
        }

        private void stop_Click(object sender, RoutedEventArgs e)
        {
            mediaElement.Stop();
        }

        private void pause_Click(object sender, RoutedEventArgs e)
        {
            mediaElement.Pause();
        }

        private void AppBarButton_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void CommandBar_Opened(object sender, object e)
        {

        }

        private  void playlist_Click(object sender, RoutedEventArgs e)
        {



        }
    }
}
