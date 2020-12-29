using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testeContSelf.Data;
using testeContSelf.Models;

namespace testeContSelf.Service
{
    public class PesquisaService
    {
        private readonly testeContSelfContext _context;

        public PesquisaService(testeContSelfContext context)
        {
            _context = context;
        }

        public async Task<List<Funcionario>> FindBySearchAsync(string? id)
        {
            var funcionario = _context.Funcionario.Where(f => f.Nome.Contains(id));

            return await funcionario.ToListAsync();
        }

    }
}
