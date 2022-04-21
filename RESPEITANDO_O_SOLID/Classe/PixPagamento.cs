namespace RESPEITANDO_O_SOLID.Classe
{
    public class PixPagamento : PagamentoBase
    {
        public override void EfetuaPagamento(decimal quantidadeASerPaga, TipoPagamento jeitoQueAPessoaEstaPagando)
        {
            PercentualDeDesconto = 0.1m; // 10% POR CENTO

            var desconto = (PercentualDeDesconto * quantidadeASerPaga);
            quantidadeASerPaga = quantidadeASerPaga - desconto;

            EmiteInformacaoNoConsole(jeitoQueAPessoaEstaPagando, quantidadeASerPaga, PercentualDeDesconto);
        }
    }
}
