using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataBowlingGame
{
    public class Bowling
    {
        public int GetScore(int[] scores)
        {
            int score = 0;
            int bonus = 0;

            List<Tuple<int, int>> frames = GetFrames(scores);

            for (int k = 0; k < 10; k++)
            {
                score += frames[k].Item1 + frames[k].Item2;

                if (IsStrike(frames[k]))
                {
                    bonus = frames[k + 1].Item1 + frames[k + 1].Item2;
                    score += bonus;
                }
                else if (IsSpare(frames[k]))
                {
                    bonus = frames[k + 1].Item1;
                    score += bonus;
                }
            }
            return score;
        }

        private static List<Tuple<int, int>> GetFrames(int[] scores)
        {
            List<Tuple<int, int>> frames = new List<Tuple<int, int>>();
            int i = 0;
            while (i < scores.Length)
            {
                if (scores[i] == 10)
                {
                    frames.Add(new Tuple<int, int>(10, 0));
                    i++;
                }
                else
                {
                    if (i < scores.Length - 1)
                    {
                        frames.Add(new Tuple<int, int>(scores[i], scores[i + 1]));
                        i += 2;
                    }
                    else
                    {
                        frames.Add(new Tuple<int, int>(scores[i], 0));
                        i += 1;
                    }
                }
            }
            return frames;
        }

        private static bool IsStrike(Tuple<int, int> frame)
        {
            return frame.Item1 == 10 && frame.Item2 == 0;
        }

        private static bool IsSpare(Tuple<int, int> frame)
        {
            return frame.Item1 + frame.Item2 == 10 && frame.Item1 != 10;
        }
    }
}
