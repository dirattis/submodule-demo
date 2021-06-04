using System;

namespace Rattis.Investments.Domain.Entities
{
    public class Cliente
    {
        public string CPF { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
