using System.ComponentModel.DataAnnotations;

namespace Exemplo.Api.ViewModels
{
    public class UserRandomAlphanumericViewModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public Guid UserId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string RandomAlphanumeric { get; set; }
    }
}
