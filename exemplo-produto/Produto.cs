namespace exemplo_produto {
    class Produto {

        public string nome;
        public double preco;
        public int quant;

        public double total() {
            double resultado = preco * quant;
            return resultado;
        }
    }
}
