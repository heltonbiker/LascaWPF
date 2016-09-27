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
    public class RulesTest
    {
		[Test]
		public void BoardIsSevenBySeven()
		{
			Assert.Inconclusive("How should this board be measured?");
		}

		[Test]
		public void MovesAreMadeAlternately()
		{
			Match board = Match.NewMatch();
			Assert.IsTrue(board.Turn == Army.White);

			board.AvailableMoves.First().Execute();
			Assert.IsTrue(board.Turn == Army.Black);

			board.AvailableMoves.First().Execute();
			Assert.IsTrue(board.Turn == Army.White);
		}

		[Test, Ignore("not implemented")]
		public void MovesAreOnlyDiagonal()
		{
			Assert.Fail();
		}

		[Test, Ignore("not implemented")]
		public void PrivatesCanOnlyMoveForward()
		{
			Assert.Fail();
		}

		[Test, Ignore("not implemented")]
		public void PrivatesArePromotedWhenArriveAtLastRow()
		{
			Assert.Fail();
		}

		[Test, Ignore("not implemented")]
		public void OfficersCanMoveBackwards()
		{
			Assert.Fail();
		}

		[Test, Ignore("not implemented")]
		public void CapturesTakeTheCapturedAsPrisoner()
		{
			Assert.Fail();
		}

		[Test, Ignore("not implemented")]
		public void CaptureReleasesFirstPrisonerInItsSamePosition()
		{
			Assert.Fail();
		}

		[Test, Ignore("not implemented")]
		public void ReleasedPrisonerIsLeaderOfOtherPrisoners()
		{
			Assert.Fail();
		}

		[Test, Ignore("not implemented")]
		public void CapturesPutCapturedSoldierAsTheEndOfPrisonerGroup()
		{
			Assert.Fail();
		}

		public void FirstTurnOfTheGameIsWite()
		{
			var board = Match.NewMatch();
			Assert.IsTrue(board.Turn == Army.White); 
		}

		[Test, Ignore("not implemented")]
		public void CapuresRequireOpponentAtAdjacentSpaceWithEmptySpaceBehind()
		{
			Assert.Fail();
		}

		[Test, Ignore("not implemented")]
		public void AvailableCapturesAreMandatory()
		{
			Assert.Fail();
		}

		[Test, Ignore("not implemented")]
		public void SuccessiveCapturesAreMandatory()
		{
			Assert.Fail();
		}

		[Test, Ignore("not implemented")]
		public void SuccessiveCapturesEndIfPromotionHappens()
		{
			Assert.Fail();
		}

		[Test, Ignore("not implemented")]
		public void SuccessiveCapturesLedByOfficerContinueEvenIfLastRowReached()
		{
			Assert.Fail();
		}

		[Test, Ignore("not implemented")]
		public void GameEndsIfPlayerDoesntHaveAvailableMoves()
		{
			Assert.Fail();
		}

		[Test, Ignore("not implemented")]
		public void GameEndsIfPlayerDoesntHaveFreeSoldiers()
		{
			Assert.Fail();
		}

		[Test, Ignore("not implemented")]
		public void PlayerMustChooseFromAvailableMoves()
		{
			Assert.Fail();
		}

	}
}
