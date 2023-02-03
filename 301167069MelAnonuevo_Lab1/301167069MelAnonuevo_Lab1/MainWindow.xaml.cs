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

namespace _301167069MelAnonuevo_Lab1
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

        private void creatBtn_Click(object sender, RoutedEventArgs e)
        {
            Create createWindow = new Create();
            Visibility = Visibility.Hidden;
            createWindow.Show();
        }

        private void OLOBtn_Click(object sender, RoutedEventArgs e)
        {
            ObjectLevelOperations objectLevelOperationsWindow = new ObjectLevelOperations();
            Visibility = Visibility.Hidden;
            objectLevelOperationsWindow.Show();
        }

        private void exitBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
