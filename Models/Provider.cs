using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace globalsolution.fomezero.Models
{
    public class Provider
    {
        [HiddenInput]
        public int ProviderId { get; set; }
        [Display(Name = "No. Documento")]
        public string Document { get; set; }
        [Display(Name = "Nome")]
        public string Name { get; set; }
        [Display(Name = "E-mail")]
        public string Email { get; set; }
        [Display(Name = "Senha")]
        public string Password { get; set; }
        [Display(Name = "Telefone")]
        public string Phone { get; set; }
        [Display(Name = "Tipo")]
        public UserType Type { get; set; }
        [Display(Name = "Endereço")]
        public string Address { get; set; }
        [Display(Name = "Cidade")]
        public string City { get; set; }
        public string UF { get; set; }
        [Display(Name = "País")]
        public string Country { get; set; }
        [Display(Name = "Anúncios")]
        public ICollection<Advertising> Advertisings { get; set; }
        [Display(Name = "Doações")]
        public ICollection<Donation> Donations { get; set; }

        public Provider()
        {
        }
    }
}
