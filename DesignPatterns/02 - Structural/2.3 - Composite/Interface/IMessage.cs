namespace DesignPatterns.Composite.Interface
{
    public interface IMessage
    {
        string Nome { get; set; }
        void ExibirMensagem(int sub);
    }
}
