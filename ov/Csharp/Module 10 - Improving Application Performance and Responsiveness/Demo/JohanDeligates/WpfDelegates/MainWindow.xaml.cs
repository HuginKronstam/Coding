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

namespace WpfDelegates
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
            Task.Run(() =>
                {
                lbl.Dispatcher.BeginInvoke(new Action(() => SetLabel("Du er en modig mand")));
                
                });
        }
        public void SetLabel(string s)
        {
            lbl.Content = s;
        }

        
        public void SetContent(string s)
        {
            button.Content = s;
        }


        private void Button_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            Task.Run(() =>
            {
                button.Dispatcher.BeginInvoke(new Action(() => SetContent("Tør du?")));

            });
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Task.Run(() =>
            {
                button.Dispatcher.BeginInvoke(new Action(() => SetContent("Er du sikker?")));

            });
        }
    }
}
