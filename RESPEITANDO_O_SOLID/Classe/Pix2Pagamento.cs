using System;

namespace RESPEITANDO_O_SOLID.Classe
{
    class Pix2Pagamento : PagamentoBase
    {
        public override void EfetuaPagamento(decimal quantidadeASerPaga, TipoPagamento jeitoQueAPessoaEstaPagando)
        {
            PercentualDeDesconto = 0.01m; // 1% POR CENTO

            if(quantidadeASerPaga > 2000)
            {
                var desconto = (PercentualDeDesconto * quantidadeASerPaga);
                quantidadeASerPaga = quantidadeASerPaga - desconto;


                EmiteInformacaoNoConsole(jeitoQueAPessoaEstaPagando, quantidadeASerPaga, PercentualDeDesconto);
            }
            else
            {
                PoliticaDePagamentoPix2(quantidadeASerPaga);
            }
        }

        private void PoliticaDePagamentoPix2(decimal valorASerPago)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Não podemos dar desconto, para compras abaixo de 2000 reais com o PIX2 :c, valor a ser pago:  {valorASerPago}");
        }
    }
}
