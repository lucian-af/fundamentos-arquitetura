using ProjetoA;

namespace ProjetoB
{
    class TesteClasses
    {
        public TesteClasses()
        {
            var publica = new Publica();
            // inacessíveis Projeto B é outra DLL, não faz parte do mesmo Assembly
            // podem ser habilitados, se usarmos um annotation no namespace que contém a criação dessas classes 
            //var privada = new Privada();
            //var interna = new Interna();
            //var abstrata = new Abstrata();
        }
    }

    class TesteModificador1
    {
        public TesteModificador1()
        {
            var publica = new Publica();
            publica.TestePublico();
            // Métodos inacessíveis pelos modificadores
            // podem ser habilitados, se usarmos um annotation no namespace que contém a criação dessas classes 
            //publica.TesteInternal();
            //publica.TesteProtegidoInterno();
            //publica.TesteProtegido();
            //publica.TestePrivadoProtegido();

            // acessível somente pela classe que o criou
            //publica.TestePrivado();
        }
    }

    class TesteModificador2 : Publica
    {
        public TesteModificador2()
        {
            TestePublico();
            // acessíveis pela herança
            TesteProtegidoInterno();
            TesteProtegido();
            // podem ser habilitados, se usarmos um annotation no namespace que contém a criação dessas classes 
            //TesteInternal();
            //TestePrivadoProtegido();
            // acessível somente pela classe que o criou
            //TestePrivado(); 
        }
    }

}
