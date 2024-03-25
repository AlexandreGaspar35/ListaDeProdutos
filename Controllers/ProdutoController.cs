using ListaDeProdutos.DataContext;
using ListaDeProdutos.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace ListaDeProdutos.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly AplicationContext _context;
        public ProdutoController(AplicationContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<ProdutoModel> produtos = _context.Produtos;

            return View(produtos);
        }
        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(ProdutoModel produto)
        {
            if(ModelState.IsValid)
            {
                produto.Data = DateTime.Now;

                _context.Produtos.Add(produto);
                _context.SaveChanges();
                TempData["MensagemSucesso"] = "Cadastro realizado com sucesso!";

                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
