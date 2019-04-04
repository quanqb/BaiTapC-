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

namespace testForm
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

        private void BtnGT_Click(object sender, RoutedEventArgs e)
        {
            int i, m = 1;
            int n = Int32.Parse(txtSoN.Text);
            for(i=1; i<= n; i++)
            {
                m = m * i;
            }
            txtKQ.Text = m.ToString();
        }

        private void BtnTC_Click(object sender, RoutedEventArgs e)
        {
            int n = Int32.Parse(txtSoN.Text);
            double tong = 0;
            for(int i=1; i<=n; i++)
            {
                tong += Math.Sqrt(i);
            }
            txtKQ.Text = tong.ToString();

        }

        private void BtnLT_Click(object sender, RoutedEventArgs e)
        {
            int n = Int32.Parse(txtSoN.Text);
            int m = Int32.Parse(txtCS.Text);
            txtKQ.Text = HamPow(m, n).ToString(); 

        }
        public static int HamPow(int num, int exp)
        {
            int ket_qua = 1;
            int i;
            for (i = 1; i <= exp; i++)
                ket_qua = ket_qua * num;
            return ket_qua;
        }

        private void BtnMIN_Click(object sender, RoutedEventArgs e)
        {
            string a = txtSoN.Text;

            
        }

        private void BtnMAX_Click(object sender, RoutedEventArgs e)
        {

        }
    }

}
