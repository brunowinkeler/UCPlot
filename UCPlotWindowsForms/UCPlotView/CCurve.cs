using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using OxyPlot;

namespace UCPlotView
{

    public enum CurveType { Scatter, Line }

    public class CCurve
    {

        #region Attributes

        private UCPlotView parent;

        private List<DataPoint> data = null;
        
        private Color col;
        private double thickness;
        private string legend;
        private LineStyle linestyle;
        private MarkerType markertype;
        private bool visible;
        private CurveType type;

        #endregion

        public CCurve()
        { 
            
        
        }

    }
}
