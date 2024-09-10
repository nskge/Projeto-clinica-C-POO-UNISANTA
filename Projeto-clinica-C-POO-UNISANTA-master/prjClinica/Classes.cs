using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjClinica
{
    public abstract class Pessoa_Fisica
    {
        public string nome { get; private set; }
        public DateTime dataNascimento { get; private set;}
        public char sexo { get; private set;}
        public string cpf { get; private set;}
        public string email { get; set;}

        public Pessoa_Fisica(string nome, DateTime dataNascimento, char sexo, string cpf)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.sexo = sexo;
            this.email = "";
            this.dataNascimento = dataNascimento;
        }
    }

    public class IMC
    {
        public float peso { get; private set; }
        public float altura { get; private set; }

        public IMC(float peso, float altura)
        {
            this.peso = peso;
            this.altura = altura;
        }
        public float imc() { return peso/(altura * altura); }
        public string Diagnostico()
        {
            if (imc() < 16.9){
                return "| Muito abaixo do peso";

            }
            if (imc() >= 17 && imc() <= 18.4 )
            {
                return "| abaixo do peso";

            }
            if (imc() >= 18.5 && imc() <= 24.9)
            {
                return "| peso normal";

            }
            if (imc() >= 25 && imc() <= 29.9)
            {
                return "| acima do peso";

            }
            if (imc() >= 30 && imc() <= 34.9)
            {
                return "| obesidade grau 1";

            }
            if (imc() >= 35 && imc() <= 40)
            {
                return "| obesidade grau 2";

            }
            if (imc() >= 40)
            {
                return "| obesidade grau 3";

            }
            else
            {
                return "| IMC INVALIDO";
            }
            
              
            
        }
    }

    public class Paciente : Pessoa_Fisica
    {
        public Paciente(string nome, DateTime dataNascimento, char sexo, string cpf, float peso, float altura, string matricula) : base(nome, dataNascimento, sexo, cpf)
        {
            this.imc = new IMC(peso, altura);
            this.matricula = matricula;
        }

        public float valorIMC() { return imc.imc(); }

        public float peso() { return imc.peso; }

        public float altura() { return imc.altura; }

        private IMC imc;

        public string matricula { get; private set; }

        public override string ToString()
        {

            return nome + " | SEXO: " +
                sexo + " | PESO: " +
                imc.peso + " | ALTURA: " +
                imc.altura + " | CPF: " +
                cpf + " | EMAIL: " +
                email + " | ANO DE NAS.:  " +
                dataNascimento.Year  + " | MATRICULA:  " +
                matricula + " |  IMC: " + 
                imc.imc() + " |" + imc.Diagnostico() + "\n";
        }
    }

    public class Usuario : Pessoa_Fisica
    {
        private string senha;
        public string user { get; private set; }
        public char perfil { get; private set; }

        public Usuario(string nome, DateTime dataNascimento, string cpf, string senha, char sexo, string user, char perfil) : base(nome, dataNascimento, sexo, cpf)
        {
            this.user = user;
            this.perfil = perfil;
            this.senha = senha;
        }
    }
}
