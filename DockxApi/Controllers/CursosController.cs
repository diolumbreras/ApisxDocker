using Datadock;
using DockxApi.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DockxApi.Controllers
{
    [Route("/api/curso")]
    [ApiController]
    public class CursosController : ControllerBase
    {
        private readonly DataContext _datacontext;
        public CursosController(DataContext datacontext)
        {
            _datacontext = datacontext;
        }
        [HttpPost]
        public async Task<ActionResult> Post(Cursos curso)
        {
            _datacontext.Cursos.Add(curso);
            await _datacontext.SaveChangesAsync();
            return Ok(curso);
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _datacontext.Cursos.ToListAsync());
        }
    }
}
