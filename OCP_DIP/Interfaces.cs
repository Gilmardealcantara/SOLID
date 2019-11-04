namespace OCP_DIP
{
    public interface ITabelaDePreco
    {
        double DescontoPara(double valor);
    }

    public interface IServicoDeEntrega
    {
        double Para(string cidade);
    }
}