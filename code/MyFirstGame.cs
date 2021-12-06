using MyFirstGame.UI;
using Sandbox;

namespace MyFirstGame
{
	public partial class MyFirstGame : Game
	{
		public Hud Hud { get; set; }

		public MyFirstGame()
		{
			Log.Info( "Hello from MyFirstGame!" );

			if ( IsServer )
				Hud = new Hud();
		}

		public override void ClientJoined( Client cl )
		{
			base.ClientJoined( cl );

			MyFirstPlayer player = new MyFirstPlayer();
			cl.Pawn = player;

			player.Respawn();
		}

	}
}
