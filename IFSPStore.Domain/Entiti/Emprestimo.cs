using IFSPLivraria.Domain.Base;


namespace IFSPLivraria.Domain.Entities
{
    public class Emprestimo : BaseEntity<int>
    {
        public Emprestimo()
        {

        }

        public Emprestimo(int id, DateTime dataEmprestimo, DateTime dataDevolucao, Cliente? cliente) : base(id)
        {
            DataEmprestimo = dataEmprestimo;
            DataDevolucao = dataDevolucao;
            Cliente = cliente;
        }       

        
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucao { get; set; }
        public Cliente? Cliente { get; set; }

    }
}
