using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Business.ViewModels.Account
{
    public class RegisterVM
    {
        [Required, MaxLength (30)]
        public string FirstName { get; set; }
        [Required, MaxLength(30)]
        public string LastName { get; set; }
        [Required, MaxLength(30)]
        public string UserName { get; set; }
        [Required, MaxLength(30), DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required, MaxLength(30),DataType(DataType.Password)]
        public string Password { get; set; }
        [Required, MaxLength(30),DataType(DataType.Password), Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }

    }
}
