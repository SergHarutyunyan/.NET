using MainWindow.Async_And_Await;
using MainWindow.Async_And_Await_2;
using MainWindow.Async_And_Await_With_Continuation;
using MainWindow.Download_Data_Async;
using System.Windows;

namespace MainWindow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class SwitchWindow : Window
    {
        public SwitchWindow()
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }

        private void AsyncAndAwait1_Click(object sender, RoutedEventArgs e)
        {
            CountSum countWindow = new CountSum();
            App.Current.MainWindow = countWindow;
            this.Close();
            countWindow.Show();
        }

        private void AsyncWithContinuation_Click(object sender, RoutedEventArgs e)
        {
            AsyncWithContinuation Cont = new AsyncWithContinuation();
            App.Current.MainWindow = Cont;
            this.Close();
            Cont.Show();
        }

        private void DownloadDataAsync_Click(object sender, RoutedEventArgs e)
        {
            DownloadWindow downloadWind = new DownloadWindow();
            App.Current.MainWindow = downloadWind;
            this.Close();
            downloadWind.Show();
        }

        private void AsyncAndAwait2_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow login = new LoginWindow();
            App.Current.MainWindow = login;
            this.Close();
            login.Show();
        }
    }
}
