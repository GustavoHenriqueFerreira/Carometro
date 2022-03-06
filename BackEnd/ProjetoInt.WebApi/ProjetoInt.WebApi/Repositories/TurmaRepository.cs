﻿using ProjetoInt.WebApi.Contexts;
using ProjetoInt.WebApi.Domains;
using ProjetoInt.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoInt.WebApi.Repositories
{
    public class TurmaRepository : ITurmaRepository
    {
        carometroContext ctx = new carometroContext();
        public List<Aluno> BuscarPorTurma(int idTurma)
        {
            return ctx.Alunos.Where(x => x.IdTurma == idTurma).ToList();

        }

        public List<Turma> Listar()
        {
            return ctx.Turmas.ToList();
        }
<<<<<<< HEAD
=======

     
>>>>>>> 9663c9e93e0ea28f8cdf33eac6449844b9073a83
    }
}
