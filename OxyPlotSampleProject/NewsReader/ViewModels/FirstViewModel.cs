 using MvvmCross.Core.ViewModels;
using NewsReader.Model;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace NewsReader.ViewModels
{
    public class FirstViewModel 
        : MvxViewModel
    {

        public FirstViewModel()
        {
            //update model every x interval
            CreatePlotModel();

        }
        //some properties and Commands
        private PlotModel plotModel;
        private IMvxCommand _listViewBtnClicked;
        public IMvxCommand ListViewBtnClicked
        {
            get
            {
                _listViewBtnClicked = _listViewBtnClicked ?? new MvxCommand(btnClick);

                return _listViewBtnClicked;
            }

        }


        private void btnClick()
        {
            //Do Something    
        }



        public PlotModel PlotModel
		{
			get { return plotModel; }
            set {
                plotModel = value;
                RaisePropertyChanged(() => PlotModel);
            }


		}

		//
		//create oxyplot model from properties
		private PlotModel CreatePlotModel()
		{
            

            plotModel = new PlotModel { Title = "OxyPlot Demo" };

			plotModel.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom });
			plotModel.Axes.Add(new LinearAxis { Position = AxisPosition.Left, Maximum = 10, Minimum = 0 });

            var series1 = new LineSeries
            {
                MarkerType = MarkerType.Circle,
                MarkerSize = 4,
                MarkerStroke = OxyColors.White
                 
			};
            //line series background
            //series1.Background = Color.White


			series1.Points.Add(new DataPoint(0.0, 6.0));
			series1.Points.Add(new DataPoint(1.4, 2.1));
			series1.Points.Add(new DataPoint(2.0, 4.2));
			series1.Points.Add(new DataPoint(3.3, 2.3));
			series1.Points.Add(new DataPoint(4.7, 7.4));
			series1.Points.Add(new DataPoint(6.0, 6.2));
			series1.Points.Add(new DataPoint(8.9, 8.9));

			plotModel.Series.Add(series1);

			return plotModel;
		}
         
        public async void UpdatePlotModel()
        {
            Debug.WriteLine("UpdatePlotModel");
             
            var series1 = new LineSeries
            {
                MarkerType = MarkerType.Circle,
                MarkerSize = 4,
                MarkerStroke = OxyColors.White

            };
            //line series background
            //series1.Background = Color.White

            //
            plotModel.Series.Clear();
            
            series1.Points.Add(new DataPoint(randDouble(), randDouble()));

            series1.Points.Add(new DataPoint(randDouble(), randDouble()));
            series1.Points.Add(new DataPoint(randDouble(), randDouble()));
            series1.Points.Add(new DataPoint(randDouble(), randDouble()));
            series1.Points.Add(new DataPoint(randDouble(), randDouble()));
            series1.Points.Add(new DataPoint(randDouble(), randDouble()));
            series1.Points.Add(new DataPoint(randDouble(), randDouble()));
            plotModel.InvalidatePlot(true);
            plotModel.Series.Add(series1);

            //return plotModel;
        }

        //create random doubles
        private Double randDouble() {
            Double dbl;
            Random rnd = new Random();
            int ranInt = rnd.Next(1, 13);
            dbl = ranInt;
            return dbl;
        }
    }
}
