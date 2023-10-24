namespace Model
{

    public partial class Petshop
    {
        public decimal Distancia { get; set; }
        public decimal ValorPequeno { get; set; }
        public decimal ValorGrande { get; set; }
        public decimal ValorPequenoFimSemana { get; set; }
        public decimal ValorGrandeFimSemana { get; set; }
        public string Nome { get; set; }
        public Petshop(string petshop, decimal km, decimal valorGrandeFinalSemana, decimal valorPequenoFinalsemana, decimal valorPequeno, decimal valorGrande)
        {
            Distancia = km;
            Nome = petshop;
            ValorGrande = valorGrande;
            ValorPequeno = valorPequeno;
            ValorPequenoFimSemana = valorPequenoFinalsemana;
            ValorGrandeFimSemana = valorGrandeFinalSemana;
        }

    }
}
