using System;
/*
OPÇÃO 1 DE IMPLEMNENTAR O ENCAPSULAMENTO

- todo atributo é definido como private
- implementa-se metodo Get e Set
# GET : obter -> acessar o valor do atributo
# SET : definir -> alterar o valor do atributo
obs: n costuma ser usado no C#
*/


namespace Course {
    class Produto {
        private string _nome;
        private string _preco;
        private string _quantidade;

        public Produto(){
        }
        public Produto(string nome, string preco, string quantidade){
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }
        // -------------------------------------------------
        public string GetNome() {
            return _nome;
        }
        public void SetNome(string nome){
            if (nome != null && nome.Length > 1)
                _nome = nome;
        }
        public void SetPreco(string preco){
            _preco = preco;
        }
        public string GetPreco() {
            return _preco;
        }
        // -------------------------------------------------
        public double ValorTotalEmEstoque() {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade) {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) {
            _quantidade -= quantidade;
        }
        public override string ToString(){
            return_nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
            }
    }
    class Program {
        public static void Main(string[] args) {
            Produto p = new Produto("TV", "500.00", "10");
            p.SetNome("TV 4K");
            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.SetPreco());
        }
    }
}



