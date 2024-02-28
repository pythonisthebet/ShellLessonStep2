namespace ShellLessonStep2.Views;

public partial class DetailsView : ContentPage
{
	public DetailsView(ViewModels.DetailViewModel vm)
	{
		InitializeComponent();
		this.BindingContext = vm;
	}
}