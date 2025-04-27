using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_5
{   
    public class StringProcessing
    {
        private string _inputString;
        private int _shiftValue;

        public string InputString
        {
            get { return _inputString; }
            private set
            {
                if (value.Length > 40)
                    throw new ArgumentException("Input string must be at most 40 characters long.");
                if (!value.All(c => c >= 'A' && c <= 'Z'))
                    throw new ArgumentException("Input must contain only capital letters (A-Z).");
                _inputString = value;
            }
        }

        public int ShiftValue
        {
            get { return _shiftValue; }
            private set
            {
                if (value < -25 || value > 25)
                    throw new ArgumentException("Shift value must be between -25 and 25.");
                _shiftValue = value;
            }
        }

        public StringProcessing(string input, int shift)
        {
            InputString = input;
            ShiftValue = shift;
        }

        public string Encode()
        {
            return new string(_inputString.Select(c => (char)(((c - 'A' + _shiftValue + 26) % 26) + 'A')).ToArray());
        }

        public string Print()
        {
            return Encode();
        }

        public int[] InputCode()
        {
            return _inputString.Select(c => (int)c).ToArray();
        }

        public int[] OutputCode()
        {
            return Encode().Select(c => (int)c).ToArray();
        }

        public string Sort()
        {
            return new string(_inputString.OrderBy(c => c).ToArray());
        }

        public string SortedEncodedAscii()
        {
            return new string(Encode().OrderBy(c => (int)c).ToArray());
        }

    }
}