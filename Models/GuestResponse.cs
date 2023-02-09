using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models {
   

    public class GuestResponse {

        
        public int Id { get; set; }


        [Required(ErrorMessage = "Lütfen Ad Soyad giriniz.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen Mail adresinizi giriniz.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Lütfen Telefon numaranızı giriniz.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Lütfen katılıp katılmayacağınızı belirtiniz.")]
        public bool? WillAttend { get; set; }
    }

}
