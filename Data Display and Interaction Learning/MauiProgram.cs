using Microsoft.Extensions.Logging;
using Microsoft.Maui;

namespace Data_Display_and_Interaction_Learning;

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
			}); 
		
		

#if DEBUG
		builder.Logging.AddDebug();
#endif
		


		return builder.Build();
	}
}
