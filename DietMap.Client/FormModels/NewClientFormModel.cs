using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using DietMap.Client.Enumerations;
namespace DietMap.Client.FormModels
{
    public class NewClientModel
    {
        [Required]
        [StringLength(100,MinimumLength = 4, ErrorMessage = "Name cannot be longer than 100 characters or shorter than 4")]
        [JsonProperty("fullname")]
        public string FullName { get; set; }

        [Required]
        [EnumDataType(typeof(Gender))]
        [JsonProperty("gender")]
        public Gender Gender {get;set;}

        public void TrimName(){
            FullName = FullName.TrimEnd();
            FullName = FullName.TrimStart();
        }
    }

}