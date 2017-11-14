using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Enigma
{

    /// Research: 
    /// Best way to store two strings with key 
    /// https://stackoverflow.com/questions/7095820/what-is-the-best-way-to-store-pairs-of-strings-make-an-object-or-use-a-class-in
    ///     -> Dictionary
    /// My Encoding is from: 
    /// ITU: https://upload.wikimedia.org/wikipedia/en/5/5a/Morse_comparison.svg


    public class EncryptionData
    {

        public Dictionary<string, string> cryptex;
        
        public EncryptionData()
        {
            fillCryptex();
        }

        private void fillCryptex()
        {
            cryptex = new Dictionary<string, string>();
            //LETTERS
            cryptex.Add("A", ".-");
            cryptex.Add("B", "-...");
            cryptex.Add("C", "-.-.");
            cryptex.Add("D", "-..");
            cryptex.Add("E",".");
            cryptex.Add("F", "..-.");
            cryptex.Add("G", "--.");
            cryptex.Add("H", "....");
            cryptex.Add("I", "..");
            cryptex.Add("J", ".---");
            cryptex.Add("K", "-.-");
            cryptex.Add("L", ".-..");
            cryptex.Add("M", "--");
            cryptex.Add("N", "-.");
            cryptex.Add("O", "---");
            cryptex.Add("P", ".--.");
            cryptex.Add("Q", "--.-");
            cryptex.Add("R", ".-.");
            cryptex.Add("S", "...");
            cryptex.Add("T", "-");
            cryptex.Add("U", "..-");
            cryptex.Add("V", "...-");
            cryptex.Add("W", ".--");
            cryptex.Add("X", "-..-");
            cryptex.Add("Y", "-.--");
            cryptex.Add("Z", "--..");
            //NUMBERS
            cryptex.Add("1",  ".----");
            cryptex.Add("2", "..---");
            cryptex.Add("3", "...--");
            cryptex.Add("4", "....-");
            cryptex.Add("5", ".....");
            cryptex.Add("6", "-....");
            cryptex.Add("7", "--...");
            cryptex.Add("8", "---..");
            cryptex.Add("9", "----.");
            cryptex.Add("0", "-----");
        }

        public ArrayList decodePiece(String line)
        {
            ArrayList encryptedText = new ArrayList();
            String[] cryptedWords;
            String[] cryptedChars;
            string encodedWord = "";
            cryptedWords = extractWord(line.Trim());
            // decrypt words
            foreach(string word in cryptedWords)
            {
                word.Trim();
                cryptedChars = getCryptedChars(word);
                foreach(string letter in cryptedChars)
                {
                    // get combination - key from cryptex
                    encodedWord += cryptex.FirstOrDefault(alphabetic => alphabetic.Value == letter).Key;
                }
                encryptedText.Add(encodedWord);
                encryptedText.Add(" ");
                encodedWord = "";
            }

            return encryptedText; 
        }

        public String[] extractWord(String line)
        {
            // split at 4 spaces -> new word
            String[] arr = line.Split("    ");
            return arr;
        }

        public String[] getCryptedChars(String word)
        {
            String[] arr = word.Split(" ");
            return arr;
        }
    }
}
