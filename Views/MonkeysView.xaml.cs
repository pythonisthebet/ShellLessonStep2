using ShellLessonStep2.ViewModels;

namespace ShellLessonStep2.Views;

public partial class MonkeysView : ContentPage
{
	public MonkeysView(AnimalViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync("modalPage");
    }
}