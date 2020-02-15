using System;
using Autofac;
using Snake.Interfaces;

namespace Snake
{
    class Program
    {
        private static IContainer _container;
        private static IOrchestrator _orchestrator;

        static void Main(string[] args)
        {
            var keyInfo = new ConsoleKeyInfo();
            SetupDependencies();

            do
            {
                keyInfo = new ConsoleKeyInfo();
                if (Console.KeyAvailable)
                {
                    keyInfo = Console.ReadKey();
                }

                _orchestrator.RunOnce(keyInfo.Key);
            } while (keyInfo.Key != ConsoleKey.Q);
        }

        private static void SetupDependencies()
        {
            var builder = new ContainerBuilder();
            builder.RegisterAssemblyTypes(AppDomain.CurrentDomain.GetAssemblies())
            .AsImplementedInterfaces();

            _container = builder.Build();
            _orchestrator = _container.Resolve<IOrchestrator>();
        }
    }
}
