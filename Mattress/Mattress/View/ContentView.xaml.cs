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
        public ContentView()
        {
            InitializeComponent();
            
        }

        public ContentView(string itemName)
        {
            InitializeComponent();
            this.DataContext = new ContentVM(itemName);
        }
    }
}
