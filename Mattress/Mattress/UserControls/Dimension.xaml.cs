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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mattress.UserControls
{
    /// <summary>
    /// Interaction logic for Dimension.xaml
    /// </summary>
    public partial class Dimension : UserControl
    {
        public Dimension(int id)
        {
            InitializeComponent();
            this.DataContext = new DimensionVM(id);
        }
    }
}
