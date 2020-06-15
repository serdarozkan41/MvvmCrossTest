using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace TipCalc.Core.ViewModels
{
    public class InformationViewModel : MvxViewModel
    {
        private IMvxNavigationService _navigator;

        public InformationViewModel(IMvxNavigationService navigator)
        {

            _navigator = navigator;
        }

        public IMvxCommand GoBack
        {
            get
            {
                return new MvxCommand(async () =>
                {
                    await _navigator.Close(this);
                });
            }
        }
    }
}
