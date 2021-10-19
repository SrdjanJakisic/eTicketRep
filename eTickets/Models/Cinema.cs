using eTickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Cinema:IEntityBase
    {
        public int Id { get; set; }

        [Display(Name="Cinema logo")]
        [Required(ErrorMessage ="Cinema logo is required")]
        public string Logo { get; set; }

        [Display(Name = "Cinema name")]
        [Required(ErrorMessage = "Cinema name is required")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        #region Relationships
        public List<Movie> Movies { get; set; }
        #endregion
    }
}
