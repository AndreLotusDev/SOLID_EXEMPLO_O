using NAO_RESPEITANDO_O_SOLID.Classe;
using System;

namespace NAO_RESPEITANDO_O_SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new Pagamento().EfetuaPagamento(300, TipoPagamento.CARTAO);
            new Pagamento().EfetuaPagamento(300, TipoPagamento.PIX);
            new Pagamento().EfetuaPagamento(300, TipoPagamento.EM_DINHEIRO);
            new Pagamento().EfetuaPagamento(300, TipoPagamento.BOLETO);
            new Pagamento().EfetuaPagamento(300, TipoPagamento.PIX2);

            Console.ReadKey();
        }
    }
}
