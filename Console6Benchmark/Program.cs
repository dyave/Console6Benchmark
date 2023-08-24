using System.Formats.Asn1;
using System.Security.Cryptography;
using SJson = System.Text.Json;
using System.Xml;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using NJson = Newtonsoft.Json;

namespace Console6Benchmark;
class Program
{
    static void Main(string[] args)
    {
        var tmp = typeof(Program).Assembly;
        //var summary = BenchmarkRunner.Run(typeof(Program).Assembly);
        Console.WriteLine("This is the end.");
    }
}

[MemoryDiagnoser(true)]
public class Md5VsSha256
{
    private const int N = 10000;
    private readonly byte[] data;

    private readonly SHA256 sha256 = SHA256.Create();
    private readonly MD5 md5 = MD5.Create();

    List<PrintFileHeader> letter;

    public Md5VsSha256()
    {
        data = new byte[N];
        new Random(42).NextBytes(data);
        
        string fileName = "NotificacionesDeuda_2023_8_24_Explotacion_1011_JsonNative0_0.json";
        string jsonString = File.ReadAllText(fileName);
        letter = SJson.JsonSerializer.Deserialize<List<PrintFileHeader>>(jsonString)!;
    }

    [Benchmark]
    public byte[] Sha256() => sha256.ComputeHash(data);

    [Benchmark]
    public byte[] Md5() => md5.ComputeHash(data);

    private double[] TestPerformance(Action<List<PrintFileHeader>, string> writeJson, List<PrintFileHeader> letter, string key, int numberOfTests)
    {
        var tiempos = new double[numberOfTests];

        for (int i = 0; i < numberOfTests; i++)
        {
            string path = Path.Combine(
                "D:\\Storage\\PrinterProvider", 
                @$"NotificacionesDeuda_BM_{DateTime.Now.Year}_{DateTime.Now.Month}_{DateTime.Now.Day}_Explotacion_{key}_{writeJson.Method.Name}_{i}");
            var ini = DateTime.Now;
            writeJson(letter, path);
            var fin = DateTime.Now;
            var secs = fin.Subtract(ini).TotalSeconds;
            tiempos[i] = secs;
        }
        return tiempos;
    }

    private void JsonNativeOpt(List<PrintFileHeader> letter, string fileBasePath)
    {
        var options = new SJson.JsonSerializerOptions
        {
            WriteIndented = true,
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };
        using FileStream createStream = File.Create(@$"{fileBasePath}.json");
        SJson.JsonSerializer.Serialize(createStream, letter, options);
    }

    private void JsonNative(List<PrintFileHeader> letter, string fileBasePath)
    {
        var options = new SJson.JsonSerializerOptions
        {
            WriteIndented = true,
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };

        string json = SJson.JsonSerializer.Serialize(letter, options);
        using (var stream = new StreamWriter(@$"{fileBasePath}.json"))
        {
            stream.Write(json);
        }
    }

    private void JsonNsConvert(List<PrintFileHeader> letter, string fileBasePath)
    {
        var options = new NJson.JsonSerializerSettings()
        {
            Formatting = NJson.Formatting.Indented,
            //Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };

        string json = NJson.JsonConvert.SerializeObject(letter, options);

        using (var stream = new StreamWriter(@$"{fileBasePath}.json"))
        {
            stream.Write(json);
        }
    }

    private void JsonNsFull(List<PrintFileHeader> letter, string fileBasePath)
    {
        NJson.JsonSerializer serializer = new NJson.JsonSerializer()
        {
            Formatting = NJson.Formatting.Indented,
            //Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };

        using (StreamWriter sw = new StreamWriter(@$"{fileBasePath}.json"))
        using (NJson.JsonWriter writer = new NJson.JsonTextWriter(sw))
        {
            serializer.Serialize(writer, letter);
        }
    }
}