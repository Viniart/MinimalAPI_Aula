using SENAI.MinimalAPI.Context;
using SENAI.MinimalAPI.Model;

namespace SENAI.MinimalAPI.Repository
{
    public class ProdutoRepository
    {
        ProdutoContext contexto = new ProdutoContext();

        List<Produto> listaProdutos = new()
        {
            new Produto()
            {
                Nome = "Produto 1",
                Categoria = "Categoria 1"
            },
            new Produto()
            {
                Nome = "Produto 2",
                Categoria = "Categoria 2"
            },
            new Produto()
            {
                Nome = "Produto 3",
                Categoria = "Categoria 3"
            }
        };

        public List<Produto> ListarProdutos()
        {
            return listaProdutos;
        }
        
        public void CadastrarProduto(Produto prod)
        {
            listaProdutos.Add(prod);
        }
    }
}
