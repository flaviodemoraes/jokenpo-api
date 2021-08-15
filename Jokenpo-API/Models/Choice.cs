
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Jokenpo_API.Models
{
    public enum Choices
    {
        [field: Description("Rock")]
        Rock,
        [field: Description("Paper")]
        Paper,
        [field: Description("Scissors")]
        Scissors
    }

    public class Choice
    {
        [Required]
        [DataType(DataType.Text)]
        [EnumDataType(typeof(Choices))]
        public string choisesUser{ get; set; }
    }
}
