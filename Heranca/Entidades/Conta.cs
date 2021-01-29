using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca.Entidades {
    class Conta {

        public int Numero { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; protected set; }

        public Conta() {
        }

        public Conta(int numero, string titular, double saldo) {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public void Saque(double quantia) {
            Saldo -= quantia;
        }

        public void Deposito(double quantia) {
            Saldo += quantia;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Numero da conta: " + Numero);
            sb.AppendLine("Titular da Conta: " + Titular);
            sb.AppendLine("Saldo da conta: " + Saldo);
            

            return sb.ToString();
        }
    }
}
