using ShellLessonStep2.ViewModels;

namespace ShellLessonStep2.Views;

public partial class ElephantsView : ContentPage
{
	public ElephantsView(AnimalViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}