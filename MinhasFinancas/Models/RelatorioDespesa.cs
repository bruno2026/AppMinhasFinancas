﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinhasFinancas.Models
{
    public class RelatorioDespesa
    {
        [Key]
        public int ItemId { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name ="Despesa")]
        public string ItemNome { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Valor { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime DataDespesa { get; set; } = DateTime.Now;

        [Required]
        [StringLength(100)]
        public string Categoria { get; set; }
    }
}
