using BucketOps;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace _301167069MelAnonuevo_Lab1
{
    /// <summary>
    /// Interaction logic for Create.xaml
    /// </summary>
    public partial class Create : Window
    {
        ObservableCollection<Bucket> buckets = new ObservableCollection<Bucket>();
        public Create()
        {
            InitializeComponent();
        }

        private async Task GetBucketList()
        {
            await Task.Run(() =>
            {
                buckets = Helper.GetBucketList().Result;
            });

            BucketGrid.ItemsSource= buckets;    
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            await GetBucketList();
        }

        private async void createBucketBtn_Click(object sender, RoutedEventArgs e)
        {
            string bucketName = BucketNameTextBox.Text;
            errorContentBox.Text = "";
            if (string.IsNullOrWhiteSpace(bucketName) || bucketName.Any(char.IsUpper))
            {
                errorContentBox.Text = "Bucket Name must not contain uppercase characters and white spaces";
                return;
            }

            await Task.Run(() =>
            {
                string response = Helper.CreateBucket(bucketName).Result;

                if (response.Contains("Invalid"))
                {
                    Dispatcher.Invoke(() =>
                    {
                        errorContentBox.Text = "Bucket name is invalid, it shoud be globally unique";
                        return;
                    });

                }
                buckets = Helper.GetBucketList().Result;
            });

            BucketGrid.ItemsSource = buckets;
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            //Close();
            MainWindow mainWindow = new MainWindow();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }
    }
}
