using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagemen
{
    public class Evento
    {
        public Evento(string nome, string local, double valor = 0)
        {
            Nome = nome;
            Local = local;
            Valor = valor;
            pessoas = new List<Pessoa>();
        }

        public string Nome {  get;  set; }
        public string Local { get; set; }
        public double Valor { get; set; }
        public List<Pessoa> pessoas { get; set; }
        public void AddPessoa(Pessoa pessoa)
        {
            if (pessoa is null)
                throw new ArgumentNullException(nameof(pessoa));

            if (pessoas.Count < 20)
            {
                pessoas.Add(pessoa);
                Console.WriteLine("A festa já tem: " + pessoas.Count + " pessoas");
            }
            else
            {
                Console.WriteLine("O limite de pessoas dessa festa já foi atingido: " + pessoas.Count);
            }
        }
    }
}
