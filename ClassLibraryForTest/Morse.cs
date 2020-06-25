using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace NarekLibrary.ForTest
{
    /// <summary>
    /// This class will convert text(case insensitive) to Morse code with EncodeToMorse, and will convert Morse code to text
    /// with DecodeFromMorse. Note that Morse code contains ' - ' (dash), ' . ' (dot), '   ' (space) and ' / '(slash).
    /// In encoded text, space means end of character and slash means end of word.
    /// </summary>
    public class Morse
    {
        /// <summary>
        /// Encodes a text to morse code. It supports limited characters and it is case insensitive. In case of unsuported characters
        /// result will be notification.
        /// </summary>
        /// <param name="str">English text, with limited special caracter support</param>
        /// <returns>Morse code</returns>
        public static string EncodeToMorse(string str)
        {
            
            Dictionary<char, string> morse = new Dictionary<char, string>();
            #region Morse Dictionary
            morse.Add('a', ".-");
            morse.Add('b', "-...");
            morse.Add('c', "-.-.");
            morse.Add('d', "-..");
            morse.Add('e', ".");
            morse.Add('f', "..-.");
            morse.Add('g', "--.");
            morse.Add('h', "....");
            morse.Add('i', "..");
            morse.Add('j', ".---");
            morse.Add('k', "-.-");
            morse.Add('l', ".-..");
            morse.Add('m', "--");
            morse.Add('n', "-.");
            morse.Add('o', "---");
            morse.Add('p', ".--.");
            morse.Add('q', "--.-");
            morse.Add('r', ".-.");
            morse.Add('s', "...");
            morse.Add('t', "-");
            morse.Add('u', "..-");
            morse.Add('v', "...-");
            morse.Add('w', ".--");
            morse.Add('x', "-..-");
            morse.Add('y', "-.--");
            morse.Add('z', "--..");
            morse.Add('0', "-----");
            morse.Add('1', ".----");
            morse.Add('2', "..---");
            morse.Add('3', "...--");
            morse.Add('4', "....-");
            morse.Add('5', ".....");
            morse.Add('6', "-....");
            morse.Add('7', "--...");
            morse.Add('8', "---..");
            morse.Add('9', "----.");
            morse.Add('!', "-.-.--");
            morse.Add(',', "--..--");
            morse.Add('\'', ".----.");
            morse.Add('.', ".-.-.-");
            morse.Add('?', "..--..");
            morse.Add(':', "---...");
            morse.Add(' ', "/");
            #endregion


            StringBuilder result = new StringBuilder();
            foreach (char c in str.ToLower())
            {
                string st;
                result.Append(" ");
                if (morse.TryGetValue(c, out st)) 
                { 
                    result.Append(st); 
                }
                else
                {
                    StringBuilder keys = new StringBuilder();
                    char[] chars = morse.Keys.ToArray<char>();
                    foreach(char ct in chars)
                    {
                        keys.Append(ct);
                        keys.Append(' ');
                    }
                    return "Notification - Your text contains characters that are not supported by this tool. These are the supported characters\n" + keys.ToString();
                }
            }
            return result.ToString().Substring(1);
        }




        /// <summary>
        /// Decodes a Morse code to English text. It supports limited characters and it returns a text in lower case. In case of unsuported characters
        /// result will be notification.
        /// </summary>
        /// <param name="input">Morse code, with limited character support</param>
        /// <returns>English text</returns>
        public static string DecodeFromMorse(string input)
        {
            Dictionary<string, char> morse = new Dictionary<string, char>();
            #region Morse Dictionary
            morse.Add(".-", 'a');
            morse.Add("-...", 'b');
            morse.Add("-.-.", 'c');
            morse.Add("-..", 'd');
            morse.Add(".", 'e');
            morse.Add("..-.", 'f');
            morse.Add("--.", 'g');
            morse.Add("....", 'h');
            morse.Add("..", 'i');
            morse.Add(".---", 'j');
            morse.Add("-.-", 'k');
            morse.Add(".-..", 'l');
            morse.Add("--", 'm');
            morse.Add("-.", 'n');
            morse.Add("---", 'o');
            morse.Add(".--.", 'p');
            morse.Add("--.-", 'q');
            morse.Add(".-.", 'r');
            morse.Add("...", 's');
            morse.Add("-", 't');
            morse.Add("..-", 'u');
            morse.Add("...-", 'v');
            morse.Add(".--", 'w');
            morse.Add("-..-", 'x');
            morse.Add("-.--", 'y');
            morse.Add("--..", 'z');
            morse.Add("-----", '0');
            morse.Add(".----", '1');
            morse.Add("..---", '2');
            morse.Add("...--", '3');
            morse.Add("....-", '4');
            morse.Add(".....", '5');
            morse.Add("-....", '6');
            morse.Add("--...", '7');
            morse.Add("---..", '8');
            morse.Add("----.", '9');
            morse.Add("-.-.--", '!');
            morse.Add("--..--", ',');
            morse.Add(".----.", '\'');
            morse.Add(".-.-.-", '.');
            morse.Add("..--..", '?');
            morse.Add("---...", ':');
            morse.Add("/", ' ');
            #endregion

            if (input.Length == 0) { return "Notification - Input is empty"; }
            if(Regex.IsMatch(input, @"^[^.\- /]+$")) { return "Notification - Input contains unsoported charecters used in Morse code.\n" + "Morse code should contain ' - ' (dash), ' . ' (dot), '   ' (space) and ' / '(slash)."; }
            string[] inputArr = input.Split(' ');
            StringBuilder result = new StringBuilder();
            foreach (string str in inputArr)
            {
                char c;
                if (morse.TryGetValue(str,out c))
                {
                    result.Append(c);
                }
                else
                {
                    return "Notification - Mose code may contains unsuported characters or invalid codes. Please check your code.";
                }
            }
            return result.ToString();
        }
    }
}
