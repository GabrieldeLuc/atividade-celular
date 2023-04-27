using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_Celular
{
    public class Celular
    {
        public string cor;
        public string modelo;

        public float tamanho;

        public bool ligado;

        public int chamada;

        public string mensagem;

        public string pessoa;

        public string ligação;


        public string desligar;

       public string ligar;
      
       public string EnviarMensagem;

  public void Ligar()
        {
            ligado = true;
        }

        public void Desligar()
        {
        ligado = false;
        }

        public void Chamar(int numero)
        {
            chamada = numero;
        }

        public void EMensagem(string para, string mensagem)
        {
            pessoa = para;
            this.mensagem = mensagem;
        }
    }
}



    





