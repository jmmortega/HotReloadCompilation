using CommunityToolkit.Maui.Views;

namespace HotReloadCompilation;


public partial class ChildPage : ContentPage
{
    int count = 0;

    public ChildPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        Popup popup = new Popup();
        popup.Content = new ChildView();

        this.ShowPopupAsync(popup);
    }
}