using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace globalsolution.fomezero.Models
{
    public class Advertising
    {
        [HiddenInput]
        public int AdvertisingId { get; set; }
        [Display(Name = "Título")]
        public string Title { get; set; }
        [Display(Name = "Fornecedor")]
        public Provider Provider { get; set; }
        public int? ProviderId { get; set; }
        [Display(Name = "Descrição")]
        public string Description { get; set; }
        [Display(Name = "Quantidade")]
        public int Quantity { get; set; }

        public Advertising()
        {
        }
    }
}
