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
using Microsoft.Win32;
using System.IO;
using System.Security.Cryptography;
using System.Threading;
using System.Diagnostics;

namespace Hash3
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

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            string[] algos = {"MD5", "SHA1", "SHA256", "SHA384", "SHA512"};
            foreach (string item in algos)
            {
                cmbAlgos.Items.Add(item);
            }
            cmbAlgos.SelectedIndex = 0;
        }

        private void btnFileName_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.CurrentDirectory;
            
            bool? result = ofd.ShowDialog();
            if (result == true)
            {
                this.txtFileName.Text = ofd.FileName;
            }
        }

        private void btnCompute_Click(object sender, RoutedEventArgs e)
        {
            HashAlgorithm hAlgo = HashAlgorithm.Create(cmbAlgos.SelectedItem.ToString());

            Thread t = new Thread(CalculHash);

            Tuple<string, HashAlgorithm> tuple = 
                new Tuple<string, HashAlgorithm>(this.txtFileName.Text, hAlgo);

            t.Start(tuple);


            
        }

        void CalculHash(object obj)
        {
            FileStream fs = null;
            Tuple<string, HashAlgorithm> tuple = (Tuple<string, HashAlgorithm>)obj;
            try
            {
                fs = new FileStream(tuple.Item1, FileMode.Open, FileAccess.Read);


                byte[] hash = tuple.Item2.ComputeHash(fs);

                StringBuilder sb = new StringBuilder();
                foreach (byte item in hash)
                {
                    sb.AppendFormat("{0:X2}", item);
                }
                this.Dispatcher.Invoke(() => {this.lblHashValue.Content = sb.ToString();});
                
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Numele fisierului nu e bun", "Eroare", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Fisierul nu exista", "Eroare", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("Ooops!", "Eroare", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                if (fs != null)
                    fs.Close();
            }
        }
    }
}
