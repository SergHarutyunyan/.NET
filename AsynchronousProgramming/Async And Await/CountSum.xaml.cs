using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace MainWindow.Async_And_Await
{
    /// <summary>
    /// Interaction logic for CountSum.xaml
    /// </summary>
    public partial class CountSum : Window
    {
        public CountSum()
        {
            InitializeComponent();
        }

        private void Sync_Click(object sender, RoutedEventArgs e)
        {
            Txt.Text = "Started...";

            long sum = 0;
            var watch = Stopwatch.StartNew();
            for (long i = 0; i < 400000000; i++)
            {
                sum += i;
            }
            watch.Stop();
            var elapsed = watch.ElapsedMilliseconds;

            Txt.Text += "\nWorking time: " +
                elapsed + "\nSum = " + sum;
        }

        private async void Async_Click(object sender, RoutedEventArgs e)
        {
            Txt.Text = "Started...";

            var watch = Stopwatch.StartNew();
            long sum = await RunAsync();
            watch.Stop();

            var elapsed = watch.ElapsedMilliseconds;

            Txt.Text += "\nWorking time: " +
                elapsed + "\nSum = " + sum;
        }

        private async Task<long> RunAsync()
        {
            long sum = await Task.Run(() => count());
            return sum;
        }

        private long count()
        {
            long sum = 0;

            for (long i = 0; i < 400000000; i++)
                sum += i;

            //Dispatcher.Invoke(() => showThreadID(sum));
            return sum;
        }

        private void Threaded_Click(object sender, RoutedEventArgs e)
        {
            Txt.Text = "Started...";
            long sum = 0;
            long elapsed = 0;

            Thread thread = new Thread(() => {
                var watch = Stopwatch.StartNew();
                countThread(out sum);
                watch.Stop();
                elapsed = watch.ElapsedMilliseconds;
                show(sum, elapsed);
            });
            thread.Start();
        }

        private void show(long sum, long elapsed)
        {
            Dispatcher.Invoke(() => {
                Txt.Text += "\nWorking time: " +
                elapsed + "\nSum = " + sum;
            });

        }

        private void countThread(out long sum)
        {
            sum = 0;
            for (long i = 0; i < 400000000; i++)
            {
                sum += i;
            }
        }

    }
}
