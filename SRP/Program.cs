using System;

namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new CalculadoraDeSalario().Calcula(new Funcionario(new Desenvolvedor(new DezOuVintePorcento()), 2000)));
        }
    }

    public class CalculadoraDeSalario
    {
        public double Calcula(Funcionario funcionario)
        {
            return funcionario.CalculaSalario();
        }
    }

    public abstract class Cargo
    {
        public IRegraDeCalculo Regra { get; private set; }
        public Cargo(IRegraDeCalculo regra)
        {
            Regra = regra;
        }
    }

    public class Desenvolvedor : Cargo
    {
        public Desenvolvedor(IRegraDeCalculo regra) : base(regra)
        {
        }
    }
    public class Dba : Cargo
    {
        public Dba(IRegraDeCalculo regra) : base(regra)
        {
        }
    }
    public class Tester : Cargo
    {
        public Tester(IRegraDeCalculo regra) : base(regra)
        {
        }
    }

    public class Funcionario
    {

        public Cargo Cargo { get; private set; }

        public double SalarioBase { get; private set; }

        public Funcionario(Cargo cargo, double salarioBase)
        {
            this.Cargo = cargo;
            this.SalarioBase = salarioBase;
        }

        public double CalculaSalario()
        {
            return Cargo.Regra.Calcula(this);
        }
    }
}
