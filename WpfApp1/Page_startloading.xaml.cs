using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;
using System.Diagnostics;

namespace WpfApp1
{
    /// <summary>
    /// Page_startloading.xaml에 대한 상호 작용 논리
    /// </summary>
    /// 
   
    public partial class Page_startloading : Page
    {

        private DispatcherTimer timer = null;
        private const double PROGRESS_MINIMUM = 0;
        private const double PROGRESS_MAXIMUM = 100;
        private const double PROGRESS_STEP = 4;

        private double progressValue = PROGRESS_MINIMUM;

        private void RunProcess(String FileName, String Args)
        {
            Process p = new Process();

            p.StartInfo.FileName = FileName;
            p.StartInfo.Arguments = Args;

            p.StartInfo.WindowStyle = ProcessWindowStyle.Normal;

            p.Start();

            p.WaitForExit();


            //return p.ExitCode;
        }

        public Page_startloading()
        {
            InitializeComponent();

            

            this.timer = new DispatcherTimer();

            this.timer.Interval = new TimeSpan(0, 0, 0, 0, 100);

            this.timer.Tick += timer_Tick;

            this.progressValue = PROGRESS_MINIMUM;

            this.timer.Start();

        }

        private void timer_Tick(object sender, EventArgs e)
        {

            this.progressValue += PROGRESS_STEP;


            if (this.progressValue > PROGRESS_MAXIMUM)
            {
                this.progressValue = PROGRESS_MINIMUM;

                this.timer.Stop();

                MessageBox.Show("TX 시작 완료", "정보", MessageBoxButton.OK, MessageBoxImage.Asterisk);

                RunProcess("C:\\Program Files\\Notepad++\\notepad++.exe", "");

                NavigationService.GoBack();

            }

            double fraction = (this.progressValue - PROGRESS_MINIMUM) / (PROGRESS_MAXIMUM - PROGRESS_MINIMUM);

            this.progressBackgroundLabel.Width = this.progressBorder.Width * fraction;
            this.progressLabel.Content = this.progressValue.ToString() + "%";

            //출처: https://icodebroker.tistory.com/5839 [ICODEBROKER]

        }


    }
}
