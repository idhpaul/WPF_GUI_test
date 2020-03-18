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
    /// Page_Setting.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Page_Setting : Page
    {
        public Page_Setting()
        {
            InitializeComponent();
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            textblock_qvbrqulity.IsEnabled = true;
            textbox_qvbrqulity.IsEnabled = true;
        }


        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            textblock_qvbrqulity.IsEnabled = false;
            textbox_qvbrqulity.IsEnabled = false;

            textbox_qvbrqulity.Text = string.Empty;

            ComboBox a = sender as ComboBox;

            ComboBoxItem c = a.SelectedItem as ComboBoxItem;

            string selected_text = c.Name;

            if (selected_text == "ComboBoxItem_QVBR")
            {
                textblock_qvbrqulity.IsEnabled = true;
                textbox_qvbrqulity.IsEnabled = true;
            }

        }

        private void Textbox_qvbrqulity_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            //if (!System.Char.IsDigit((char)KeyInterop.VirtualKeyFromKey(e.Key)) & e.Key != Key.Back | e.Key == Key.Space | e.Key == Key.Tab)
            //{
            //    e.Handled = true;
            //    MessageBox.Show("숫자만 입력해주세요.", "오류", MessageBoxButton.OK, MessageBoxImage.Error);
            //}
        }

        private void Btn_setting_ok_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
