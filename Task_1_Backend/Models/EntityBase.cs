using System.ComponentModel.DataAnnotations;

namespace Task_1_Backend.Models
{
    public class EntityBase
    {
        [Key] public int Id { get; set; }
    }
}