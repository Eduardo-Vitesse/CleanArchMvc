using CleanArchMvc.Application.DTOs;
using CleanArchMvc.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchMvc.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProductDTO>>> Get()
    {
        var produtos = await _productService.GetProducts();
        if (produtos == null) return NotFound("Products not found");
        return Ok(produtos);
    }

    [HttpGet("{id:int}", Name = "GetProduct")]
    public async Task<ActionResult<ProductDTO>> Get(int id)
    {
        var produto = await _productService.GetById(id);
        if (produto == null) return NotFound("Products not found");
        return Ok(produto);
    }

    [HttpPost]
    public async Task<ActionResult> Post([FromBody] ProductDTO produtoDto)
    {
        if (produtoDto == null) return BadRequest("Data Invalid");

        await _productService.Add(produtoDto);

        return new CreatedAtRouteResult("GetProduct",
            new { id = produtoDto.Id }, produtoDto);
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult> Put(int id, [FromBody] ProductDTO produtoDto)
    {
        if (id != produtoDto.Id || produtoDto == null) return BadRequest("Data invalid");

        await _productService.Update(produtoDto);

        return Ok(produtoDto);
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult<ProductDTO>> Delete(int id)
    {
        var produtoDto = await _productService.GetById(id);

        if (produtoDto == null) return NotFound("Product not found");

        await _productService.Remove(id);

        return Ok(produtoDto);
    }

}
