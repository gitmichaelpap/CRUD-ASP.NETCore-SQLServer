using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testeContSelf.Models;

namespace testeContSelf.Data
{
    public class SeedingService
    {
        private testeContSelfContext _context;

        public SeedingService(testeContSelfContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Funcionario.Any())
            {
                return; //DB já foi populado.
            }

            Funcionario f1 = new Funcionario { Nome = "João da Silva", DataNascimento = new DateTime(1987,01,14), Salario = 800, Atividades = "Desenvolvedor" };
            Funcionario f2 = new Funcionario { Nome = "Pedro da Silva", DataNascimento = new DateTime(1995,07,15), Salario = 900, Atividades = "Desenvolvedor" };
            Funcionario f3 = new Funcionario { Nome = "Joana da Silva", DataNascimento = new DateTime(1998,01,13), Salario = 1200, Atividades = "Desenvolvedor" };
            Funcionario f4 = new Funcionario { Nome = "Michael Pacheco", DataNascimento = new DateTime(1994,05,03), Salario = 3000, Atividades = "Desenvolvedor Junior" };

            _context.Funcionario.AddRange(f1, f2, f3, f4);

            _context.SaveChanges();
        }
    }
}
