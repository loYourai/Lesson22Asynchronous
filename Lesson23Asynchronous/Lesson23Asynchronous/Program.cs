


using System.Net;

List<Task<string>> downloadTasks = new List<Task<string>>();


var googleTaks = Task.Run(() => DownloadUrl("https://google.com"));

var duckTask = Task.Run(() => DownloadUrl("https://duckducgo.com"));

var yahooTak = Task.Run(() => DownloadUrl("https://www.yahoo.com"));

var resultArray = await Task.WhenAll(googleTaks, duckTask, yahooTak);
bool allAreUp = true;
foreach (var item in resultArray)
{
    if (item.StatusCode != HttpStatusCode.OK)
    {
        allAreUp = false; 
    }
}

Console.WriteLine(allAreUp ? "All sites are up" : "Not every site is  running");
await Task.Delay(2000);

async Task<HttpResponseMessage> DownloadUrl(string url)
{
    using (var httpClient = new HttpClient())
    {
        try
        {
return  await httpClient.GetAsync(url);
        }
        catch (Exception e)
        {
            return new HttpResponseMessage(HttpStatusCode.NotFound);
        }
    
        
    
    }
}


Console.ReadLine();