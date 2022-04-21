namespace RESPEITANDO_O_SOLID.Classe
{
    public class CartaoPagamento : PagamentoBase
    {
        public override void EfetuaPagamento(decimal quantidadeASerPaga, TipoPagamento jeitoQueAPessoaEstaPagando)
        {
            PercentualDeDesconto = 0.05m; // 15% POR CENTO

            var desconto = (PercentualDeDesconto * quantidadeASerPaga);
            quantidadeASerPaga = quantidadeASerPaga - desconto;

            EmiteInformacaoNoConsole(jeitoQueAPessoaEstaPagando, quantidadeASerPaga, PercentualDeDesconto);
        }
    }
}
