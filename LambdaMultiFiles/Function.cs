using Amazon.Lambda.Core;
using Newtonsoft.Json;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace LambdaMultiFiles;

public class Function
{

    /// <summary>
    /// A simple function that takes a string and does a ToUpper
    /// </summary>
    /// <param name="input"></param>
    /// <param name="context"></param>
    /// <returns></returns>
    public object FunctionHandler(ReqInput input, ILambdaContext context)
    {
        if (input.Body != null)
        {
            Console.WriteLine(input.Body);
            var inputString = input.Body.ToString();
            if (inputString != null)
            {
                var inputData = JsonConvert.DeserializeObject<InputModel>(inputString);
                if (inputData != null)
                {
                    int num1 = inputData.num1;
                    int num2 = inputData.num2;
                    Console.WriteLine($"num1: {num1}");
                    Console.WriteLine($"num2: {num2}");
                    var Math = new Math();
                    var sum = Math.Addition(num1, num2);
                    var difference = Math.Subtraction(num1, num2);
                    var product = Math.Multiplication(num1, num2);
                    var dividend = Math.Division(num1, num2);
                    return new { 
                        input = new
                        {
                            num1,
                            num2
                        },
                        sum,
                        difference,
                        product,
                        dividend
                    };
                }
            }
            
        }

        return new { };
    }
}