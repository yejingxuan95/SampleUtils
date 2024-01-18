using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SampleUtils
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

        ActionWorker actionWorker;
        private void test_Click(object sender, RoutedEventArgs e)
        {
            actionWorker = new ActionWorker();
        }

        private void test_Click_1(object sender, RoutedEventArgs e)
        {
            actionWorker.Add(new Action(Log));
        }
        public void Log()
        {
            Console.WriteLine($"{DateTime.Now.ToString("yyyy-MM-dd HH24:mm:ss:ffff")} 日志");
        }
    }
}