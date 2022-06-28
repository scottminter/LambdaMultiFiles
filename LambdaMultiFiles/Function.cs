using Amazon.Lambda.Core;

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
        int num1 = input.num1;
        int num2 = input.num2;

        var math = new Math();
        int sum = math.Addition(num1, num2);
        int diff = math.Subtraction(num1, num2);
        decimal prod = math.Multiplication(num1, num2);
        decimal div = math.Division(num1, num2);

        return new
        {
            input = new
            {
                num1 = num1,
                num2 = num2,
            },
            sum = sum,
            difference = diff,
            product = prod,
            dividend = div
        };
    }
}
