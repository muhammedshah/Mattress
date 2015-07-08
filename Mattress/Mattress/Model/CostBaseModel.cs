using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mattress.Model
{
    public class CostBaseModel
    {
        private int _id;

        public int Id  
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _rowMeterial;

        public string RowMeterial
        {
            get { return _rowMeterial; }
            set { _rowMeterial = value; }
        }

        private decimal _percent;

        public decimal Percent
        {
            get { return _percent; }
            set { _percent = value; }
        }


        private double _weight;

        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        
        
        
        
    }
}
