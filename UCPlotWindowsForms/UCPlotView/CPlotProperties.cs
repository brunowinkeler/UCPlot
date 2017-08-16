using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OxyPlot;
using OxyPlot.WindowsForms;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace UCPlotView
{
    class CPlotProperties
    {

        #region Attributes

        private UCPlotView parent;

        #endregion


        #region Constructors

        public CPlotProperties(UCPlotView p)
        {
            parent = p;
            parent.CPlotPGrid.SelectedObject = this;
        }

        #endregion


        #region Properties

        [Description("Graph's Title.")]
        [Category("Graph")]
        [DisplayName("Title")]
        public string Title
        {
            get { return parent.Title; }
            set { parent.Title = value; }
        }

        [Description("Graph's Subtitle")]
        [Category("Graph")]
        [DisplayName("Subtitle")]
        public string Subtitle
        {
            get { return parent.Subtitle; }
            set { parent.Subtitle = value; }
        }

        #endregion
        

        #region Public Methods



        #endregion


        #region Private Methods



        #endregion

    }
}
