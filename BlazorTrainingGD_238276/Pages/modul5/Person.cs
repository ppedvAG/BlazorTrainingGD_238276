using System.ComponentModel.DataAnnotations;

namespace BlazorTrainingGD_238276.Pages.modul5
{
    public class Person
    {
        [Required(ErrorMessage ="da muss was rein")]
        [StringLength(10,ErrorMessage ="max 10 Zeichen")]
        public string Name { get; set; }
        [Required(ErrorMessage = "da muss was rein")]
        [Range(150,180,ErrorMessage ="zwischne 150 und 180")]
        public int Gross { get; set; }
        [Required(ErrorMessage = "da muss was rein")]
        public DateTime GebDat { get; set; }

    }
}
