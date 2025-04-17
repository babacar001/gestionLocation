using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace gestion_location.Model
{
    public class Personne
    {
        [Key]
        public int IdPersonne { get; set; }

        [Required, MaxLength(160)]
        public string NomPrenom { get; set; }

        [Required, MaxLength(20)]
        public string Telephone { get; set; }

        [Required, MaxLength(50), DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [ MaxLength(20)]
        public string CNI { get; set; }



    }
}
