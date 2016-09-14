using Android.App;
using Android.OS;
using Android.Graphics;
using MvvmCross.Droid.Views;

using NewsReader.Model;

using OxyPlot.Xamarin.Android;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using NewsReader.ViewModels;
using Android.Views;
using MvvmCross.Binding.Droid.BindingContext;
using Java.Util;
using System;
using Java.Lang;
using System.Threading.Tasks;

namespace NewsReader.android.Views
{
    [Activity(Label = "News Reader- OXYPLOT")]
     
    public class FirstView : MvxActivity
    {
		//TODO: FIx UI bug where background is black and doesnt show the XY Coordinates

		public new FirstViewModel ViewModel
		{
			get { return (FirstViewModel)base.ViewModel; }
			set { base.ViewModel = value; }
		}

        protected override void OnViewModelSet()
        {
            base.OnViewModelSet();
            SetContentView(Resource.Layout.FirstViewOp);
            PlotView pv = this.FindViewById<PlotView>(Resource.Id.plotview);
            pv.SetBackgroundColor(Color.White);
             PollPlotModel();
            //set timer task
            
        }

        private async void PollPlotModel()
        {
            while (true)
            {
                 ViewModel.UpdatePlotModel();
                // Update the UI (because of async/await magic, this is still in the UI thread!)
                if (true)
                {
                    Android.Util.Log.Debug("Polling UI", "Polling UI");
                    await Task.Delay(TimeSpan.FromMilliseconds(1));
                    //await Task.Delay(TimeSpan.FromTicks(5000));
                }
            }
        }


    }
      
}
