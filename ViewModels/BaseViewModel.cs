using CommunityToolkit.Mvvm.ComponentModel;

namespace lab2.ViewModels
{
    // This partial class inherits from ObservableObject, which implements
    // INotifyPropertyChanged and INotifyPropertyChanging.
    public partial class BaseViewModel : ObservableObject
    {
        // Use the [ObservableProperty] attribute to create an observable
        // property. The toolkit will generate a private field and a
        // public property with the correct change notifications.
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotBusy))] // Notify that IsNotBusy changes when IsBusy changes
        bool isBusy;

        [ObservableProperty]
        string title;

        // This is a helper property that can be used for things like
        // disabling buttons while an operation is running.
        public bool IsNotBusy => !IsBusy;
    }
}