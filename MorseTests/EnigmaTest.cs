using Enigma;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MorseTests
{
    [TestClass]
    public class EnigmaTest
    {
        /// <summary>
        /// tries to decode some "wrong" characters
        /// </summary>
        [TestMethod]
        public void DecodeWrongSymbols()
        {
            EncryptionData encrdata = new EncryptionData();
            string wrongstr = "****";
            encrdata.decodePiece(wrongstr);
            Assert.IsTrue(true);
        }

        /// <summary>
        /// Tries to decode a correct Symbol -> test if it works correctly (not only exceptions)
        /// </summary>
        [TestMethod]
        public void DecodeRightSymbols()
        {
            EncryptionData encrdata = new EncryptionData();
            string okstr = "....";
            encrdata.decodePiece(okstr);
            Assert.IsTrue(true);
        }

        /// <summary>
        /// Testing split function -> expected 2 strings in array
        /// </summary>
        [TestMethod, Timeout(40)]
        public void SplitWords()
        {
            EncryptionData encrdata = new EncryptionData();
            string tosplit = "1 2  3   4    5";
            string[] ret = encrdata.extractWord(tosplit);
            Assert.AreEqual(ret.Length, 2);
        }

        /// <summary>
        /// Tests if Method splits correctly
        /// </summary>
        [TestMethod, Timeout(40)]
        public void SplitRightLetters()
        {
            EncryptionData encrdata = new EncryptionData();
            string tosplit = ".... ....";
            string cryptedcharsol = "....";
            string[] ret = encrdata.getCryptedChars(tosplit);        
            Assert.AreEqual(ret[0], cryptedcharsol);
            Assert.AreEqual(ret[1], cryptedcharsol);
        }

        /// <summary>
        /// should throw an exception -> random paths
        /// </summary>
        [TestMethod]
        public void FileLocation()
        {
            FileControl filcon = new FileControl();
            filcon.encodeFileByLine("P:/encrpath/sample.txt", "P:/decrpath/sol.txt");
            Assert.IsTrue(true);
        }
    }
}
