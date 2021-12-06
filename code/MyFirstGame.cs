using Sandbox;

namespace MyFirstGame
{
	public partial class MyFirstGame : Game
	{
		public MyFirstGame()
		{
			Log.Info( "Hello from MyFirstGame!" );
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
