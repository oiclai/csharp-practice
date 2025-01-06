/*
defina múltiplas versões de um método (ou de um operador) dentro da mesma classe
- OS METODOS TEM O MESMO NOME E DIFERENTES PARAEMTROS (diferentes assinaturas)
* diferenciando quantidade de parametro, tipo ou ordem dos parâmetros
*/

namespace Course {
    class Produto {
        public string Nome;
        public double Preco;
        public int Quantidade;
    
        public Produto(){
            // possibilita classe ser instanciada sem argumentos
        }

        public Produto (string nome, double preco, int quantidade) {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade; // quantidade mencionada = tem valor
        }

        public Produto (string nome, double preco) {
            Nome = nome;
            Preco = preco;
            Quantidade = 0; // ser quantidade nao foi informada, entao e 0
        }
    }
}