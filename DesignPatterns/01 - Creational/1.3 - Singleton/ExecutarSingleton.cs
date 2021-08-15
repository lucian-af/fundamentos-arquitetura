using System;

namespace DesignPatterns.Singleton
{
    public class ExecutarSingleton
    {
        public static void Executar()
        {
            var b1 = LoadBalancer.GetLoadBalancer();
            var b2 = LoadBalancer.GetLoadBalancer();
            var b3 = LoadBalancer.GetLoadBalancer();
            var b4 = LoadBalancer.GetLoadBalancer();

            if (b1 == b2 && b2 == b3 && b3 == b4)
                Console.WriteLine("Mesma instância\n");

            var balancer = LoadBalancer.GetLoadBalancer();

            for (var i = 0; i < 15; i++)
            {
                var server = balancer.NextServer;
                Console.WriteLine($"Disparando request para: Nome: {server.Nome}, Id: {server.Id}");
            }
        }
    }
}
