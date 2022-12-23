using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_App
{
    public class ListaDeJogos
    {

        private List<Jogos> jogos;
        public List<Jogos> Jogos
        {
            get
            {
                return jogos;
            }
        }

        public ListaDeJogos()
        {
            jogos = new List<Jogos>();
        }

        public Boolean Inserir(Jogos jogo)
        {
            Boolean resultado = true;
            try
            {
                Jogos j = jogos.Find(x => x.Id == jogo.Id);
                if (j == null)
                {
                    jogos.Add(jogo);
                }
                else
                {
                    resultado = false;
                }
            }
            catch (Exception erro)
            {
                resultado = false;
            }
            return resultado;
        }
        public Boolean Alterar(Jogos jogo)
        {
            Boolean resultado = false;
            Jogos j = jogos.Find(x => x.Id == jogo.Id);
            if (j != null)
            {
                j.Nome = jogo.Nome;
                j.Descricao = jogo.Descricao;
                j.Genero = jogo.Genero;
                j.Console = jogo.Console;
                resultado = true;
            }
            return resultado;
        }
        public Boolean Excluir(int id)
        {
            Boolean resultado = false;
            Jogos j = jogos.Find(x => x.Id == id);
            if (j != null)
            {
                resultado = jogos.Remove(j);
            }
            return resultado;
        }
        public List<Jogos> Localizar(String nome)
        {
            List<Jogos> lj = jogos.FindAll(x => x.Nome.Contains(nome.ToUpper()));
            return lj;
        }

        public List<Jogos> ListarPorGenero(TipoGenero genero)
        {
            List<Jogos> lj = jogos.FindAll(x => x.Genero.Equals(genero));
            return lj;
        }

        public List<Jogos> ListarPorConsole(TipoConsole console)
        {
            List<Jogos> lj = jogos.FindAll(x => x.Console.Equals(console));
            return lj;
        }

    }


}
