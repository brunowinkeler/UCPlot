using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OxyPlot.WindowsForms;
using OxyPlot;
using OxyPlot.Series; 



namespace UCPlotView
{
    public partial class UCPlotView : UserControl
    {

        #region Atributos

        private CPlotProperties pptoolprop = null;

        #endregion


        #region Propriedades

        [Browsable(false)]
        public string Title
        {
            get { return cplotView.Model.Title; }
            set { if (value != cplotView.Model.Title) cplotView.Model.Title = value; cplotView.Model.InvalidatePlot(true); }
        }

        [Browsable(false)]
        public string Subtitle
        {
            get { return cplotView.Model.Subtitle; }
            set { if (value != cplotView.Model.Subtitle) cplotView.Model.Subtitle = value; cplotView.Model.InvalidatePlot(true); }
        }
        
        [Browsable(false)]
        public PropertyGrid CPlotPGrid
        {
            get { return cplotPGrid; }
        }

        #endregion


        public UCPlotView()
        {
            InitializeComponent();

            cplotView.Model = new PlotModel();

            pptoolprop = new CPlotProperties(this);

        }
    }
}
