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
using System.Data;

namespace firtsTry
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

        private void btnInvia_Click(object sender, RoutedEventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("name");
            table.Columns.Add("surname");
            table.Rows.Add("claudio", "conte");
            dgData.ItemsSource = table.DefaultView;
        }
    }
}
