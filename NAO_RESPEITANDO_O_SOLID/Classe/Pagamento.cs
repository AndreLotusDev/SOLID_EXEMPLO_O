using System;

namespace NAO_RESPEITANDO_O_SOLID.Classe
{
    public enum TipoPagamento
    {
        BOLETO,
        PIX,
        EM_DINHEIRO,
        CARTAO,
        PIX2
    }
    public class Pagamento
    {
        public void EfetuaPagamento(decimal quantidadeASerPaga, TipoPagamento jeitoQueAPessoaEstaPagando)
        {
            if (jeitoQueAPessoaEstaPagando == TipoPagamento.BOLETO)
            {
                const decimal DESCONTO_EM_BOLETO = 20; //POR CENTO

                decimal valorDeDesconto = quantidadeASerPaga * (DESCONTO_EM_BOLETO / 100);
                quantidadeASerPaga = quantidadeASerPaga - valorDeDesconto;

                EmiteInformacaoNoConsole(jeitoQueAPessoaEstaPagando, quantidadeASerPaga, DESCONTO_EM_BOLETO);
            }
            else if (jeitoQueAPessoaEstaPagando == TipoPagamento.EM_DINHEIRO)
            {
                const decimal DESCONTO_EM_DINHEIRO = 15; //POR CENTO

                decimal valorDeDesconto = quantidadeASerPaga * (DESCONTO_EM_DINHEIRO / 100);
                quantidadeASerPaga = quantidadeASerPaga - valorDeDesconto;

                EmiteInformacaoNoConsole(jeitoQueAPessoaEstaPagando, quantidadeASerPaga, DESCONTO_EM_DINHEIRO);
            }
            else if (jeitoQueAPessoaEstaPagando == TipoPagamento.PIX)
            {
                const decimal DESCONTO_EM_PIX = 10;

                decimal valorDeDesconto = quantidadeASerPaga * (DESCONTO_EM_PIX / 100);
                quantidadeASerPaga = quantidadeASerPaga - valorDeDesconto;

                EmiteInformacaoNoConsole(jeitoQueAPessoaEstaPagando, quantidadeASerPaga, DESCONTO_EM_PIX);
            }
            else if (jeitoQueAPessoaEstaPagando == TipoPagamento.CARTAO)
            {
                const decimal DESCONTO_NO_CARTAO = 5;

                decimal valorDeDesconto = quantidadeASerPaga * (DESCONTO_NO_CARTAO / 100);
                quantidadeASerPaga = quantidadeASerPaga - valorDeDesconto;

                EmiteInformacaoNoConsole(jeitoQueAPessoaEstaPagando, quantidadeASerPaga, DESCONTO_NO_CARTAO);
            }
            else
            {
                const decimal DESCONTO_NO_PIX_2 = 1;

                decimal valorDeDesconto = quantidadeASerPaga * (DESCONTO_NO_PIX_2 / 100);
                quantidadeASerPaga = quantidadeASerPaga - valorDeDesconto;

                EmiteInformacaoNoConsole(jeitoQueAPessoaEstaPagando, quantidadeASerPaga, DESCONTO_NO_PIX_2);
            }
        }

        public void EmiteInformacaoNoConsole(TipoPagamento jeitoQueAPessoaEstaPagando, decimal quantidadeASerPaga, decimal desconto)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine($"Tipo de pagamento: {jeitoQueAPessoaEstaPagando.ToString()}");
            Console.WriteLine($"O pagamento terá {desconto}% de desconto, o valor a ser pago é: {quantidadeASerPaga}");
            Console.WriteLine("Obrigado pela compra!");
            Console.WriteLine("=============================");
            Console.WriteLine();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
