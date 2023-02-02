using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        public String Logo { get; set; }
        public string Name { get; set; }
        public String Description { get; set; }
        //Relation
        public List<Movie> Movies { get; set; }
    }
}
