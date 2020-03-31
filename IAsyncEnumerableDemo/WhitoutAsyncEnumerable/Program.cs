using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WithoutAsyncEnumerable
{
    class Program
    {
        static async Task Main(string[] args)
        {
            foreach (var dataPoint in await FetchIotData())
            {
                Console.WriteLine(dataPoint);
            }

            Console.ReadLine();
        }

        static async Task<IEnumerable<int>> FetchIotData()
        {
            List<int> dataPoints = new List<int>();
            for (int i = 1; i <= 10; i++)
            {
                await Task.Delay(1000);//Simulate waiting for data to come through. 
                dataPoints.Add(i);
            }
            return dataPoints;
        }
    }
}
