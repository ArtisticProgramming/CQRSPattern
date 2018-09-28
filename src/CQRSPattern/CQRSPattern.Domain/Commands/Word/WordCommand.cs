using CQRSPattern.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSPattern.Domain.Commands.Word
{
    public abstract class WordCommand : Command
    {
        public Guid Id { get; set; }
        public string Word { get; set; }
        public string EnglishMeaning { get; set; }
        public string FarsiMeaning { get; set; }
        public string ExampleSentence { get; set; }
        public string EnPronunciation { get; set; }

    
    }
}
