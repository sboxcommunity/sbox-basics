using Sandbox;
using Sandbox.UI;

namespace MyFirstGame.UI
{
	public partial class Hud : HudEntity<RootPanel>
	{
		public Hud()
		{
			if ( !IsClient )
				return;

			// Option 1: HTML
			// RootPanel.SetTemplate( "UI/Hud.html" );

			// Option 2: C#
			RootPanel.StyleSheet.Load( "UI/Style.scss" );
			var myLabel = RootPanel.AddChild<Label>();
			myLabel.Text = "My First Game";
			// myLabel.Style.BackgroundColor = Color.Red;
		}
	}
}
