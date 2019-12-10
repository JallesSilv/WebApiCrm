using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiCrm.Models.Entidades
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        public int Chave_Cliente { get; set; }
        
        public  string Nome_Comp { get; set; }
        
        public DateTime Data_Nasc { get; set; }

        public string Status { get; set; }
    }
}
