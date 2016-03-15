using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ReproSonarLintRules
{
    /// <summary>
    /// Interaction logic for MyTextBox.xaml
    /// </summary>
    public partial class MyTextBox
    {
        public MyTextBox()
        {
            InitializeComponent();
        }

        public static readonly RoutedEvent XPressedEvent = EventManager.RegisterRoutedEvent(
            nameof(XPressed),
            RoutingStrategy.Bubble,
            typeof(RoutedEventHandler),
            typeof(MyTextBox));

        public event RoutedEventHandler XPressed
        {
            add { AddHandler(XPressedEvent, value); }
            remove { RemoveHandler(XPressedEvent, value); }
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            if (e.Key == Key.X)
            {
                RaiseEvent(new RoutedEventArgs(XPressedEvent));
            }

            base.OnKeyUp(e);
        }
    }
}
