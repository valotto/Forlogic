using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        [Required]
        [MaxLength(150)]
        [Column(TypeName = "nvarchar(150)")]
        public string Nome { get; set; }
        [Required]
        [MaxLength(150)]
        [Column(TypeName = "nvarchar(150)")]
        public string Contato { get; set; }
        [Required]
        [MaxLength(20)]
        [Column(TypeName = "nvarchar(20)")]
        public string Cnpj { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Datacli { get; set; }



 
           
       


    }
}
