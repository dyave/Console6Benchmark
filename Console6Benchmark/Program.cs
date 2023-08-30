using System.Formats.Asn1;
using System.Security.Cryptography;
using SJson = System.Text.Json;
using System.Xml;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using NJson = Newtonsoft.Json;
using System.Diagnostics.Metrics;

namespace Console6Benchmark;
class Program
{
    static void Main(string[] args)
    {
        var tmp = typeof(Program).Assembly;
        var summary = BenchmarkRunner.Run(typeof(Program).Assembly);
        //var x = new PerformanceJson();
        Console.WriteLine("This is the end.");
    }
}

[MemoryDiagnoser(true)]
public class PerformanceJson
{
    List<PrintFileHeader> letter;
    string path1 = "D:\\Storage\\PrinterProvider\\NotificacionesDeuda_2023_8_24_Explotacion_1011_SJsonOpt";
    string path2 = "D:\\Storage\\PrinterProvider\\NotificacionesDeuda_2023_8_24_Explotacion_1011_SJson";
    string path3 = "D:\\Storage\\PrinterProvider\\NotificacionesDeuda_2023_8_24_Explotacion_1011_NJson";
    string path4 = "D:\\Storage\\PrinterProvider\\NotificacionesDeuda_2023_8_24_Explotacion_1011_NJsonFull";

    public PerformanceJson()
    {
        string fileName = "D:\\Storage\\PrinterProvider\\1011_1 24-08\\NotificacionesDeuda_2023_8_24_Explotacion_1011_JsonNative0_0.json";
        string jsonString = File.ReadAllText(fileName);
        letter = SJson.JsonSerializer.Deserialize<List<PrintFileHeader>>(jsonString)!;
    }

    [Benchmark]
    public void JsonNativeOpt()
    {
        var options = new SJson.JsonSerializerOptions
        {
            WriteIndented = true,
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };
        using FileStream createStream = File.Create(@$"{path1}.json");
        SJson.JsonSerializer.Serialize(createStream, letter, options);
    }

    [Benchmark]
    public void JsonNative()
    {
        var options = new SJson.JsonSerializerOptions
        {
            WriteIndented = true,
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };

        string json = SJson.JsonSerializer.Serialize(letter, options);
        using (var stream = new StreamWriter(@$"{path2}.json"))
        {
            stream.Write(json);
        }
    }

    [Benchmark]
    public void JsonNsConvert()
    {
        var options = new NJson.JsonSerializerSettings()
        {
            Formatting = NJson.Formatting.Indented,
            //Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };

        string json = NJson.JsonConvert.SerializeObject(letter, options);

        using (var stream = new StreamWriter(@$"{path3}.json"))
        {
            stream.Write(json);
        }
    }

    [Benchmark]
    public void JsonNsFull()
    {
        NJson.JsonSerializer serializer = new NJson.JsonSerializer()
        {
            Formatting = NJson.Formatting.Indented,
            //Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };

        using (StreamWriter sw = new StreamWriter(@$"{path4}.json"))
        using (NJson.JsonWriter writer = new NJson.JsonTextWriter(sw))
        {
            serializer.Serialize(writer, letter);
        }
    }
}