using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Cadastro_de_funcionarios
{
    class Funcionario
    {
        public string Nome,Genero,Profissao,EstCiv,SangTip,Endereço,Email,Idade, Salario, Telefone, Filhos;
     
        public void setup(string N, string P,string S,string Est,string St,string End,string Em,string I, string Sal, string T, string Nf)
        {
            Nome = N;
            Profissao = P;
            Genero = S;
            EstCiv = Est;
            SangTip = St;
            Endereço = End;
            Email = Em;
            Idade = I;
            Salario = Sal;
            Telefone = T;
            Filhos = Nf;
        }

        public string ToText()
        {
            return (Nome + "#" + Profissao + "#" + Genero + "#" + EstCiv + "#" + SangTip + "#" +  
                Endereço + "#" + Email + "#" + Idade + "#" + Salario + "#" + Telefone + "#" + Filhos);
        }

        public void BackFromText(string line)
        {
            string[] prop = line.Split('#');
            if(prop.Length == 11)
            setup(prop[0],prop[1],prop[2],prop[3],prop[4],prop[5],prop[6],prop[7],prop[8],prop[9],prop[10]);
        }

        
    }
}
