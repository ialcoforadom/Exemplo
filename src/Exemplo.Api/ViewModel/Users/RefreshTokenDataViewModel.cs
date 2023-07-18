using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo.Api.ViewModels
{
    public class RefreshTokenDataViewModel
    {
        [Required]
        public Guid UserId { get; set; }

        [Required]
        public string RefreshToken { get; set; }
    }
}
