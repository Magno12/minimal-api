using MinimalApi.Dominio.Entidades;
using MinimalApi.DTOs;
using MinimalApi.Infraestrutura.Db;
using MinimalApi.Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace MinimalApi.Dominio.Servicos;

public class NotebookServico : INotebookServico
{
    private readonly DbContexto _contexto;
    public NotebookServico(DbContexto contexto)
    {
        _contexto = contexto;
    }

    public void Apagar(Notebook notebook)
    {
        throw new NotImplementedException();
    }

    public void Atualizar(Notebook notebook)
    {
        throw new NotImplementedException();
    }

    public Notebook? BuscarPorId(int id)
    {
        throw new NotImplementedException();
    }

    public void Incluir(Notebook notebook)
    {
        try
        {
            _contexto.Notebooks.Add(notebook);
            _contexto.SaveChanges();
        }
        catch (System.Exception e)
        {
            throw new Exception("Erro no Incluir Notebook "+ e.Message);
        }
    }

    public List<Notebook> Todos()
    {
        throw new NotImplementedException();
    }
}