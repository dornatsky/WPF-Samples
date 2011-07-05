using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;
using System.ComponentModel;

namespace Threading
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.busy.Visibility = System.Windows.Visibility.Visible;
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork+=new DoWorkEventHandler(worker_DoWork);
            worker.RunWorkerAsync();
        }

        public void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(5000);
            Dispatcher.Invoke((Action)(()=> 
            {
                this.text.Text = "Text Retrieved";
                this.text.Visibility  = System.Windows.Visibility.Visible;
                this.busy.Visibility = System.Windows.Visibility.Collapsed;
            }));
        }
    }
}
