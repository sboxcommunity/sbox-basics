using Sandbox;

namespace MyFirstGame
{
	public partial class MyFirstPlayer : Player
	{
		public override void Respawn()
		{
			base.Respawn();

			SetModel( "models/citizen/citizen.vmdl" );

			Controller = new WalkController();
			Animator = new StandardPlayerAnimator();
			Camera = new ThirdPersonCamera();
		}
	}
}
