using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;
using KataBowlingGame;

namespace KataBowlingGameTest
{
    [TestClass]
    public class KataBowlingGameTest
    {
        [TestMethod]
        public void When_all_roll_equal_1_then_it_scores_20()
        {
            //arrange
            Bowling bowling = new Bowling();


            //act
            int score = bowling.GetScore(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 });

            //assert
            Check.That(score).IsEqualTo(20);
        }

        [TestMethod]
        public void When_strike_and_all_other_roll_equal_1_then_it_scores_30()
        {
            // arrange.
            Bowling bowling = new Bowling();

            // act.
            int score = bowling.GetScore(new int[] { 10, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 });

            // assert.
            Check.That(score).IsEqualTo(30);
        }

        [TestMethod]
        public void When_Spare_and_Other_Rolls_Equal_To_1_then_it_scores_29()
        {
            Bowling bowling = new Bowling();

            // act.
            int score = bowling.GetScore(new int[] { 5, 5, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 });

            // assert.
            Check.That(score).IsEqualTo(29);
        }

        [TestMethod]
        public void When_Srike_at_the_end_then_it_scores_30()
        {
            Bowling bowling = new Bowling();

            // act.
            int score = bowling.GetScore(new int[] { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 2, 1, 0, 1, 0, 1, 0, 10, 5, 4 });

            // assert.
            Check.That(score).IsEqualTo(30);
        }

        [TestMethod]
        public void When_Spare_at_the_end_then_it_scores_26()
        {
            Bowling bowling = new Bowling();

            // act.
            int score = bowling.GetScore(new int[] { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 2, 1, 0, 1, 0, 1, 0, 1, 9, 5 });

            // assert.
            Check.That(score).IsEqualTo(26);
        }

    }
}
