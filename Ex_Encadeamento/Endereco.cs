using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Encadeamento
{
    internal class Endereco
    {
        string cep;
        string localidade;
        string uf;
        string logradouro;
        string tipoLogradouro;
        string bairro;
        int numero;
        string complemento;

        public Endereco(string cep, string localidade, string uf, string logradouro, string tipoLogradouro, string bairro, int numero, string complemento)
        {
            this.cep = cep;
            this.localidade = localidade;
            this.uf = uf;
            this.logradouro = logradouro;
            this.tipoLogradouro = tipoLogradouro;
            this.bairro = bairro;
            this.numero = numero;
            this.complemento = complemento;
        }

        public override string? ToString()
        {
            return $"Endereço: \nCEP: {cep}\nLocalidade: {localidade}\nUF: {uf}\nLogradouro {tipoLogradouro} {logradouro}" +
                $"\nBairro: {bairro}\nNumero: {numero}\nComplemento: {complemento}";
        }
    }
}
