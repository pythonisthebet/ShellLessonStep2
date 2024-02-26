namespace ShellLessonStep2.Views;

public partial class Page3 : ContentPage
{
	public Page3()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync("modalPage");
    }
}