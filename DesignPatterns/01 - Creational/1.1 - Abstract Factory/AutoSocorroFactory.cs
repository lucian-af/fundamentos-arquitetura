namespace DesignPatterns.Abstract.Factory
{
    /// <summary>
    /// Abstract Factory 
    /// Fábrica de fábricas
    /// </summary>
    public abstract class AutoSocorroFactory
    {
        public abstract Guincho CriarGuincho();
        public abstract Veiculo CriarVeiculo(string modelo, Porte porte);
    }
}
