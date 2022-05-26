using System;

namespace DIO.Series
{
    public class Serie : EntidadeBase
    {	
        // Métodos
		public Serie(int id, Genero genero, string titulo, string descricao, int ano)
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