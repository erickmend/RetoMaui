using System;

namespace Domain.DTOs;

public class ApiResponse
{
    public bool Success { get; set; }
    public object Data { get; set; } = new();
    public string Message { get; set; }= string.Empty;
    public int StatusCode { get; set; }
}