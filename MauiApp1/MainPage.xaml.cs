namespace MauiApp1
{
	public partial class MainPage : ContentPage
	{

		public MainPage()
		{
			InitializeComponent();
		}

		private void Switch1_Toggled(object sender, ToggledEventArgs e)
		{
			if(Switch1.IsToggled)
				Switch1.ThumbColor = Colors.Blue;
			else
				Switch1.ThumbColor = Colors.Red;
		}
	}

}
