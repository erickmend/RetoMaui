using System;
using Domain.Interfaces;
namespace Infraestructure.Services;

public class SecureStorageService : ISecureStorageService
{
    public async Task<string?> GetAsync(string key)
    {
        try
        {
            return await SecureStorage.GetAsync(key);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al obtener el valor: {ex.Message}");
            return string.Empty;
        }
    }

    public async Task SetAsync(string key, string value)
    {
        try
        {
            await SecureStorage.SetAsync(key, value);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al guardar el valor: {ex.Message}");
        }
    }
}
