using Lasca.Domain;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace LascaDomain.Tests
{
	[TestFixture]
    public class BasicMovesTests
    {
		[Test]
		public void BoardIsSevenBySeven()
		{
			Assert.Inconclusive("How should this board be measured?");
		}

		[Test]
		public void FirstTurnOfTheGameIsWhite()
		{
			var board = Match.NewMatch();
			Assert.IsTrue(board.Turn == TeamType.White);
		}

		[Test]
		public void MovesAreMadeAlternately()
		{
			Match board = Match.NewMatch();
			Assert.IsTrue(board.Turn == TeamType.White);

			board.AvailableMoves.First().Execute();
			Assert.IsTrue(board.Turn == TeamType.Black);

			board.AvailableMoves.First().Execute();
			Assert.IsTrue(board.Turn == TeamType.White);
		}

		[Test]
		public void PrivatesCanOnlyMoveForward_Whites()
		{
			var board = new Board();
			Piece piece = board.AddWhite(Positions._44);
			Assert.IsTrue(piece.Rank == Rank.Private);

			IEnumerable<Move> moves = piece.GetAvailableMoves(board);
			Assert.IsTrue(moves.Count() == 2);
			Assert.IsTrue(moves.All(m => m.EndPosition.Y > m.StartPosition.Y));
		}

		[Test]
		public void PrivatesArePromotedWhenArriveAtLastRow()
		{
			Assert.Inconclusive("Not implemented yet.");
		}

		[Test]
		public void OfficersCanMoveBackwards()
		{
			Assert.Inconclusive("Not implemented yet.");
		}

		[Test]
		public void PlayerMustChooseFromAvailableMoves()
		{
			Assert.Inconclusive("Not implemented yet.");
		}

	}
}
