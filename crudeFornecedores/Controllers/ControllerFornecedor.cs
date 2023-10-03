using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using crudeFornecedores.Models;
using Microsoft.AspNetCore.Mvc;
using static crudeFornecedores.Controllers.ControllerFornecedor;

namespace crudeFornecedores.Controllers
{
    public class ControllerFornecedor : Controller
    {

        private List<Fornecedor> Fornecedores = new List<Fornecedor>
        {
          
            new Fornecedor { Id = 1, RazaoSocial = "Empresa A", NomeFantasia = "Empresa A", Email = "empresaA@email.com", Telefone = "123-456-7890", EnderecoCompleto = "Endereço A", PessoaContato = "Contato A" },
            new Fornecedor { Id = 2, RazaoSocial = "Empresa B", NomeFantasia = "Empresa B", Email = "empresaB@email.com", Telefone = "987-654-3210", EnderecoCompleto = "Endereço B", PessoaContato = "Contato B" }
        };

        internal class Fornecedor
        {
            internal int Id;
            internal string RazaoSocial;
            internal string NomeFantasia;
            internal string Email;
            internal string Telefone;
            internal string EnderecoCompleto;
            internal string PessoaContato;

            internal static object FirstOrDefault(Func<object, bool> value)
            {
                throw new NotImplementedException();
            }
        }

        
        public ActionResult Index(object fornecedores)
        {
            return ViewResult(fornecedores);
        }

        private ActionResult ViewResult(object fornecedores)
        {
            throw new NotImplementedException();
        }

        private ActionResult View(object fornecedores)
        {
            throw new NotImplementedException();
        }

        
        public ActionResult Create()
        {
            return View();
        }

        
        [HttpPost]

        
        public ActionResult Edit(int id)
        {
            
           var fornecedor = Fornecedor.FirstOrDefault(f => f.Id == id);
            if (fornecedor == null)
            {
                return HttpNotFound();
            }
            return View(fornecedor);
        }

        private ActionResult HttpNotFound()
        {
            throw new NotImplementedException();
        }

        
        [HttpPost]

       
        public ActionResult Delete(int id)
        {
            
            var fornecedor = Fornecedores.FirstOrDefault(f => f.Id == id);
            if (fornecedor == null)
            {
                return HttpNotFound();
            }
            return View(fornecedor);
        }

        
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            
            return RedirectToAction("Index");
        }
    }
}