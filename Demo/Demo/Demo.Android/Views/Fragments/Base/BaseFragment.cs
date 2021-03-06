using Android.OS;
using Android.Views;
using Android.Widget;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Support.V4;

namespace Demo.Android.Views
{
    public abstract class BaseFragment<TViewModel> : MvxFragment<TViewModel>
        where TViewModel : class, IMvxViewModel
    {
        protected abstract int FragmentLayoutId { get; }
        protected abstract string ToolbarText { get; }

        TextView _toolbarTextView;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            // If your bindings are done in XML rather than codebehind, you need to call this.BindingInflate. If not, call inflater.Inflate instead
            var view = inflater.Inflate(FragmentLayoutId, null);

            _toolbarTextView = Activity.FindViewById<TextView>(Resource.Id.textview_toolbar_title);

            _toolbarTextView.Text = ToolbarText;

            return view;
        }
    }
}
