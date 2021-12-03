using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IGT.UI.Client.UIModels
{
    /// <summary>
    /// double类型的Point
    /// </summary>
    struct PointD
    {
        public PointD(double x,double y)
        {
            _X= x;
            _Y = y;
        }

        public double X
        {
            get { return _X; }
            set { _X = value; }
        }

        public double Y
        {
            get { return _Y; }
            set { _Y = value; }
        }

        private double _X, _Y;
        public override string ToString()
        {
            return String.Format("{0},{1}", _X.ToString(), _Y.ToString());
        }
    }
}
