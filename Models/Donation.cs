using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace globalsolution.fomezero.Models
{
    public class Donation
    {
        [HiddenInput]
        public int DonationId { get; set; }
        [Display(Name = "Fornecedor")]
        public Provider Provider { get; set; }
        public int? ProviderId { get; set; }
        [Display(Name = "ONG")]
        public Charity Charity { get; set; }
        public int? CharityId { get; set; }
        [Display(Name = "Anúncio")]
        public Advertising Advertising { get; set; }
        public int? AdvertisingId { get; set; }
        [Display(Name = "Data")]
        public DateTime Date { get; set; }
        public Status Status { get; set; }

        public Donation()
        {
        }
    }

    public enum Status
    {
        Aguardando, Retirado
    }
}
