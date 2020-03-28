using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

namespace WpfApp1
{
    /// <summary>
    /// Page_Main.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Page_Main : Page
    {

        string hostname = null;
        IPAddress[] ips;


        public Page_Main()
        {
            InitializeComponent();

            // Init IP Addr
            hostname = Dns.GetHostName();
            ips = Dns.GetHostAddresses(hostname);

            foreach(IPAddress ip in ips)
            {

                GroupBox groupbox = new GroupBox();
                groupbox.Header = "Network IP Address";
                groupbox.Content = ip.ToString();

                page_main_combobox_ip.Items.Add(groupbox);
            }

        }


        private void Btn_main_txsetting_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
            else
            {
                Page_Setting page = new Page_Setting();

                page.Title = "TX Setting";

                NavigationService.Navigate(page);
            }
        }

        private void Btn_main_start_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("시작 버튼 눌림", "정보", MessageBoxButton.OK, MessageBoxImage.Asterisk);

            Page_startloading page = new Page_startloading();

            page.Title = "TX start loading";

            NavigationService.Navigate(page);
        }

        private void Btn_main_stop_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("정지 버튼 눌림", "정보", MessageBoxButton.OK, MessageBoxImage.Asterisk);
        }
    }
}
