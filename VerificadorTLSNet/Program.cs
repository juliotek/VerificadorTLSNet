// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Security.Authentication;
string url = @"https://timbradocfdi4.servicios-lis.com.mx/api/generalController/consultarEmpresasAreas";
try
{
    // Crear HttpClient utilizando TLS 1.0
    using (var httpClientTls10 = new HttpClient(new HttpClientHandler
    {
        SslProtocols = SslProtocols.Tls
    }))
    {
        Console.WriteLine($"Realizando petición utilizando TLS 1.0 a {url}");
        var stopwatch = Stopwatch.StartNew();
        var responseTls10 = httpClientTls10.GetAsync(url).Result;
        stopwatch.Stop();
        Console.WriteLine($"Estado de la respuesta: {responseTls10.StatusCode}. Tiempo transcurrido: {stopwatch.ElapsedMilliseconds} ms");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Error al realizar la petición con TLS 1.0: {ex.Message}");
}

try
{
    // Crear HttpClient utilizando TLS 1.1
    using (var httpClientTls11 = new HttpClient(new HttpClientHandler
    {
        SslProtocols = SslProtocols.Tls11
    }))
    {
        Console.WriteLine($"Realizando petición utilizando TLS 1.1 a {url}");
        var stopwatch = Stopwatch.StartNew();
        var responseTls11 = httpClientTls11.GetAsync(url).Result;
        stopwatch.Stop();
        Console.WriteLine($"Estado de la respuesta: {responseTls11.StatusCode}. Tiempo transcurrido: {stopwatch.ElapsedMilliseconds} ms");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Error al realizar la petición con TLS 1.1: {ex.Message}");
}

try
{
    // Crear HttpClient utilizando TLS 1.2
    using (var httpClientTls12 = new HttpClient(new HttpClientHandler
    {
        SslProtocols = SslProtocols.Tls12
    }))
    {
        Console.WriteLine($"Realizando petición utilizando TLS 1.2 a {url}");
        var stopwatch = Stopwatch.StartNew();
        var responseTls12 = httpClientTls12.GetAsync(url).Result;
        stopwatch.Stop();
        Console.WriteLine($"Estado de la respuesta: {responseTls12.StatusCode}. Tiempo transcurrido: {stopwatch.ElapsedMilliseconds} ms");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Error al realizar la petición con TLS 1.2: {ex.Message}");
}

try
{
    // Crear HttpClient utilizando TLS 1.3
    using (var httpClientTls13 = new HttpClient(new HttpClientHandler
    {
        SslProtocols = SslProtocols.Tls13
    }))
    {
        Console.WriteLine($"Realizando petición utilizando TLS 1.3 a {url}");
        var stopwatch = Stopwatch.StartNew();
        var responseTls13 = httpClientTls13.GetAsync(url).Result;
        stopwatch.Stop();
        Console.WriteLine($"Estado de la respuesta: {responseTls13.StatusCode}. Tiempo transcurrido: {stopwatch.ElapsedMilliseconds} ms");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Error al realizar la petición con TLS 1.3: {ex.Message}");
}

try
{
    using (var httpClient = new HttpClient())
    {
        string urlHttp = url.Replace("https", "http");
        Console.WriteLine($"Realizando petición sin TLS a {urlHttp}");
        var stopwatch = Stopwatch.StartNew();
        var response= httpClient.GetAsync(url).Result;
        stopwatch.Stop();
        Console.WriteLine($"Estado de la respuesta: {response.StatusCode}. Tiempo transcurrido: {stopwatch.ElapsedMilliseconds} ms");

    }
}
catch (Exception ex)
{
    Console.WriteLine($"Error al realizar la petición sin TLS: {ex.Message}");
}

Console.ReadKey();
