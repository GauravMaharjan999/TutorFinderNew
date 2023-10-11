using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Modellayer.Models.Enums
{
    public enum BoardEnum
    {
        [Display(Name = "NEB")]
        NepalEducationBoard = 1,
        [Display(Name = "HSEB")]
        HigherSecondaryEducationBoard = 2,

        [Display(Name = "Bachelor")]
        Bachelor = 3,



    }
}
