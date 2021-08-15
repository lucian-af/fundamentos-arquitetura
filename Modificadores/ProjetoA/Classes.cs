// [assembly: InternalsVisibleTo("ProjetoB")]
namespace ProjetoA
{
    #region Classes
    public class Publica
    {
        public void TestePublico() { }
        private void TestePrivado() { }
        internal void TesteInternal() { }
        protected void TesteProtegido() { }
        private protected void TestePrivadoProtegido() { }
        protected internal void TesteProtegidoInterno() { }
        public static int TesteEstatico() => 0;
        public virtual int TesteVirtual() => 100;
    }

    /// <summary>
    /// Classe sealed (selada) pode ser instanciada, mas não pode ser herdada
    /// </summary>
    public sealed class Selada { }

    class Privada { }

    internal class Interna { }

    abstract class Abstrata { }

    #endregion

    #region Testes

    class TesteClasses
    {
        public TesteClasses()
        {
            var publica = new Publica();
            var privada = new Privada(); // estão no mesmo Assembly
            var interna = new Interna(); // estão no mesmo Assembly
            var estatico = Publica.TesteEstatico();
            // var abstrata = new Abstrata(); // não permitido, só pode ser herdada
        }
    }

    //class TesteSelada : Selada { }

    class TesteModificador1
    {
        public TesteModificador1()
        {
            var publica = new Publica();
            publica.TestePublico();
            publica.TesteInternal();
            publica.TesteProtegidoInterno();
            // Métodos inacessíveis pelos modificadores
            //publica.TesteProtegido();
            //publica.TestePrivadoProtegido();
            //publica.TestePrivado();
        }
    }

    class TesteModificador2 : Publica
    {
        public TesteModificador2()
        {
            TestePublico();
            TesteInternal();
            TesteProtegidoInterno();
            // acessíveis pela herança
            TesteProtegido();
            TestePrivadoProtegido();
            // TestePrivado(); acessível somente pela classe que o criou
        }

        /// <summary>
        /// Sobrescrita de um método virtual
        /// </summary>
        /// <returns></returns>
        public override int TesteVirtual() => 200;
    }

    #endregion

}
/***************************************************************************************************/
// Nem todos os modificadores servem para classes, alguns só servem para métodos

// public: sem restrição de acesso

// protected: apenas a classe que herda a classe que o criou pode usar aquele método ou atributo

// internal: limitado apenas ao Assembly, uma DLL por exemplo

// protected internal: limitado ao Assembly e a classe que herda a classe de criação
// Obs: só serve para método

// private: limitado apenas para a classe que o criou

// private protected: limitado apenas para as classes que herdam ou para classes do mesmo Assembly
// Obs: só serve para método

// virtual: permite a sobrescrita do método ou atributo nas classes que herdarem a classe base
// não pode ser usado em conjunto com outros modificadores como: static, abstract, override, private
// Obs: só serve para método e atributos de classe

// static: permite o acesso por meio do nome do tipo, sem referência por meio de instância

/***************************************************************************************************/
