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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Type comType = Type.GetTypeFromProgID("ClassLibrary1.Class1");
            if (comType == null)
            {
                Console.WriteLine("COM 타입을 찾을 수 없습니다.");
                return;
            }

            dynamic comObject = Activator.CreateInstance(comType);
            if (comObject == null)
            {
                Console.WriteLine("COM 객체를 생성할 수 없습니다.");
                return;
            }

            var content = comObject.test();
            Console.WriteLine(content);
        }
    }
}