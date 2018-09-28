using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CQRSPattern.Application.ViewModel
{
  public  class WordViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "The Word is Required")]
        [MinLength(2)]
        [MaxLength(100)]
        [DisplayName("Name")]
        public string Word { get; set; }

        [DisplayName("English Meaning")]
        public string EnglishMeaning { get; set; }

        [DisplayName("Farsi Meaning")]
        public string FarsiMeaning { get; set; }

        [MinLength(5)]
        [DisplayName("Example Sentence")]
        public string ExampleSentence { get; set; }

        [DisplayName("English Pronunciation")]
        public string EnPronunciation { get; set; }

    }
}
