namespace Lasca.Domain
{
	public class Move
	{
		private Match match;

		public Move(Match match)
		{
			this.match = match;
		}

		public Position EndPosition { get; }
		public Position StartPosition { get; }

		public void Execute()
		{
			match.ChangeTurn();
		}
	}
}
