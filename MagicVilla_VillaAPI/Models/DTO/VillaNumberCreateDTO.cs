namespace MagicVilla_VillaAPI.Models.DTO;
using System.ComponentModel.DataAnnotations;

public class VillaNumberCreateDTO
{
    [Required]
    public int VillaNo { get; set; }
    public string SpecialDetails { get; set; }
}