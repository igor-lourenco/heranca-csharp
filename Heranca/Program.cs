using Heranca.Entidades;
using System;

namespace Heranca {
    class Program {
        static void Main(string[] args) {

            EmpresaConta conta = new EmpresaConta(8010, "Igor Lourenco", 100.0, 500.0);

            Console.WriteLine(conta);
        }
    }
}
