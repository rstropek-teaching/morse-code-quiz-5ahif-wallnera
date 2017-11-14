using System;
using System.Collections;
using System.IO;

namespace Enigma
{
    public class FileControl
    {

        EncryptionData encr = new EncryptionData();

        public FileControl()
        {

        }
        /// <summary>
        /// Read Line -> decode -> save encode to file = less memory
        /// </summary>
        /// <param name="path"></param>
        public void encodeFileByLine(string encrpath, string decrpath)
        {
            String line;
            //int count = 0; 
            try {
                using (var sw = new StreamWriter(decrpath))
                {
                    StreamReader file = new StreamReader(encrpath);
                    while ((line = file.ReadLine()) != null)
                    {
                       foreach(string item in encr.decodePiece(line))
                        {
                            sw.Write(item); 
                        }
                        sw.WriteLine();
                    }
                    file.Close();
                }
            }
            catch (Exception e){
                Console.Error.Write(e.Message);
            }
            //outputText();
            //writeEncrypt(@"C:\Users\Alexander\source\repos\MorseCode\Files\encsample.txt");
        }
        // dead code here
    }
}
/*// TestOutput
      public void outputText()
      {
          foreach (ArrayList arraylist in encryptedLines)
          {
              foreach(string item in arraylist)
              {
                  Console.Write(item);

              }
              Console.WriteLine();
          }
      }*/

//write to file
/* public void writeEncrypt(string path)
 {
     try
     {
         using (var sw = new StreamWriter(path))
         {
             foreach (ArrayList arraylist in encryptedLines)
             {
                 foreach (string item in arraylist)
                 {
                     Console.Write(item);
                     sw.Write(item);

                 }
                 sw.WriteLine();
                 Console.WriteLine();
             }
         }
     }
     catch (Exception e)
     {
         Console.Error.Write(e.Message);
         Console.WriteLine("Failed");
     }
     Console.WriteLine("...finished...");
 }*/
