using System;
using Domain.DTOs;

namespace Domain.Interfaces;

public interface IChuckNorrisService
{
    Task<ApiResponse<ChuckNorrisDTO>> GetRandomJoke();
}
