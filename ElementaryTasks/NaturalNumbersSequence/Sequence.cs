using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaturalNumbersSequence
{
    public class Sequence
    {
        #region Prvt Field

        private List<int> _sequence = new List<int>();

        #endregion

        #region Ctor

        public Sequence(int number)
        {
            int numberOfSequence = 1;
            while (numberOfSequence * numberOfSequence <= number)
            {
                _sequence.Add(numberOfSequence);
                numberOfSequence++;
            }
        }

        #endregion

        #region Method

        public string ShowSequence()
        {
            string result = string.Empty;

            foreach (int number in _sequence)
            {
                result += $"{number},";
            }

            if (result == string.Empty)
                result = "Empty sequence!";

            return result.TrimEnd(',');
        }

        #endregion
    }
}
