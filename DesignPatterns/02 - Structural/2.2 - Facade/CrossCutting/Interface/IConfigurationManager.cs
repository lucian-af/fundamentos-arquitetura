namespace DesignPatterns.Facade.CrossCutting.Interface
{
    public interface IConfigurationManager
    {
        string GetValue(string node);
    }
}
