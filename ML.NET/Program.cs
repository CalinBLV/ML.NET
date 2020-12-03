using Microsoft.ML;
using System;
using ML_NETML.Model;
namespace ML.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new ModelInput()
            {
                Category = @"Bar furniture",
                Old_price = @"No old price",
                Sellable_online = false,
                Designer = @"Gucci",
                Depth = 1F,
                Height = 29F,
                Width = 55F,
            };

            ModelOutput result = ConsumeModel.Predict(input);

            Console.WriteLine(result.Score);

        }
    }
}
