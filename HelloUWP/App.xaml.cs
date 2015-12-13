using Caliburn.Micro;
using HelloUWP.Services;
using HelloUWP.ViewModels;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml.Navigation;

namespace HelloUWP
{
    sealed partial class App
    {
        private WinRTContainer _container;
        
        public App()
        {
            InitializeComponent();
        }

        protected override void Configure()
        {
            _container = new WinRTContainer();
            _container.RegisterWinRTServices();

            _container.PerRequest<MainPageViewModel>();
            _container.Singleton<IDialogService, DialogService>();
        }

        protected override void OnLaunched(LaunchActivatedEventArgs e)
        {
            DisplayRootViewFor<MainPageViewModel>();
        }

        void OnNavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            throw new Exception("Failed to load Page " + e.SourcePageType.FullName);
        }

        protected override object GetInstance(Type service, string key)
        {
            return _container.GetInstance(service, key);
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return _container.GetAllInstances(service);
        }

        protected override void BuildUp(object instance)
        {
            _container.BuildUp(instance);
        }
    }
}
