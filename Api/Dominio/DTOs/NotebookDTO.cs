namespace MinimalApi.DTOs;

public record NotebookDTO
{
    public string Descricao { get; set; } = default!;
    public string Marca { get; set; } = default!;
    public string Cor { get; set; } = default!;
}