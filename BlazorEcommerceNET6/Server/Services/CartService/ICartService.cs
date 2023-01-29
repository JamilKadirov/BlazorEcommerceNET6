using BlazorEcommerceNET6.Shared.DTO;

namespace BlazorEcommerceNET6.Server.Services.CartService
{
    public interface ICartService
    {
        Task<ServiceResponse<List<CartProductResponse>>> GetCartProducts(List<CartItem> cartItems);
    }
}
