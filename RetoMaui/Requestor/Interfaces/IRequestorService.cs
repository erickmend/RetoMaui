using System;
using Domain.DTOs;

namespace Requestor.Interfaces;

public interface IRequestorService
{
    Task<ApiResponse> GetAsync(string url);
    Task<ApiResponse> PostAsync<T>(string url, T data);
    Task<ApiResponse> PutAsync<T>(string url, T data);
    Task<ApiResponse> DeleteAsync(string url);
}
