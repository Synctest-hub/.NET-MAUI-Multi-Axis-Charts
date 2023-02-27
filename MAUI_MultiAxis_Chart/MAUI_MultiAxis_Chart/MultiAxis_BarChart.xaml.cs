
namespace MAUI_MultiAxis_Chart
{
    public partial class MultiAxis_BarChart : ContentView
    {
        public MultiAxis_BarChart()
        {
            InitializeComponent();
        }

        private void yAxis1_LabelCreated(object sender, Syncfusion.Maui.Charts.ChartAxisLabelEventArgs e)
        {
            e.Label = Math.Abs(Convert.ToDouble(e.Label)).ToString()+"%";
        }
    }
}