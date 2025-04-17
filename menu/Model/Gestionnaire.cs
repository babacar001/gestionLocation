﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gestion_location.Model;

namespace menu.Model
{
    public class Gestionnaire : Utilisateur
    {
        [Required, MaxLength(20)]
        public string Ninea { get; set; }

        [Required, MaxLength(20)]
        public string Rccm { get; set; }

    }
}
