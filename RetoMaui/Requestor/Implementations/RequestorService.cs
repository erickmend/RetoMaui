using System;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using Domain.DTOs;
 
using Requestor.Interfaces;

namespace Requestor.Implementations;

public class RequestorService : IRequestorService
{
    private HttpClient _httpClient;
    public RequestorService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<ApiResponse<string>> GetAsync(string url)
    {
        var response = await _httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();
        return await HandleResponse(response);
    }

    public async Task<ApiResponse<string>> PostAsync<T>(string url, T data)
    {
        var jsonContent = new StringContent(JsonSerializer.Serialize(data), Encoding.UTF8, "application/json");
        var response = await _httpClient.PostAsync(url, jsonContent);
        return await HandleResponse(response);
    }

    public async Task<ApiResponse<string>> PutAsync<T>(string url, T data)
    {
        var jsonContent = new StringContent(JsonSerializer.Serialize(data), Encoding.UTF8, "application/json");
        var response = await _httpClient.PutAsync(url, jsonContent);
        return await HandleResponse(response);
    }

    public async Task<ApiResponse<string>> DeleteAsync(string url)
    {
        var response = await _httpClient.DeleteAsync(url);
        return await HandleResponse(response);
    }

    private async Task<ApiResponse<string>> HandleResponse(HttpResponseMessage response)
    {
        var content = await response.Content.ReadAsStringAsync();
        return new ApiResponse<string>
        {
            Success = response.IsSuccessStatusCode,
            Data = response.IsSuccessStatusCode ? content : string.Empty,
            Message = response.IsSuccessStatusCode ? "Success" : content,
            StatusCode = (int)response.StatusCode
        };
    }
}