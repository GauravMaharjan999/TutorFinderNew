using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Modellayer.Models.Enums
{
    public enum GenderEnum
    {

        [Display(Name="Male")]
        Male=1,
        [Display(Name = "Female")]
        Female =2,
        [Display(Name = "Others")]
        Others =3
    }
}
