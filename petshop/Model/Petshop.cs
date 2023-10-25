namespace Model
{
    //classe petshops com os atributos
    public partial class Petshop
    {
        //{get; set} recomendaddo para pessoa nao acessar diretamente o atributo sem usar uma função que alteraria ele
        public decimal distancia { get; set; }
        public decimal valorCachorroPequeno { get; set; }
        public decimal valorCachorroGrande { get; set; }
        public decimal valorPequenoFimSemana { get; set; }
        public decimal valorGrandeFimSemana { get; set; }
        public string nome { get; set; }
        

        //contrutor com argumentos necessários para que um novo objeto/petshop seja inicializado
        public Petshop(string petshop, decimal km, decimal valorGrandeFinalSemana, decimal valorPequenoFinalsemana, decimal valorPequeno, decimal valorGrande)
        {
            distancia = km;
            nome = petshop;
            valorCachorroGrande = valorGrande;
            valorCachorroPequeno = valorPequeno;
            valorPequenoFimSemana = valorPequenoFinalsemana;
            valorGrandeFimSemana = valorGrandeFinalSemana;
        }

        //função que vai calcular o preço total dos petshops
        public decimal calcularValor(bool data,int qtdPequeno, int qtdGrande)
        {
            decimal valorFinal = 0;
            if (data)
            {
                valorFinal = (this.valorCachorroGrande * qtdGrande) + (this.valorCachorroPequeno * qtdPequeno);
                return valorFinal;
            }
            else
            {
                valorFinal = (this.valorGrandeFimSemana * qtdGrande) + (this.valorPequenoFimSemana * qtdPequeno);
                return valorFinal;
            }
        }

    }
}
