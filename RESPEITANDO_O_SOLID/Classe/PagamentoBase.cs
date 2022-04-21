using System;

namespace RESPEITANDO_O_SOLID.Classe
{
    public abstract class PagamentoBase
    {
        public decimal PercentualDeDesconto { get; set; }
        public abstract void EfetuaPagamento(decimal quantidadeASerPaga, TipoPagamento jeitoQueAPessoaEstaPagando);
        public void EmiteInformacaoNoConsole(TipoPagamento jeitoQueAPessoaEstaPagando, decimal quantidadeASerPaga, decimal desconto)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine($"Tipo de pagamento: {jeitoQueAPessoaEstaPagando.ToString()}");
            Console.WriteLine($"O pagamento terá {desconto * 100}% de desconto, o valor a ser pago é: {quantidadeASerPaga}");
            Console.WriteLine("Obrigado pela compra!");
            Console.WriteLine("=============================");
            Console.WriteLine();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

