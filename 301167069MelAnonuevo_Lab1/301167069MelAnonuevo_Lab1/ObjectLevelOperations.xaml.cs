using BucketOps;
using Microsoft.Win32;
using ObjectLevelOps;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Sockets;
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
    /// Interaction logic for ObjectLevelOperations.xaml
    /// </summary>
    public partial class ObjectLevelOperations : Window
    {
        ObservableCollection<Bucket> buckets = new ObservableCollection<Bucket>();
        ObservableCollection<BucketObject> objects = new ObservableCollection<BucketObject>();

        string selectedBucketName;
        public ObjectLevelOperations()
        {
            InitializeComponent();
            DataContext= this;
        }
        private async Task GetBucketList()
        {
            await Task.Run(() =>
            {
                buckets = Helper.GetBucketList().Result;
            });

            List<string> bucketNames = new List<string>();

            foreach (Bucket bucket in buckets)
            {
                bucketNames.Add(bucket.Name);
            }

            BucketListCombobox.ItemsSource = bucketNames;
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            await GetBucketList();
        }

        private void Function_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cmb = sender as ComboBox;
            selectedBucketName = (string)cmb.SelectedValue;
            DisplayObjects(selectedBucketName);

        }

        private void browseBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == true)
            {
                //Get the path of specified file
                objectTextBox.Text = openFileDialog.FileName;
            }
        }

        private async void uploadBtn_Click(object sender, RoutedEventArgs e)
        {
            string filePath = objectTextBox.Text;
            if (!String.IsNullOrEmpty(selectedBucketName) && !String.IsNullOrEmpty(filePath))
            {
                await Task.Run(() =>
                {
                    string result = ObjectLevelOpsHelper.UploadObject(filePath, selectedBucketName).Result;
                    DisplayObjects(selectedBucketName);
                });

                objectTextBox.Clear();

            }
            else
            {
                MessageBox.Show("File name is supposed to be unique");
            }
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            // Close();
            MainWindow mainWindow = new MainWindow();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }

        private async void DisplayObjects(string bucketName)
        {

            await Task.Run(() =>
            {

                //Retrieve a File from Your Amazon S3 Bucket
                objects = ObjectLevelOpsHelper.GetObjectsFromBucket(selectedBucketName).Result;
                Dispatcher.Invoke(() =>
                {
                    ObjectsGrid.ItemsSource = objects;
                });
            });

        }
    }
}
