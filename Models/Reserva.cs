namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {   
            int quantidadeHospedes = hospedes.Count;

            if (quantidadeHospedes <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("Numero de hospedes acima da Capacidade da Suite");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {   
            int quantidade = Hospedes.Count;
           
            return quantidade;
        }

        public decimal CalcularValorDiaria()
        {   
            decimal valorSuite = Suite.ValorDiaria;

            decimal valor = valorSuite * DiasReservados;

            if (DiasReservados >= 10)
            {
                valor *= 0.90m; 
            }

            return valor;
        }
    }
}