using ListaLeitura.Data;
using ListaLeitura.Models;
using Microsoft.AspNetCore.Mvc;

namespace ListaLeitura.Controllers
{
    public class ListaLeituraController : Controller
    {
        private readonly AppDbContext _context;

        public ListaLeituraController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<ListaLeituraModel> listaLeitura = _context.ListaLeituras;

            return View(listaLeitura);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(ListaLeituraModel listaLeitura)
        {
            if(ModelState.IsValid)
            {
                _context.ListaLeituras.Add(listaLeitura);
                _context.SaveChanges();

                TempData["MensagemSucesso"] = "Cadastro realizado com sucesso";

                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Editar(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }

            ListaLeituraModel listaLeitura = _context.ListaLeituras.FirstOrDefault(x => x.Id == id);

            if(listaLeitura == null)
            {
                return NotFound();
            }

            return View(listaLeitura);
        }

        [HttpPost]
        public IActionResult Editar(ListaLeituraModel listaLeituraModificada)
        {
            if(ModelState.IsValid)
            {
                _context.ListaLeituras.Update(listaLeituraModificada);
                _context.SaveChanges();

                TempData["MensagemSucesso"] = "Editado com sucesso";

                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Excluir(int? id) 
        { 
            if(id == null || id == 0)
            {
                return NotFound();
            }

            ListaLeituraModel listaLeitura = _context.ListaLeituras.FirstOrDefault(x => x.Id == id);

            return View(listaLeitura);
        }

        [HttpPost]
        public IActionResult Excluir(ListaLeituraModel listaLeitura)
        {
            if(ModelState.IsValid)
            {
                _context.ListaLeituras.Remove(listaLeitura);
                _context.SaveChanges();

                TempData["MensagemSucesso"] = "Excluído com sucesso";

                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
