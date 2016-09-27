using Lasca.Domain;
using LascaDomain;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
		public void FirstTurnOfTheGameIsWite()
		{
			var board = Match.NewMatch();
			Assert.IsTrue(board.Turn == TeamColor.White);
		}

		[Test]
		public void MovesAreMadeAlternately()
		{
			Match board = Match.NewMatch();
			Assert.IsTrue(board.Turn == TeamColor.White);

			board.AvailableMoves.First().Execute();
			Assert.IsTrue(board.Turn == TeamColor.Black);

			board.AvailableMoves.First().Execute();
			Assert.IsTrue(board.Turn == TeamColor.White);
		}

		[Test]
		public void PrivatesCanOnlyMoveForward()
		{
			var board = new Board();
			board.Place(new Piece(TeamColor.White), Position._13);
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
