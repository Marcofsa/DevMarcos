using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_App
{
    public enum TipoGenero { Acao, Aventura, Casual, Puzze, Estrategia, Outro }
    public enum TipoConsole { PS4, PS5, Switch, Xbox_One, Xbox_SeriesX,Xbox_SeriesS, PC, Outro }

    public class Jogos
    {
        public Jogos()
        {
            this.Id = 1;
            this.Nome = "";
            this.Descricao = "";
            this.Genero = TipoGenero.Outro;
            this.Console = TipoConsole.Outro;
        }

        public Jogos(int id, String nome, String descricao, TipoGenero genero, TipoConsole console)
        {
            this.Id = id;
            this.Nome = nome;
            this.Descricao = descricao;
            this.Genero = genero;
            this.Console = console;
        }

        private int id;

        public int Id
        {
            get { return id; }
            set
            {
                if (value > 0) id = value;
                else
                {
                    throw new Exception("Permitido apenas numeros positivos!!!!");
                }
            }
        }

        private String nome;

        public String Nome
        {
            get { return nome; }
            set { nome = value.ToUpper(); }
        }

        private String descricao;

        public String Descricao
        {
            get { return descricao; }
            set { descricao = value.ToUpper(); }
        }

        public TipoConsole Console { get; set; }
        public TipoGenero Genero { get; set; }
    }
}
