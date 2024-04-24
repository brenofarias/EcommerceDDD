using ApplicationApp.Interface;
using Entities.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Web_ECommerce.Controllers
{
    [Authorize]
    public class ProdutosController : Controller
    {
        public readonly UserManager<ApplicationUser> _userManager;

        public readonly InterfaceProductApp _InterfaceProductApp;
        public ProdutosController(InterfaceProductApp interfaceProductApp, UserManager<ApplicationUser> userManager) 
        { 
            _InterfaceProductApp = interfaceProductApp;
            _userManager = userManager;
        }

        // GET: ProdutosController
        public async Task<IActionResult> Index()
        {
            return View(await _InterfaceProductApp.List());
        }

        // GET: ProdutosController/Details/5
        public async Task<IActionResult> Details(int id)
        {
            return View(await _InterfaceProductApp.GetEntityById(id));
        }

        // GET: ProdutosController/Create
        public async Task<IActionResult> Create()
        {
            return View();
        }

        // POST: ProdutosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Produto produto)
        {
            try
            {
                // Informando o usuário que criou o produto
                var idUsuario = await RetornarIdUsuarioLogado();

                produto.UserId = idUsuario;

                await _InterfaceProductApp.AddProduct(produto);

                // Verifica se teve algum erro
                if (produto.Notifications.Any())
                {
                    // ForEach para pegar todos os erros do produto
                    foreach (var item in produto.Notifications)
                    {
                        ModelState.AddModelError(item.NomePropriedade, item.Mensagem);
                    }

                    return View("Edit", produto);
                }
            }
            catch
            {
                return View("Edit", produto);
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: ProdutosController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            return View(await _InterfaceProductApp.GetEntityById(id));
        }

        // POST: ProdutosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Produto produto)
        {
            try
            {
                await _InterfaceProductApp.UpdateProduct(produto);

                // Verifica se teve algum erro
                if (produto.Notifications.Any())
                {
                    // ForEach para pegar todos os erros do produto
                    foreach (var item in produto.Notifications)
                    {
                        ModelState.AddModelError(item.NomePropriedade, item.Mensagem);
                    }

                    return View("Edit", produto);
                }
            }
            catch
            {
                return View("Edit", produto);
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: ProdutosController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            return View(await _InterfaceProductApp.GetEntityById(id));
        }

        // POST: ProdutosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, Produto produto)
        {
            try
            {
                var produtoDeletar = await _InterfaceProductApp.GetEntityById(id);

                await _InterfaceProductApp.Delete(produtoDeletar);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        private async Task<string> RetornarIdUsuarioLogado()
        {
            var idUsuario = await _userManager.GetUserAsync(User);

            return idUsuario.Id;
        }
    }
}
