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
        _contexto.Notebooks.Remove(notebook);
        _contexto.SaveChanges();
    }

    public void Atualizar(Notebook notebook)
    {
       _contexto.Notebooks.Update(notebook);
        _contexto.SaveChanges();
    }

    public Notebook? BuscarPorId(int id)
    {
        try
        {
            var notebook = _contexto.Notebooks.FirstOrDefault(n => n.Id == id);
            return notebook != null ? notebook : null;
        }
        catch (System.ArgumentNullException e)
        {
            throw new Exception("Referencia nula " + e.Message);
            //tratar exeção
        }
        catch (System.Exception e)
        {
            throw new Exception("Erro no Buscar Notebook Por Id " + e.Message);
        }
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
            throw new Exception("Erro no Incluir Notebook " + e.Message);
        }
    }

    public List<Notebook> Todos()
    {
        try
        {
            return _contexto.Notebooks.ToList();
        }
        catch (System.Exception e)
        {
            throw new Exception("Erro ao Lista Todos Notebook " + e.Message);
        }
    }
}