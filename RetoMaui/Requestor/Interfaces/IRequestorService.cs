using System;
using Domain.DTOs;

namespace Requestor.Interfaces;

public interface IRequestorService
{
    Task<ApiResponse<string>> GetAsync(string url);
    Task<ApiResponse<string>> PostAsync<T>(string url, T data);
    Task<ApiResponse<string>> PutAsync<T>(string url, T data);
    Task<ApiResponse<string>> DeleteAsync(string url);
}
