using System.Windows;

namespace Tutorial;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private bool _toggle = true;
    
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_OnClick(object sender, RoutedEventArgs e)
    {
        if (!_toggle)
        {
            Button.Content = "Okay, stop now.";
        }
        else
        {
            Button.Content = "HAHA, Nerd!!";
            _toggle = false;
        }
    }
}