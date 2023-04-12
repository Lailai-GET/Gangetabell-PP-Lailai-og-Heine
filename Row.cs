using System.Reflection;

namespace Gangetabell
{
    internal class Row
    {
        private int[] _numberList;
        private int _width;
        private int Padding => _width / _numberList.Length;

        public Row(int userInput, int width)
        {
            _numberList = new int[userInput];
            _width = width;
        }

        public void GenerateMatrix()
        {
            var path = Path.Combine(Environment.CurrentDirectory, "TextFile.txt");
            List<string> listOfLines = new List<string>();
            for (int j = 1; j < _numberList.Length + 1; j++)
            {
                string numbersInLine = string.Empty;
                SetNumbers(j);
                foreach (var number in _numberList)
                {
                    string paddedString = $"{number}, ";
                    Console.Write(paddedString.PadLeft(Padding, ' '));
                    numbersInLine += $"{paddedString}";

                }
                listOfLines.Add(numbersInLine);

            }
            File.WriteAllLines(path, listOfLines);
        }

        private void SetNumbers(int jndex)
        {
            for (int i = 1; i < _numberList.Length + 1; i++)
            {
                _numberList[i - 1] = jndex * i;
            }
        }
    }
}
