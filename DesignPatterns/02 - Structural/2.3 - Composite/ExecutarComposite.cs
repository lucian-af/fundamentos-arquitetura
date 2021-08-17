namespace DesignPatterns.Composite
{
    public class ExecutarComposite
    {
        public static void Executar()
        {
            var validacaoCadastro = new Message("O cadastro não foi realizado!");
            var usuarioFormErro = new Message("O usuário informou um nome inválido.");

            var tamanhoNomeForm = new InputFormMessage("O nome precisa possuir mais de 2 caracteres.");
            var nomeVazioForm = new InputFormMessage("O nome não pode possuir números.");

            usuarioFormErro.AdicionarFilha(tamanhoNomeForm);
            usuarioFormErro.AdicionarFilha(nomeVazioForm);

            validacaoCadastro.AdicionarFilha(usuarioFormErro);

            var domainUsuarioErro = new Message("Problemas ao processar o cadastro de usuário.");

            var cpfUsuarioDommain = new DomainMessage("O CPF informado está em uso!");
            var emailUsuarioDommain = new DomainMessage("O E-mail informado está em uso!");

            domainUsuarioErro.AdicionarFilha(cpfUsuarioDommain);
            domainUsuarioErro.AdicionarFilha(emailUsuarioDommain);

            validacaoCadastro.AdicionarFilha(domainUsuarioErro);

            var msgNivel1 = new Message("Nivel 1");
            var msgNivel2 = new Message("Nivel 2");
            var msgNivel3 = new Message("Nivel 3");
            var msgNivel4 = new Message("Nivel 4");
            var msgNivel5 = new Message("Nivel 5");

            msgNivel4.AdicionarFilha(msgNivel5);
            msgNivel3.AdicionarFilha(msgNivel4);
            msgNivel2.AdicionarFilha(msgNivel3);
            msgNivel1.AdicionarFilha(msgNivel2);

            validacaoCadastro.AdicionarFilha(msgNivel1);

            validacaoCadastro.ExibirMensagem(2);
        }
    }
}
