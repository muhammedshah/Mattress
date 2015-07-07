using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mattress.ViewModel
{
    public class ContentVM : BaseViewModel
    {

        public ContentVM(string dashboardItemName)
        {
            DashboardItemName = dashboardItemName;
        }

        private string _dashboardItemName;

        public string DashboardItemName
        {
            get { return _dashboardItemName; }
            set
            {
                _dashboardItemName = value;
                OnPropertyChanged("DashboardItemName");
            }
        }
    }
}
