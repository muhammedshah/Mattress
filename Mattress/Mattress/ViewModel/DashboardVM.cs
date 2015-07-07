using Mattress.Common;
using Mattress.Model;
using Mattress.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mattress.ViewModel
{
    public class DashboardVM : BaseViewModel
    {
        public DashboardVM()
        {
            DashboardItems = TakeDashboardItems();
        }

        private List<DashboardItem> _dashboardItems;

        public List<DashboardItem> DashboardItems
        {
            get { return _dashboardItems; }
            set
            {
                _dashboardItems = value;
                OnPropertyChanged("DashboardItems");
            }
        }

        private DashboardItem _selectedDashboardItem;

        public DashboardItem SelectedDashboardItem
        {
            get { return _selectedDashboardItem; }
            set
            {
                _selectedDashboardItem = value;
                OnPropertyChanged("SelectedDashboardItem");
            }
        }

        private List<DashboardItem> TakeDashboardItems()
        {
            List<DashboardItem> dashboardItems = new List<DashboardItem>();
            for (int i = 1; i < 11; i++)
            {
                DashboardItem dashboardItem1 = new Model.DashboardItem()
                    {
                        Id = i,
                        Name = "Silk Plain" + i,
                        CreatedDate = DateTime.Now,
                        Description = "Silk Plain" + i + "Silk Plain"
                    };

                dashboardItems.Add(dashboardItem1);
            }

            return dashboardItems;
        }




        public RelayCommand DashboardItemCommand  
        {
            get
            {
                return new RelayCommand(() =>
                    {
                        ContentView contentView = new ContentView(SelectedDashboardItem.Name);
                        contentView.ShowDialog();
                    });

            }


        }
    }
}
