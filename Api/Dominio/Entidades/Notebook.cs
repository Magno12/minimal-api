using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinimalApi.Dominio.Entidades;

public class Notebook
{

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; } = default!;

    
    [StringLength(200)]
    public string Descricao { get; set; } = default!;

    
    [StringLength(40)]
    public string Marca { get; set; } = default!;

    
    [StringLength(20)]
    public string Cor { get; set; } = default!;

}