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

namespace WpfApp1
{
    /// <summary>
    /// Page_Main.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Page_Main : Page
    {
        public Page_Main()
        {
            InitializeComponent();
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
    }
}
