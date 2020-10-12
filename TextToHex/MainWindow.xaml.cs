using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace TextToHex
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

        private void English_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender is TextBox txtBox)
            {
                var n = from t in txtBox.Text
                        select ((int)t).ToString("X2");
                HexBox.Text = string.Join(" ", n);
            }
        }
    }
}
