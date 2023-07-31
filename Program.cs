using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

public class sut
{

    public Dictionary<string, string> dic = new(){
        {"a","value"},
        {"b","value"},
        {"c","value"},
        {"d","value"},
        {"e","value"},
        {"f","value"},
        {"g","value"},
        {"h","value"},
    };

    public  string UsingNewSwitch(string key)
    {

        return key switch
        {
            "a" => "key",
            "b" => "key",
            "c" => "key",
            "d" => "key",
            "e" => "key",
            "f" => "key",
            "g" => "key",
            "h" => "key",
            _ => string.Empty,
        };
    }
    public  string UsingASwitch(string key)
    {

        switch (key)
        {
            case "a":
                return "key";
            case "b":
                return "key";
            case "c":
                return "key";
            case "d":
                return "key";
            case "e":
                return "key";
            case "f":
                return "key";
            case "g":
                return "key";
            case "h":
                return "key";
        }
        return string.Empty;
    }
    public  string UsingDictionary(string key, Dictionary<string, string> dic)
    {
        return dic.GetValueOrDefault(key, string.Empty);
    }

    [Benchmark]
    public  string UsingASwitchExistingElement() => UsingASwitch("a");
    [Benchmark]
    public  string UsingASwitchNoExistingElement() => UsingASwitch("1");
    [Benchmark]
    public  string UsingANewSwitchExistingElement() => UsingNewSwitch("a");
    [Benchmark]
    public  string UsingANewSwitchNoExistingElement() => UsingNewSwitch("1");
    [Benchmark]
    public  string UsingDictionaryExistingElement() => UsingDictionary("a",dic);
    [Benchmark]
    public  string UsingDictionaryNoExistingElement() => UsingDictionary("1",dic);
}

public class Program
{
    public static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run(typeof(Program).Assembly);
        Console.ReadKey();
    }
}