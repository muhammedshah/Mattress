using Mattress.Common;
using Mattress.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mattress.ViewModel
{
    public  class DimensionVM : BaseViewModel
    {

        public DimensionVM(int id)
        {
            LoadDimensions(id);
        }

        private double _length;

        public double Length
        {
            get { return _length; }
            set { _length = value;
            OnPropertyChanged("Length");
            }
        }

        private double _width;

        public double Width
        {
            get { return _width; }
            set { _width = value;
            OnPropertyChanged("Width");
            }
        }

        private double _thickness;

        public double Thickness
        {
            get { return _thickness; }
            set { _thickness = value;
            OnPropertyChanged("Thickness");
            }
        }

        private double _density;

        public double Density
        {
            get { return _density; }
            set { _density = value;
            OnPropertyChanged("Density");
            }
        }

        private double _weight;

        public double Weight
        {
            get { return _weight; }
            set { _weight = value;
            OnPropertyChanged("Weight");
            }
        }


        public RelayCommand SaveDimensionsCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    this.SaveDimensions();
                });

            }


        }
      

        public async void SaveDimensions()
        {
            DimensionModel dimensionModel = new DimensionModel()
            {
                Density = this.Density,
                Length = this.Length,
                Weight = this.Weight,
                Width = this.Width,
                Thickness = this.Thickness
            };
            string requestUrl = "http://10.6.0.133/api/Test";
            ServiceHandler serviceHandler = new ServiceHandler();
            string jsonContent = JsonConvert.SerializeObject(dimensionModel);
            string result = await serviceHandler.PostRequest(requestUrl, jsonContent);
            //BaseResponse addGroupResponse = (BaseResponse)JsonConvert.DeserializeObject(result, typeof(BaseResponse));
           
        }

        public async void LoadDimensions(int id)
        {

            string requestUrl = "http://10.6.0.133/api/Test?id=" + id;
            ServiceHandler serviceHandler = new ServiceHandler();
            string result = await serviceHandler.RequestData(requestUrl);
            //DimensionModel dimensionModel = (DimensionModel)JsonConvert.DeserializeObject(result, typeof(DimensionModel));
            DimensionModel dimensionModel = new DimensionModel()
            {
                Density = 100,
                Length = 123,
                Weight = 12,
                Width = 33,
                Thickness = 3
            };

             this.Density = dimensionModel.Density;
             this.Length = dimensionModel.Length;
             this.Weight = dimensionModel.Weight;
             this.Width = dimensionModel.Width;
             this.Thickness = dimensionModel.Thickness;

        }
        
        
        
    }
}
