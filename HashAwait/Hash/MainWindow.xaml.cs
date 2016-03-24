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
using System.Security.Cryptography;
using System.Threading;
using System.IO;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;

namespace Hash
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> algos = new List<string>();
        enum HashAlgos {MD5, RIPEMD160, SHA1, SHA256, SHA384, SHA512};
        string algoritmAles;
        HashAlgorithm ha;
        public MainWindow()
        {
            InitializeComponent();
            algos.Add("MD5");
            algos.Add("RIPEMD160");
            algos.Add("SHA1");
            algos.Add("SHA1");
            algos.Add("SHA256");
            algos.Add("SHA384");
            algos.Add("SHA512");
            //foreach (var alg in algos)
            //    this.comboAlgos.Items.Add(alg);
            string[] algorithms = Enum.GetNames(typeof(HashAlgos));
            foreach(var a in algorithms)
                this.comboAlgos.Items.Add(a);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            string filename;
            bool? ret = ofd.ShowDialog(this);
            if (ret.HasValue && ret == true)
            {
                filename = ofd.FileName;
                this.txtFile.Text = filename;
            }
        }

        private void comboAlgos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            algoritmAles = comboAlgos.SelectedItem.ToString();
            Debug.Write("Algoritm ales " + algoritmAles);
            btnComputeHash.IsEnabled = true;
        }

        private async void btnComputeHash_Click(object sender, RoutedEventArgs e)
        {
            switch (algoritmAles)
            {
                case "MD5":
                    ha = MD5CryptoServiceProvider.Create();
                    break;
                case "RIPEMD160":
                    ha = RIPEMD160Managed.Create();
                    break;
                case "SHA1":
                    ha = SHA1Managed.Create();
                    break;
                case "SHA256":
                    ha = SHA256Managed.Create();
                    break;
                case "SHA384":
                    ha = SHA384Managed.Create();
                    break;
                case "SHA512":
                    ha = SHA512Managed.Create();
                    break;
            }

            string hash = await ComputeHashAsync(ha, this.txtFile.Text);
            this.lblHash.Content = "Hash value " + hash;


            // Func<HashAlgorithm, string, string>  h = ComputeHash2;
            // IAsyncResult iar = h.BeginInvoke(ha, this.txtFile.Text, updateUI, null);
            
         
        }

        private void updateUI(IAsyncResult ar)
        {
            AsyncResult result = (AsyncResult)ar;
            
            var caller = (Func<HashAlgorithm, string, string>)result.AsyncDelegate;
            string hash = caller.EndInvoke(ar);
            Action update = () => this.lblHash.Content = hash;
            Dispatcher.BeginInvoke(update, null);
        }


        async Task<string> ComputeHashAsync(HashAlgorithm ha, string file)
        {
            var ret = Task.Run<string>(() =>
                {
                    byte[] hash = ha.ComputeHash(new FileStream(file, FileMode.Open, FileAccess.Read));
                    StringBuilder sb = new StringBuilder();
                    foreach (byte b in hash)
                        sb.Append(b.ToString("X2"));
                    return sb.ToString();
                });
            return await ret;
        }
        public static string ComputeHash2(HashAlgorithm ha, string file)
        {
            byte[] hash = ha.ComputeHash(new FileStream(file, FileMode.Open, FileAccess.Read));
            StringBuilder sb = new StringBuilder();
            foreach (byte b in hash)
                sb.Append(b.ToString("X2"));
            return sb.ToString();
        }
    }
}
