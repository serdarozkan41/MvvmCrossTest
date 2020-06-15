using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Views;
using TipCalc.Core.ViewModels;
using UIKit;

namespace TipCalc.iOS
{
    public partial class InformationView : MvxViewController<InformationViewModel>
    {
        public InformationView() : base(nameof(InformationView), null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<InformationView, InformationViewModel>();
            set.Bind(GoBack).To(vm => vm.GoBack);
            set.Apply();
        }
    }
}