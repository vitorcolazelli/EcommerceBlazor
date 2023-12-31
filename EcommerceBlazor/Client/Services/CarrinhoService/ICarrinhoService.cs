﻿namespace EcommerceBlazor.Client.Services.CarrinhoService
{
    public interface ICarrinhoService
    {
        event Action OnChange;
        Task AddToCart(ItemCarrinho itemCarrinho);
        Task<List<CarrinhoProdutoResponse>> GetProdutosCarrinho();
        Task RemoverItemCarrinho(int produtoId, int tipoProdutoId);
        Task AtualizarQuantidade(CarrinhoProdutoResponse produto);
        Task GravarItensCarrinho(bool carrinhoLocalVazio);
        Task GetQuantidadeItens();
    }
}
