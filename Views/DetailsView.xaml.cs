namespace CollectionViewMVVM.Views;

public partial class MonkeyDetailsView : ContentPage
{
	public MonkeyDetailsView(ViewModels.DetailViewModel vm)
	{
		InitializeComponent();
		this.BindingContext = vm;
	}
}