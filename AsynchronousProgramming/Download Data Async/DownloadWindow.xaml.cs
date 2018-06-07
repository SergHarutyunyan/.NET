using System;
using System.ComponentModel;
using System.Net;
using System.Windows;

namespace MainWindow.Download_Data_Async
{
    /// <summary>
    /// Interaction logic for DownloadWindow.xaml
    /// </summary>
    public partial class DownloadWindow : Window
    {
        private int count = 0;

        public DownloadWindow()
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }

        private void DownloadRSS_Click(object sender, RoutedEventArgs e)
        {
            Downloader.Text = "Downloading...";
            DownloadRSS.IsEnabled = false;

            WebClient client = new WebClient();
            string path = "D://file.pdf";
            client.QueryString.Add("DownloadedFilePath", path);
            client.DownloadFileAsync(new Uri("https://drive.google.com/uc?export=download&id=1c1GNpUQnsmcAMvPfwd70swBj6Rm2ONR4"), path);

            client.DownloadFileCompleted += AsyncDownloadFileCompleted;
        }

        private void AsyncDownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            string filePath = ((WebClient)sender).QueryString["DownloadedFilePath"];
            Downloader.Text = $"File Downloaded: " + filePath;
            DownloadRSS.IsEnabled = true;
        }

        private void CounterIncButton_Click(object sender, RoutedEventArgs e)
        {
            Counter.Text = $"Counter: {++count}";
        }
    }
}
