using Exo.WebApi.Contexts;
using Exo.WebApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace Exo.WebApi.Repositories
{
    public class ProjetoRepository
    {
        private readonly ExoContext _context;

        public ProjetoRepository(ExoContext context)
        {
            _context = context;
        }

        // READ
        public List<Projeto> Listar()
        {
            return _context.Projetos.ToList();
        }

        // CREATE
        public void Cadastrar(Projeto projeto)
        {
            _context.Projetos.Add(projeto);
            _context.SaveChanges();
        }

        // READ BY ID
        public Projeto BuscarporId(int id)
        {
            return _context.Projetos.Find(id);
        }

        // UPDATE
        public void Atualizar(int id, Projeto projeto)
        {
            Projeto projetoBuscado = _context.Projetos.Find(id);
            if (projetoBuscado != null)
            {
                projetoBuscado.NomeDoProjeto = projeto.NomeDoProjeto;
                projetoBuscado.Area = projeto.Area;
                projetoBuscado.Status = projeto.Status;
                _context.Projetos.Update(projetoBuscado);
                _context.SaveChanges();
            }
        }

        // DELETE
        public void Deletar(int id)
        {
            Projeto projetoBuscado = _context.Projetos.Find(id);
            _context.Projetos.Remove(projetoBuscado);
            _context.SaveChanges();
        }
    }
}
