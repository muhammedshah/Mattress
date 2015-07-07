using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Mattress.Model
{
    [DataContract]
    public class DimensionModel
    {
        private double _length;

        [DataMember]
        public double Length
        {
            get { return _length; }
            set
            {
                _length = value;
            }
        }

        private double _width;

        [DataMember]
        public double Width
        {
            get { return _width; }
            set
            {
                _width = value;
            }
        }

        private double _thickness;

        [DataMember]
        public double Thickness
        {
            get { return _thickness; }
            set
            {
                _thickness = value;
            }
        }

        private double _density;

        [DataMember]
        public double Density
        {
            get { return _density; }
            set
            {
                _density = value;
            }
        }

        private double _weight;

        [DataMember]
        public double Weight
        {
            get { return _weight; }
            set
            {
                _weight = value;
            }
        }
    }
}
