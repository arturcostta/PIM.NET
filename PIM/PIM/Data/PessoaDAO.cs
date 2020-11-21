using PIM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PIM.Data
{
    public class PessoaDAO
    {
        private readonly PIMContext _context;

        public PessoaDAO(PIMContext context)
        {
            _context = context;
        }

        public async void insere (Pessoa pessoa)
        {
            _context.Add(pessoa);
            await _context.SaveChangesAsync();
        }

        public async void exclua (int id)
        {
            var pessoa = await _context.pessoas.FindAsync(id);
            _context.pessoas.Remove(pessoa);
            await _context.SaveChangesAsync();
        }

        public async void altere(Pessoa pessoa)
        {
            _context.Update(pessoa);
            await _context.SaveChangesAsync();
        }

        public Pessoa consulte(string cpf)
        {
            var pessoa = _context.pessoas.Where(p => p.cpf == cpf);
            return (Pessoa)pessoa; 
        }
    }
}
