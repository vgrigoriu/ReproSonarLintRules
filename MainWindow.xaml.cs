using System;
using System.Windows;

namespace ReproSonarLintRules
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TextBox2.XPressed += MyTextBox_OnXPressed2;
        }

        private void MyTextBox_OnXPressed1(object sender, RoutedEventArgs routedEventArgs)
        {
            MessageBox.Show("X was pressed");
        }

        private void MyTextBox_OnXPressed2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("X was pressed");
        }
    }
}
