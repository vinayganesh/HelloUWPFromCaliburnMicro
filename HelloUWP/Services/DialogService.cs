using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace HelloUWP.Services
{
    public class DialogService : IDialogService
    {
        public async void ShowDialog()
        {
            MessageDialog md = new MessageDialog("Hello UWP!");
            await md.ShowAsync();
        }
    }
}
