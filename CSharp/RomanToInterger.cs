using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class RomanToInterger
    {
        public static int RomanToInt(string s)
        {

            //Combinations
            /*
              IV=4
              IX=9
              XL=40
              XC=90
              CD=400
              CM=900
            */

            if (s.Contains("IM") ||
                s.Contains("ID") ||
                s.Contains("IC") ||
                s.Contains("IL") ||
                s.Contains("VM") ||
                s.Contains("VD") ||
                s.Contains("VC") ||
                s.Contains("VL") ||
                s.Contains("VX") ||
                s.Contains("XM") ||
                s.Contains("XD") ||
                s.Contains("LM") ||
                s.Contains("LD") ||
                s.Contains("LC") ||
                s.Contains("DM") ||
                s is null ||
                s.Length == 0) return 0; // Invalid

            int _IV, _IX, _XL, _XC, _CD, _CM;

            _IV = _IX = _XL = _XC = _CD = _CM = -1;

            _IV = s.IndexOf("IV");

            _IX = s.IndexOf("IX");

            _XL = s.IndexOf("XL");

            _XC = s.IndexOf("XC");

            _CD = s.IndexOf("CD");

            _CM = s.IndexOf("CM");

            int counter = 0;
            int integerNumber = 0;
            bool twoSpaces = false;

            while (counter <= s.Length - 1)
            {
                if (_IV == counter)
                {
                    integerNumber += 4;
                    twoSpaces = true;
                }

                else if (_IX == counter)
                {
                    integerNumber += 9;
                    twoSpaces = true;
                }

                else if (_XL == counter)
                {
                    integerNumber += 40;
                    twoSpaces = true;
                }

                else if (_XC == counter)
                {
                    integerNumber += 90;
                    twoSpaces = true;
                }

                else if (_CD == counter)
                {
                    integerNumber += 400;
                    twoSpaces = true;
                }

                else if (_CM == counter)
                {
                    integerNumber += 900;
                    twoSpaces = true;
                }

                else
                {
                    switch (s[counter])
                    {
                        case 'I':
                            integerNumber++;
                            twoSpaces = false;
                            break;
                        case 'V':
                            integerNumber += 5;
                            twoSpaces = false;
                            break;
                        case 'X':
                            integerNumber += 10;
                            twoSpaces = false;
                            break;
                        case 'L':
                            integerNumber += 50;
                            twoSpaces = false;
                            break;
                        case 'C':
                            integerNumber += 100;
                            twoSpaces = false;
                            break;
                        case 'D':
                            integerNumber += 500;
                            twoSpaces = false;
                            break;
                        case 'M':
                            integerNumber += 1000;
                            twoSpaces = false;
                            break;
                    }
                }

                if (twoSpaces) counter += 2; else counter++;
            }

            return integerNumber;
        }
    }
}
