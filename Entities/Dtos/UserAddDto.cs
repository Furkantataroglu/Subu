﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//SADECE FRONT END KISMINDAN GELEN BİLGİLERLE USER OLUŞTURMAMIZI SAĞLAR MESELA CREATE DATE FALAN OTOMATİK GELSİN DİYE BU CLASSI KULLANIYORUZ
namespace Entities.Dtos
{
    public class UserAddDto
    {
        [Required(ErrorMessage = "Required")]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Required")]
         public string LastName { get; set; }
        [MaxLength(50)]
        [Required]
        public string Password { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }   
    }
}
