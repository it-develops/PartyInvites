using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage ="Пожалуйста введите Ваше имя")]
        public string Name { get; set;}

        [Required(ErrorMessage = "Пожалуйста введите Ваш Email адрес")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage ="Пожалуйста введите корректный адрес Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Пожалуйста введите Ваш номер телефона")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Пожалуйста укажите, примите ли Вы участие")]
        public bool? WillAttend { get; set; }
    }
}
