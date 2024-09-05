using System.Windows;

namespace WpfApp1;


public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void ButtonSave_OnClick(object sender, RoutedEventArgs e)
    {
        MessageBox.Show(
            caption: "Результат сохранения",
            messageBoxText: $"{InputName.Text} {InputAge.Text}");
    }

    private void ButtonClear_OnClick(object sender, RoutedEventArgs e)
    {
        InputName.Clear();
        InputAge.Clear();
    }
}