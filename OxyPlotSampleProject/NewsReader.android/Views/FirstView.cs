using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

using NewsReader.Model;

using OxyPlot.Xamarin.Android;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using NewsReader.ViewModels;
using Android.Views;
using MvvmCross.Binding.Droid.BindingContext;

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

		}


    }
}
