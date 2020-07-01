using System;

namespace _15_Interface_GUI
{
    public class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; private set; }
        public Cliente Titular { get; internal set; }

        internal void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        internal void Saca(double valor)
        {
            this.Saldo -= valor;
        }
    }
}