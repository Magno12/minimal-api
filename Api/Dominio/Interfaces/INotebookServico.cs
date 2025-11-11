using MinimalApi.Dominio.Entidades;
using MinimalApi.DTOs;

namespace MinimalApi.Dominio.Interfaces;

public interface INotebookServico
{
    List<Notebook> Todos();

    Notebook? BuscarPorId(int id);

    void Incluir(Notebook notebook);

    void Atualizar(Notebook notebook);

    void Apagar(Notebook notebook);
}