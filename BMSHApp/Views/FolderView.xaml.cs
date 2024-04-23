using AndroidX.CardView.Widget;
using CommunityToolkit.Maui;

namespace BMSHApp.Views;

public partial class FolderView : ContentView
{
	public FolderView()
	{
		InitializeComponent();
	}

    #region MyRegion
    public static readonly BindableProperty CardTitleProperty = BindableProperty.Create(nameof(CardTitle), typeof(string), typeof(CardView), string.Empty);

    public string CardTitle
    {
        get => (string)GetValue(FolderView.CardTitleProperty);
        set => SetValue(FolderView.CardTitleProperty, value);
    }
    #endregion
}