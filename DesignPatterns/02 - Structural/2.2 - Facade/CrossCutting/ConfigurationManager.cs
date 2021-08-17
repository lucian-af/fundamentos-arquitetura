using System;
using System.Linq;
using DesignPatterns.Facade.CrossCutting.Interface;

namespace DesignPatterns.Facade.CrossCutting
{
    public class ConfigurationManager : IConfigurationManager
    {
        public string GetValue(string node)
            => new(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 10)
                .Select(s => s[new Random().Next(s.Length)]).ToArray());
    }
}
