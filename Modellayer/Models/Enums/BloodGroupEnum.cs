﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Modellayer.Models.Enums
{
    public enum BloodGroupEnum
    {
        [Display(Name = "A+")]
        APositive = 1,
        [Display(Name = "A-")]
        ANegative = 2,

        [Display(Name = "B+")]
        BPositive = 3,
        [Display(Name = "B-")]
        BNegative = 4,

        [Display(Name = "AB+")]
        ABPositive = 5,
        [Display(Name = "AB-")]
        ABNegative = 6,

        [Display(Name = "O+")]
        OPositive = 7,
        [Display(Name = "O-")]
        ONegative = 8,



    }
}
