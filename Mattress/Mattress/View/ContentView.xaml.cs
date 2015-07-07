using Mattress.Model;
using Mattress.UserControls;
using Mattress.ViewModel;
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
using System.Windows.Shapes;

namespace Mattress.View
{
    /// <summary>
    /// Interaction logic for ContentView.xaml
    /// </summary>
    public partial class ContentView : Window
    {

        DashboardItem _dashboardItem = null;
        public ContentView()
        {
            InitializeComponent();
            
        }

        public ContentView(DashboardItem dashboardItem)
        {
            InitializeComponent();
            _dashboardItem = dashboardItem;
            this.DataContext = new ContentVM(dashboardItem.Name);
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            ContentPanal.Children.Clear();
            Dimension dimension = new Dimension(_dashboardItem.Id);
            ContentPanal.Children.Add(dimension);
        }
    }
}
