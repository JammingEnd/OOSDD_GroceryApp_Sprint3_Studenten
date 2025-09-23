using CommunityToolkit.Mvvm.ComponentModel;
using Grocery.Core.Services;

namespace Grocery.App.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        string title = "";

        public virtual void Load() { }
        public virtual void OnAppearing() { }
        public virtual void OnDisappearing() { }

    }
}
