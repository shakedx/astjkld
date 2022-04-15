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

namespace astjkld
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Child sebek = new Child(double.Parse(chislox.Text), double.Parse(chisloy.Text), double.Parse(chisloz.Text), double.Parse(chisloa.Text), double.Parse(chislob.Text), double.Parse(chisloc.Text));
            Result.Text = $"{sebek.action()}";
        }
    }
}
