using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Task_1_Backend.Models
{
    public class EntityBase
    {
        [Key]
        public int Id { get; set; }
    }
}
