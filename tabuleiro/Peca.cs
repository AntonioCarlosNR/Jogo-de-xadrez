namespace tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        //protected set: a propriedade só pode ser alterada por ela mesma e por suas subclasses
        public Cor cor { get; protected set; }
        public int qtdMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca (Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.qtdMovimentos = 0;
        }
    }
}
