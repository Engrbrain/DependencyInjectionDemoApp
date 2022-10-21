using System;
namespace DependencyInjectionDemo.Logic
{
	public class BetterDemoLogic: IDemoLogic
	{
        public int Value1 { get; private set; }
        public int Value2 { get; private set; }

        public BetterDemoLogic()
        {
            Value1 = Random.Shared.Next(1001, 2001);
            Value2 = Random.Shared.Next(2001, 3001);
        }
    }
}

