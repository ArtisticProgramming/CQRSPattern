using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSPattern.Domain.Commands.Word
{
    public class RegisterNewWordCommand : WordCommand
    {
        public RegisterNewWordCommand(
            string word, 
            string englishMeaning,
            string farsiMeaning, 
            string exampleSentence,
            string enPronunciation)
        {
            Word = word;
            EnglishMeaning = englishMeaning;
            FarsiMeaning = farsiMeaning;
            ExampleSentence = exampleSentence;
            EnPronunciation = EnPronunciation;
        }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
