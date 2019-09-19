using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace prova
{
    class Menu
    {
        public string Nome { get; set; }
        public int Senha { get; set; }
        public int Id { get; set; }
        public float Data { get; set; }


        public Menu(string nome, int senha, int id, float data)
        {
            Nome = nome;
            Senha = senha;
            Id = id;
            Data = data;
        }

        public void alteraNome(string novoNome)
        {
            Nome = novoNome;
        }
        public void alterarSenha(int novaSenha)
        {
            Senha = novaSenha;
        }
        public void alterarId(int novoId)
        {
            Id = novoId;
        }
        public void alterarData(float novaData)
        {
            Data = novaData;
        }
        
           
        
    }
}
