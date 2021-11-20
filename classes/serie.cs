using System;

namespace DIO.APPseries
{
    public class serie : entidadebase
    {
        //Atributos
        private Genero Genero {get; set;}
        private string Titulo {get; set;}
        private string Descrição {get; set;}
        private int Ano {get; set;}
        private bool Excluido {get; set;}

        //Métodos
        public serie(int id, Genero genero, string titulo, string descrição, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descrição = descrição;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descrição + Environment.NewLine;
            retorno +="Ano de início: " + this.Ano + Environment.NewLine;
            retorno += "Excluído: " + this.Excluido;
            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }
        public bool retornaExcluido()
        {
            return this.Excluido;
        }
        public int retornaId()
        {
            return this.Id;
        }
        public void Excluir()
        {
            this.Excluido = true;
        }
    }
}