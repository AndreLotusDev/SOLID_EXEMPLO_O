namespace RESPEITANDO_O_SOLID.Classe
{
    public class DinheiroPagamento : PagamentoBase
    {
        public override void EfetuaPagamento(decimal quantidadeASerPaga, TipoPagamento jeitoQueAPessoaEstaPagando)
        {
            PercentualDeDesconto = 0.2m; //20% CENTO

            var desconto = (PercentualDeDesconto * quantidadeASerPaga);
            quantidadeASerPaga = quantidadeASerPaga - desconto;

            EmiteInformacaoNoConsole(jeitoQueAPessoaEstaPagando, quantidadeASerPaga, PercentualDeDesconto);
        }
    }
}
