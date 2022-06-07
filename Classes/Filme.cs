using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO.Series
{
    public class Filme : EntidadeBase
    {
        public Filme(int id, Genero genero, string titulo, string descricao, int ano)
		{
			this.Id = id;
			this.Genero = genero;
			this.Titulo = titulo;
			this.Descricao = descricao;
			this.Ano = ano;
            this.Excluido = false;
		}
    }
}