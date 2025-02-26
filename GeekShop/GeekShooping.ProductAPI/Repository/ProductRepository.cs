using AutoMapper;
using GeekShooping.ProductAPI.Data.DTO;
using GeekShooping.ProductAPI.Interface;
using GeekShooping.ProductAPI.Model;
using GeekShooping.ProductAPI.Model.Context;
using Microsoft.EntityFrameworkCore;

namespace GeekShooping.ProductAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly GSContext _ctx;
        private IMapper _mapper;
        public ProductRepository(GSContext ctx, IMapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;
        }

        public async Task<ProductDTO> Create(ProductDTO product)
        {
            Product newProduct = _mapper.Map<Product>(product);

            _ctx.Products.Add(newProduct);

            await _ctx.SaveChangesAsync();

            return _mapper.Map<ProductDTO>(newProduct);
        }

        public async Task<IEnumerable<ProductDTO>> FindAll()
        {
            List<Product> products = await _ctx.Products.ToListAsync();
            
            return _mapper.Map<List<ProductDTO>>(products);
        }

        public async Task<ProductDTO> GetById(long id)
        {
            Product product = await _ctx.Products
                                    .Where(p => p.Id == id)
                                    .FirstOrDefaultAsync() ?? new Product;

            return _mapper.Map<ProductDTO>(product);
        }

        public async Task<ProductDTO> Update(ProductDTO product)
        {
            Product updProduct = _mapper.Map<Product>(product);

            _ctx.Products.Update(updProduct);

            await _ctx.SaveChangesAsync();

            return _mapper.Map<ProductDTO>(updProduct);
        }
        public async Task<bool> Delete(long id)
        {
            try
            {
                Product product = await _ctx.Products
                                    .Where(p => p.Id == id)
                                    .FirstOrDefaultAsync() ?? new Product;

                if (product.Id <= 0) return false;

                _ctx.Products.Remove(product);
                await _ctx.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
