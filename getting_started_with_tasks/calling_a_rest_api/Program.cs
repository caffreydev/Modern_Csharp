using Newtonsoft.Json;

using (var httpClient = new HttpClient() { BaseAddress = new Uri("https://api.github.com") })
{
    httpClient.DefaultRequestHeaders.Add("User-Agent", "caffreydev");
    var response = await httpClient.GetAsync("/orgs/microsoft/repos");
    var content = await response.Content.ReadAsStringAsync();

    Console.WriteLine(response.StatusCode);
    Console.WriteLine(content[1..1000]);

    var json = JsonConvert.DeserializeObject(content);

    Console.WriteLine(json);
}