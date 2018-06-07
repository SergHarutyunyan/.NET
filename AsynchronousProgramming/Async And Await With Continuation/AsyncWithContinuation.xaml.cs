using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MainWindow.Async_And_Await_With_Continuation
{
    /// <summary>
    /// Interaction logic for AsyncWithContinuation.xaml
    /// </summary>
    public partial class AsyncWithContinuation : Window
    {
        public AsyncWithContinuation()
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }

        private void LoginConWith_Click(object sender, RoutedEventArgs e)
        {
            LoginConWith.IsEnabled = false;

            var task = Task.Run(() =>
            {
                //throw new UnauthorizedAccessException();
                Thread.Sleep(2000);
                return "Login Success!!!";
            });

            //LoginConWith.Content = task.Result; This will block UI Thread.

            // With Continue with keyword we need to use Dispatcher.Invoke().
            // Because our thread doesn't running on the same thread as our UI thread.
            task.ContinueWith((t) =>
            {
                if (t.IsFaulted)
                {
                    Dispatcher.Invoke(() =>
                    {
                        LoginConWith.Content = "Login Failed";
                        LoginConWith.IsEnabled = true;
                    });
                }
                Dispatcher.Invoke(() =>
                {
                    LoginConWith.Content = t.Result;
                    LoginConWith.IsEnabled = true;
                });
            });
        }

        private void LoginConfAwait_Click(object sender, RoutedEventArgs e)
        {
            LoginConfAwait.IsEnabled = false;

            var task = Task.Run(() =>
            {
                Thread.Sleep(2000);
                return "Login Success!!!";
            });

            // Using ConfigureAwait will solve the problem with UI elements. So now we don't need to use Dispatcher.

            task.ConfigureAwait(true) // True means that this will be executed by UI Thread.
                .GetAwaiter()
                .OnCompleted(() =>
                {
                    LoginConfAwait.Content = task.Result;
                    LoginConfAwait.IsEnabled = true;
                });
        }
    }
}
