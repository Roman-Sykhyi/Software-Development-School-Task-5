using System;
using System.Text;

namespace Задача_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            string[] textParts = new string[3]
                {
                "Дано #текст з #особливостями#,",
                "які можуть бути #відкоректовані#",
                "дуже легко#"
                };

            textParts = ReplaceSharps(textParts);
            PrintText(textParts);
        }

        private static string[] ReplaceSharps(string[] textParts)
        {
            string[] newTextParts = new string[textParts.Length];

            for(int i = 0; i < textParts.Length; i++)
            {
                char nextChar;
                StringBuilder stringBuilder = new StringBuilder(textParts[i]);
                for (int j = 0; j < textParts[i].Length; j++)
                {
                    if (textParts[i][j] == '#')
                    {
                        if(j == textParts[i].Length - 1)
                        {
                            stringBuilder[j] = '>';
                        }
                        else
                        {
                            nextChar = textParts[i][j+1];

                            if (char.IsLetter(nextChar))
                            {
                                stringBuilder[j] = '<';
                            }
                            else
                            {
                                stringBuilder[j] = '>';
                            }
                        }
                    }
                }
                newTextParts[i] = stringBuilder.ToString();
            }

            return newTextParts;
        }

        private static void PrintText(string[] textParts)
        {
            foreach (string textPart in textParts)
            {
                Console.WriteLine(textPart);
            }
        }
    }
}
