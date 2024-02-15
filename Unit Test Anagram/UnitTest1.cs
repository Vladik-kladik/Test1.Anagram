using NUnit.Framework;
using Test1_Anagram;

namespace Unit_Test_Anagram;


    public class Tests
    {

        [Test]
        public void Revers_ValidWord_returnsRevers()
        {
            Anagram anagram = new Anagram();
            string reversedSentence = anagram.ReversedWord("Hello World!");
            Assert.That(reversedSentence, Is.EqualTo("!dlroW olleH"));
        }
        
      
        [Test]
        public void ReverseWord_WithNonAlnon_alphabetic_characters()
        {
            string reversedSentence = new Anagram().ReversedWord("123abc!412");
            Assert.That(reversedSentence, Is.EqualTo("214!cba321"));
        }
        
        [Test]
        public void ReverseWord_NullWord_ReturnsNull()
        {
            string reversedSentence = new Anagram().Reverse(null);
            Assert.That(reversedSentence, Is.Null);
          
        }

      
    }
