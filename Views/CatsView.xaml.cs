using ShellLessonStep2.ViewModels;

namespace ShellLessonStep2.Views;

public partial class CatsView : ContentPage
{
	public CatsView(AnimalViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}