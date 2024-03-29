﻿using ProjetoInt.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoInt.WebApi.Interfaces
{
    public interface ITurmaRepository
    {
        public List<Aluno> BuscarPorTurma(int idTurma);

        List<Turma> Listar();

    }
}
