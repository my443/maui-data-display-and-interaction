using System.Collections.ObjectModel;

namespace Data_Display_and_Interaction_Learning;

public partial class App : Application
{
	public ObservableCollection<Datarow> Items { get; set; }

	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();

		Items = new ObservableCollection<Datarow>();


		// Populate the list
		for (int i = 0; i < 150; i++) { 
			string i_string = Convert.ToString(i);
			Datarow row = new Datarow(i_string, i_string);
			Items.Add(row);
		}

		BindingContext = this;
	}

	protected override Window CreateWindow(IActivationState activationState)
	{
		var window = base.CreateWindow(activationState);
		if (window != null)
		{
			window.Title = "Org Chart";
		}

		return window;
	}
}
