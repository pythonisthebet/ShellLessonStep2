using Microsoft.Extensions.Logging;
using ShellLessonStep2.Services;
using ShellLessonStep2.Views;

namespace ShellLessonStep2;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			})
			.RegisterDataServices()
            .RegisterPages()
            .RegisterViewModels()
			;

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
    public static MauiAppBuilder RegisterPages(this MauiAppBuilder builder)
    {
        //--------singleton Pages
        builder.Services.AddSingleton<>();
        builder.Services.AddSingleton<DogsView>();
        builder.Services.AddSingleton<MonkeysView>();
        builder.Services.AddSingleton<ElephantsView>();


        //--------Transient pages

        builder.Services.AddTransient<DetailsView>();

        return builder;
    }

    public static MauiAppBuilder RegisterDataServices(this MauiAppBuilder builder)
    {
        builder.Services.AddSingleton<AnimalService>();
        return builder;
    }
    public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder builder)
    {
        builder.Services.AddSingleton<CatsViewModel>();
        builder.Services.AddSingleton<DogsViewModel>();
        builder.Services.AddSingleton<MonkeysViewModel>();
        builder.Services.AddSingleton<ElephantsViewModel>();


        //--------Transient ViewModels
        builder.Services.AddTransient<DetailViewModel>();

        return builder;
    }
}
