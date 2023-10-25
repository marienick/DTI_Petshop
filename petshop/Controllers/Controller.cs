using Model;
namespace Controllers
{
    //classe controller
    public partial class Controller
    {
        public Petshop[] petshops;

        //Construtor que é usado para criar novos petshops (objetos)
        public Controller()
        {
            this.petshops = new Petshop[3];
            this.petshops[0] = new Petshop("Meu Canino Feliz", 2.0M, 48.0M, 24.0M, 20.0M, 40.0M);
            this.petshops[1] = new Petshop("Vai Rex", 1.7M, 55.0M, 20.0M, 15.0M, 50.0M);
            this.petshops[2] = new Petshop("ChowChawgas", 0.8M, 45.0M, 30.0M, 30.0M, 45.0M);
        }
        
        //função para achar o petshop mais acessível
        public  string melhorPetshop(Petshop[] petshops, bool data, int qtdPequeno, int qtdGrande, out decimal preco)
        {
            Petshop melhorOpcao = petshops[0];
            for (int i = 1; i < petshops.Length; i++)
            {
                if (melhorOpcao.calcularValor(data, qtdPequeno, qtdGrande) > petshops[i].calcularValor( data, qtdPequeno, qtdGrande))
                {
                    melhorOpcao = petshops[i];
                    
                }
                else if (melhorOpcao.calcularValor(data, qtdPequeno, qtdGrande) == petshops[i].calcularValor(data, qtdPequeno, qtdGrande))
                {
                    if (melhorOpcao.distancia > petshops[i].distancia)
                    {
                        melhorOpcao = petshops[i];
                    }
                }
            }
            preco = melhorOpcao.calcularValor(data, qtdPequeno, qtdGrande);
            return melhorOpcao.nome;
        }
        

        //função para saber se é ou não final de semana
        public static bool diaDaSemana(int ano, int mes, int dia)
        {
            
            DateTime dateValue = new DateTime(ano, mes, dia);
            int data = ((int)dateValue.DayOfWeek);
            if (data >= 1 && data <= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }

}
