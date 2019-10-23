using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SignalR.core.ViewModel
{
    public class LoginViewModel
    {
        [Required] [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
