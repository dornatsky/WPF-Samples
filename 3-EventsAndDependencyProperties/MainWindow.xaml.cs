using System.Diagnostics;
using System.Windows;
using System.Windows.Input;

namespace EventsAndDependencyProperties
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

        private void innerButton_Click(object sender, RoutedEventArgs e)
        {
            Trace.WriteLine("inner button click");
        }

        private void intermediateButton_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Trace.WriteLine("intermediate button preview mouse down");
        }

        private void outerButton_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Trace.WriteLine("outer button preview mouse down");
        }

        private void intermediateButton_Click(object sender, RoutedEventArgs e)
        {
            Trace.WriteLine("intermediate button click");
        }

        private void outerButton_Click(object sender, RoutedEventArgs e)
        {
            Trace.WriteLine("intermediate button click");
        }
    }
}
