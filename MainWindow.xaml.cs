using System.Windows;
using System.Windows.Controls;

namespace Bug001;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void RunButton_Click(object sender, RoutedEventArgs e) => new MenuItem() { Header = string.Empty };
}