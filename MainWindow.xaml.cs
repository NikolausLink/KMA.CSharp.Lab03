using System.Windows;

namespace MoshchytskyiSharp02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new PersonRegisterViewModel(this);
        }
    }
}
