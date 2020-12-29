using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testeContSelf.Data;
using testeContSelf.Models;

namespace testeContSelf.Services
{
    public class PesquisaServices
    {
        private readonly testeContSelfContext _context;

        public PesquisaServices(testeContSelfContext context)
        {
            _context = context;
        }

        public List<Funcionario> FindAll()
        {
            return _context.Funcionario.ToList();
        }

    }
}
