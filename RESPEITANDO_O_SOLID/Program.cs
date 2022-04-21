using RESPEITANDO_O_SOLID.Classe;
using System;

namespace RESPEITANDO_O_SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new CartaoPagamento().EfetuaPagamento(300, TipoPagamento.CARTAO);
            new PixPagamento().EfetuaPagamento(300, TipoPagamento.PIX);
            new BoletoPagamento().EfetuaPagamento(300, TipoPagamento.BOLETO);
            new DinheiroPagamento().EfetuaPagamento(300, TipoPagamento.DINHEIRO);
            new Pix2Pagamento().EfetuaPagamento(1000, TipoPagamento.PIX2);

            Console.ReadKey();
        }
    }
}
