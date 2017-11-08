using System;
using System.Collections.Generic;
using System.Windows.Forms;


//Description:

//Create a function that takes a Roman numeral as its argument and returns its value as a numeric decimal integer.You don't need to validate the form of the Roman numeral.

//Modern Roman numerals are written by expressing each decimal digit of the number to be encoded separately, starting with the leftmost digit and skipping any 0s.So 1990 is rendered "MCMXC" (1000 = M, 900 = CM, 90 = XC) and 2008 is rendered "MMVIII" (2000 = MM, 8 = VIII). The Roman numeral for 1666, "MDCLXVI", uses each letter in descending order.

//Example:

//RomanDecode.Solution("XXI") -- should return 21
//Courtesy of rosettacode.org

//best solution:
//using System;
//using System.Collections.Generic;
//using System.Linq;
//public class RomanDecode
//{
//    private static Dictionary<char, int> _map3 = new Dictionary<char, int>
//    {
//        {'I',1},
//        {'V',5},
//        {'X',10},
//        {'L',50},
//        {'C',100},
//        {'D',500},
//        {'M',1000},
//    };

//    public static int Solution(string roman)
//    {
//        return roman.Reverse().Aggregate(0, (current, ch) => current + (_map3[ch] * 3 < current ? -_map3[ch] : _map3[ch]));
//    }
//}




namespace Codewars_RomanNumeralsDecoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string RomanDecode(string input)
        {
            input = input.Trim();
            List<char> romanian = new List<char>() {'I','V', 'X', 'L', 'C', 'D', 'M'};
            List<int> numbers = new List<int>() { 1, 5, 10, 50, 100, 500, 1000 };
            List<int> resultNums = new List<int>();
            
            foreach (char t in input)
            {
                if(romanian.Contains(t))
                    resultNums.Add(numbers[romanian.IndexOf(t)]);
            }

            for (int k = resultNums.Count-1; k > 0; k--)
            {
                if (Math.Abs(resultNums[k]) > Math.Abs(resultNums[k - 1]))
                    resultNums[k - 1] *= -1;
            }
            int Summ = 0;
            foreach (var element in resultNums)
            {
                Summ += element;
            }

            return Summ.ToString();
        }


        private void button_Decode_Click(object sender, EventArgs e)
        {
            textBox_output.Text = RomanDecode(textBox_input.Text);
        }
    }
}
