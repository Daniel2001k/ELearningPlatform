using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using System.Net.Http.Json;

namespace ELearningPlatform.Client.Services.Http;

internal class HttpService : IHttpService
{
    private readonly IHttpClientFactory _httpClientFactory;

    public HttpService(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<T> Get<T>(string url)
    {
        try
        {
            var httpClient = _httpClientFactory.CreateClient("WebAPI");
            var response = await httpClient.GetAsync(url);
            if (response.StatusCode == System.Net.HttpStatusCode.NoContent) //when controller returns null
            {
                return default(T);
            }

            var result = await response.Content.ReadFromJsonAsync<T>();

            return result;
        }
        catch (AccessTokenNotAvailableException ex)
        {
            ex.Redirect();
            return default;
        }
    }

    public async Task<HttpResponseMessage> Post(string url, object data)
    {
        try
        {
            var httpClient = _httpClientFactory.CreateClient("WebAPI");
            return await httpClient.PostAsJsonAsync(url, data);
        }
        catch (AccessTokenNotAvailableException ex)
        {
            ex.Redirect();
            return default;
        }
    }

    public async Task<TResponse> Post<TResponse>(string url, object data)
    {
        var response = await Post(url, data);
        if (response == null) return default;
        return await response.Content.ReadFromJsonAsync<TResponse>();
    }

    public async Task<HttpResponseMessage> Post(string url, HttpContent data)
    {
        try
        {
            var httpClient = _httpClientFactory.CreateClient("WebAPI");
            var response = await httpClient.PostAsync(url, data);
            return response;
        }
        catch (AccessTokenNotAvailableException ex)
        {
            ex.Redirect();
            return default;
        }
    }

    public async Task<TResponse> Post<TResponse>(string url, HttpContent data)
    {
        var response = await Post(url, data);
        if (response == null) return default;
        return await response.Content.ReadFromJsonAsync<TResponse>();
    }

    public async Task<HttpResponseMessage> Put(string url, object data)
    {
        try
        {
            var httpClient = _httpClientFactory.CreateClient("WebAPI");
            return await httpClient.PutAsJsonAsync(url, data);
        }
        catch (AccessTokenNotAvailableException ex)
        {
            ex.Redirect();
            return default;
        }
    }

    public async Task<TResponse> Put<TResponse>(string url, object data)
    {
        var response = await Put(url, data);
        if (response == null) return default;
        return await response.Content.ReadFromJsonAsync<TResponse>();
    }

    public async Task<HttpResponseMessage> Delete(string url)
    {
        try
        {
            var httpClient = _httpClientFactory.CreateClient("WebAPI");
            return await httpClient.DeleteAsync(url);
        }
        catch (AccessTokenNotAvailableException ex)
        {
            ex.Redirect();
            return default;
        }
    }

    public async Task<TResponse> Delete<TResponse>(string url)
    {
        var response = await Delete(url);
        if (response == null) return default;
        return await response.Content.ReadFromJsonAsync<TResponse>();
    }
}