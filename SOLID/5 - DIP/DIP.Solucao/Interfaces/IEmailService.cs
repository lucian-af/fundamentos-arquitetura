namespace SOLID.DIP.Solucao.Interfaces
{
    public interface IEmailService
    {
        void EnviarEmail(string de, string para, string assunto, string mensagem);
    }
}
