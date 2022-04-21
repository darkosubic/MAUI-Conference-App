using ConferenceApp.Services;

namespace ConferenceApp;

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
				fonts.AddFont("Roboto-Black.ttf", "RobotoBlack");
				fonts.AddFont("Roboto-BlackItalic.ttf", "RobotoBlackItalic");
				fonts.AddFont("Roboto-Bold.ttf", "RobotoBold");
			});
		
		builder.Services.AddSingleton<AppShell>();

		return builder.Build();
	}
}
