using System;

namespace Desenvolvedor.IO.DI.Cases
{
    public class OperacaoService
    {
        public IOperacaoTransient Transient { get; }
        public IOperacaoScoped Scoped { get; }
        public IOperacaoSingleton Singleton { get; }
        public IOperacaoSingletonInstance SingletonInstance { get; }

        public OperacaoService(
            IOperacaoTransient transient,
            IOperacaoScoped scoped,
            IOperacaoSingleton singleton,
            IOperacaoSingletonInstance singletonInstance)
        {
            Transient = transient;
            Scoped = scoped;
            Singleton = singleton;
            SingletonInstance = singletonInstance;
        }
    }

    public class Operacao : IOperacaoTransient, IOperacaoScoped, IOperacaoSingleton, IOperacaoSingletonInstance
    {
        public Guid OperacaoId { get; private set; }

        public Operacao(Guid id)
        {
            OperacaoId = id;
        }

        public Operacao() : this(Guid.NewGuid()) { }
    }

    public interface IOperacao
    {
        Guid OperacaoId { get; }
    }

    public interface IOperacaoTransient : IOperacao
    {
    }

    public interface IOperacaoScoped : IOperacao
    {
    }

    public interface IOperacaoSingleton : IOperacao
    {
    }

    public interface IOperacaoSingletonInstance : IOperacao
    {
    }
}
