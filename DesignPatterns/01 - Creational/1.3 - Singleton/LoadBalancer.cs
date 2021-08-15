using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Singleton
{
    internal sealed class LoadBalancer
    {
        public static readonly LoadBalancer Instance = new();
        private readonly Random _random = new();
        private readonly List<Server> _servers;

        private LoadBalancer()
        {
            _servers = new List<Server>
            {
                new Server{Id = Guid.NewGuid(), Nome = "Server1", IP = "120.14.220.18" },
                new Server{Id = Guid.NewGuid(), Nome = "Server2", IP = "120.14.220.19" },
                new Server{Id = Guid.NewGuid(), Nome = "Server3", IP = "120.14.220.20" },
                new Server{Id = Guid.NewGuid(), Nome = "Server4", IP = "120.14.220.21" },
                new Server{Id = Guid.NewGuid(), Nome = "Server5", IP = "120.14.220.22" }
            };
        }

        public static LoadBalancer GetLoadBalancer()
        {
            return Instance;
        }

        public Server NextServer
        {
            get
            {
                var r = _random.Next(_servers.Count);
                return _servers.ElementAt(r);
            }
        }
    }
}
