using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca.Entidades {
    class EmpresaConta : Conta{

        public double EmprestimoLimite { get; set; }


        public EmpresaConta() {
        }

        public EmpresaConta(int numero, string titular, double saldo, double emprestimoLimite) : base(numero, titular, saldo) {

            EmprestimoLimite = emprestimoLimite;
        }

        public void Emprestimo(double quantia) {

            if (quantia <= EmprestimoLimite)
                Saldo += quantia;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Numero da conta: " + Numero);
            sb.AppendLine("Titular da Conta: " + Titular);
            sb.AppendLine("Saldo da conta: " + Saldo);
            sb.AppendLine("Limite de emprestimo: " + EmprestimoLimite);
            return sb.ToString();
        }
    }
}
