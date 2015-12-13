using Caliburn.Micro;
using HelloUWP.Services;

namespace HelloUWP.ViewModels
{
    public class MainPageViewModel: Screen
    {
        IDialogService _dialogService;

        public MainPageViewModel(IDialogService dialogService)
        {
            _dialogService = dialogService;
        }

        protected override void OnInitialize()
        {
            _dialogService.ShowDialog();
        }
    }
}
