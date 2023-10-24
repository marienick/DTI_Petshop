using Model;
namespace Controllers
{
    public partial class Controller
    {
        private Petshop[] petshops;
        public Controller()
        {
            this.petshops = new Petshop[3];
            this.petshops[0] = new Petshop("Meu Canino Feliz", 2.0m, 48.0M, 24.0M, 20.0M, 40.0M);
            this.petshops[1] = new Petshop("Vai Rex", 1.7m, 55.0M, 20.0M, 15.0M, 50.0M);
            this.petshops[2] = new Petshop("ChowChawgas", 0.8m, 45.0M, 30.0M, 30.0M, 45.0M);
        }
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
        public string melhorPetshop(bool data, int pequeno, int grande, out decimal preco)
        {
            Petshop melhorpet = petshops[0];
            if (data)
            {
                for (int i = 1; i < petshops.Length; i++)
                {
                    if ((melhorpet.ValorGrande * grande) + (melhorpet.ValorPequeno * pequeno) > (petshops[i].ValorGrande * grande) + (petshops[i].ValorPequeno * pequeno))
                    {
                        melhorpet = petshops[i];

                    }
                    else if ((melhorpet.ValorGrande * grande) + (melhorpet.ValorPequeno * pequeno) == (petshops[i].ValorGrande * grande) + (petshops[i].ValorPequeno * pequeno))
                    {
                        if (melhorpet.Distancia > petshops[i].Distancia)
                        {
                            melhorpet = petshops[i];
                        }
                    }
                }
                preco = (melhorpet.ValorGrande * grande) + (melhorpet.ValorPequeno * pequeno);
            }
            else
            {
                for (int i = 1; i < petshops.Length; i++)
                {
                    if ((melhorpet.ValorGrandeFimSemana * grande) + (melhorpet.ValorPequenoFimSemana * pequeno) > (petshops[i].ValorGrandeFimSemana * grande) + (petshops[i].ValorPequenoFimSemana * pequeno))
                    {
                        melhorpet = petshops[i];

                    }
                    else if ((melhorpet.ValorGrandeFimSemana * grande) + (melhorpet.ValorPequenoFimSemana * pequeno) == (petshops[i].ValorGrandeFimSemana * grande) + (petshops[i].ValorPequenoFimSemana * pequeno))
                    {
                        if (melhorpet.Distancia > petshops[i].Distancia)
                        {
                            melhorpet = petshops[i];
                        }
                    }
                }
                preco = (melhorpet.ValorGrandeFimSemana * grande) + (melhorpet.ValorPequenoFimSemana * pequeno);
            }
            return melhorpet.Nome;



        }
    }

}


