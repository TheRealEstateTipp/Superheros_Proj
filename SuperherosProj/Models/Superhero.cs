using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperherosProj.Models
{
    public class Superhero
    {
        [Key]
        public int ID;

        public string Name;


    }
}
