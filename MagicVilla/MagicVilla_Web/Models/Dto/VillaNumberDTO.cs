﻿using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace MagicVilla_Web.Models.Dto
{
    public class VillaNumberDTO
    {
        [Required]
        public int VillaNo { get; set; }
        [Required]
        public int VillaID { get; set; }
        public string SpecialDetails { get; set; }

    }
}