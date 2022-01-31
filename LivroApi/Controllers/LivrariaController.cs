using LivroApi.Data;
using LivroApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivrariaController : ControllerBase
    {
        public readonly LivroContext _context;

        public LivrariaController(LivroContext context)
        {
            _context = context;

            _context.Livros.Add(new Livro { Nome = "Book1", Preco = 24.00M, Quantidade = 1, Categoria = "Acao", Img = "img1" });
            _context.Livros.Add(new Livro { Nome = "Book2", Preco = 50.00M, Quantidade = 1, Categoria = "Terror", Img = "img2" });
            _context.Livros.Add(new Livro { Nome = "Book3", Preco = 100.00M, Quantidade = 3, Categoria = "Aventura", Img = "img3" });

            _context.SaveChanges();
        }

        [HttpPost]
        public async Task<ActionResult<Livro>> PostProduct(Livro livros)
        {
            _context.Livros.Add(livros);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetLivros), new { id = livros.Id }, livros);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Livro>>> GetLivros()
        {
            return await _context.Livros.ToListAsync();
        }

         [HttpGet("{id}")]
        public async Task<ActionResult<Livro>> GetItem(int id)
        {
           var item = await _context.Livros.FindAsync(id.ToString());

            if(item == null)
            {
                return NotFound();
            }

           return item;
        }
    }
}
