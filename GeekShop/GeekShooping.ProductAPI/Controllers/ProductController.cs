using GeekShooping.ProductAPI.Data.DTO;
using GeekShooping.ProductAPI.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GeekShooping.ProductAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductRepository _repo;
        public ProductController(IProductRepository repo)
        {
            _repo = repo ?? throw new 
                ArgumentNullException(nameof(repo));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDTO>> GetById(long id)
        {
            try
            {
                var product = await _repo.GetById(id);

                if (product.Id <= 0) return NotFound();

                return Ok(product);
            }
            catch (Exception error)
            {
                return BadRequest(error);
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDTO>>> FindAll()
        {
            try
            {
                var products = await _repo.FindAll();

                if (products == null) return NotFound();

                return Ok(products);
            }
            catch (Exception error)
            {
                return BadRequest(error);
            }
        }

        [HttpPost]
        public async Task<ActionResult<ProductDTO>> Create([FromForm] ProductDTO newProduct)
        {
            try
            {
                if (newProduct == null)
                {
                    return BadRequest("Forneça todos os dados para cadastro do produto!");
                }
                var product = await _repo.Create(newProduct);

                if (product == null) return NotFound();

                return Ok("Produto cadastrado com sucesso!");
            }
            catch (Exception error)
            {
                return BadRequest(error);
            }
        }

        [HttpPut]
        public async Task<ActionResult<ProductDTO>> Update([FromForm] ProductDTO updProduct)
        {
            try
            {
                if (updProduct == null)
                {
                    return BadRequest("Forneça todos os dados para atualização do produto!");
                }
                var product = await _repo.Update(updProduct);

                if (product == null) return NotFound();

                return Ok("Produto atualizado com sucesso!");
            }
            catch (Exception error)
            {
                return BadRequest(error);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(long id)
        {
            try
            {
                var status = await _repo.Delete(id);

                if (!status) return BadRequest();

                return Ok(status);
            }
            catch (Exception error)
            {
                return BadRequest(error);
            }
        }
    }
}
