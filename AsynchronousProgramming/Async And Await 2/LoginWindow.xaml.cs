using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace MainWindow.Async_And_Await_2
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }

        private async void LoginBtn2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                await LoginAsyncFailure();              // If we specifying here await, we are giving that exception to this handler method. 

            }
            catch(Exception ex)
            {
                LoginBtn2.Content = "Login Failed";
            }
        }

        private async Task LoginAsyncFailure()           
        {
            throw new UnauthorizedAccessException();    // State Machine catches this exception

            try
            {
                var result = await Task.Run(() =>
                {
                    Thread.Sleep(2000);
                    return "Login Successful!";
                });
            }
            catch (Exception)
            {

            }
        }

        private async void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                LoginBtn.IsEnabled = false;

                var result = await loginAsync();       

                // Everything below await is executing as continuation, but with a UI thread.
                LoginBtn.Content = result;
                LoginBtn.IsEnabled = true;
            }
            catch (Exception)
            {
                LoginBtn.Content = "Internal Error";
            }
        }

        private async Task<string> loginAsync()
        {
            try
            {
                var result = await Task.Run(() =>                   // Here result is string 
                {
                    Thread.Sleep(2000);
                    return "Login Successful!";
                });


                var loginTask = Task.Run(() =>
                {
                    return "";
                });

                //var anonymous = Task.Run(async () =>              // Anonymous method can be async as well.
                //{                                                 // Here we are awaiting Task.Delay(2000).
                //    await Task.Delay(2000);

                //    return "Login Successful!";
                //});

                var logTask = Task.Delay(2000);
                var purchaseTask = Task.Delay(1000);

                await Task.WhenAll(loginTask, logTask, purchaseTask);  // This returns a Task. So we can schedule a continuation again.

                return loginTask.Result;
            }
            catch(Exception)
            {
                return "Login Failed!";
            }
        }

        //// DeadLock Example
        //private void LoginBtn3_Click(object sender, RoutedEventArgs e)
        //{
        //    var task = Task.Run(() => { Thread.Sleep(2000); })
        //        .ContinueWith((t) =>
        //        {
        //            Dispatcher.Invoke(() => { LoginBtn3.Content = "Done"; });
        //        });

        //    task.Wait();    // Blocks the UI thread until task will complete his work.
        //}

        // DeadLock Example 2
        private void LoginBtn3_Click(object sender, RoutedEventArgs e)
        {
            var result = loginAsync().Result;

            // Solving deadlock
            //var result2 = Task.Run(() => loginAsync()).Result; 
        }
    }
}
