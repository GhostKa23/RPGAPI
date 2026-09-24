using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RpgApi.Data;
using RpgApi.Models;
using RPGAPI.Models;

namespace RPGAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArmasController : ControllerBase
    {
          private readonly DataContext _context;

          public ArmasController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetSingle(int id)
        {
            try
            {
                Arma? p = await _context.TB_ARMAS
                .FirstOrDefaultAsync(pBusca => pBusca.Id == id);

                return Ok(p);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetAll")]

        public async Task<IActionResult> Get()
        {
            try
            {
                List<Arma> lista = await _context.TB_ARMAS.ToListAsync();
                return Ok(lista);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add(Arma novaArma)
        {
            try
            {
                if (novaArma.Dano > 100)
                {
                    throw new Exception("Dano não pode ser maior que 100");
                }
                await _context.TB_ARMAS.AddAsync(novaArma);
                await _context.SaveChangesAsync();

                return Ok(novaArma.Id);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update(Arma novaArma)
        {
            try
            {
                if (novaArma.Dano > 100)
                {
                    throw new System.Exception("Dano não pode ser maior que 100");
                }
                _context.TB_ARMAS.Update(novaArma);
                int linhasAfetadas = await _context.SaveChangesAsync();

                return Ok(linhasAfetadas);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                Arma? pRemover = await _context.TB_ARMAS.FirstOrDefaultAsync(p => p.Id == id);

                _context.TB_ARMAS.Remove(pRemover);
                int linhaAfetadas = await _context.SaveChangesAsync();
                return Ok(linhaAfetadas);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



    }
}