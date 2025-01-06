using System.Globalization;

namespace Course{
    class Produto{
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(){
            Quantidade = 10;
        }
        public Produto(string nome, double preco) : this() {
            Nome = nome;
            Preco = preco;
        }
        public Produto (string nome, double preco, int quantidade) : this(nome, preco) {
            Quantidade = quantidade;            
        } 
    }
}
/*
class ChessMatch {
    ...
    PlaceNewPiece('e', 1, new King(board, Color.White, this));
    ...
}

chamando um meio, e passando o propprio obj (proppria partida de xadrez) como argumrnto


*/