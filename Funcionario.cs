namespace Heranca
{
    public abstract class Funcionario  // a abstract só é para transmitir coisas que herdam dela
    {
        protected decimal Salario;
        public string? Nome { get; set; }

        public Funcionario()
        {
            
        }

        public Funcionario(string nome, decimal salario)
        {
            Nome = nome;
            Salario = salario;
        }

        public virtual void Trabalhar() // original
        {
            Console.WriteLine("Funcionário está trabalhando.");
        }

        public abstract decimal CalcularBonus();

        
    }
}