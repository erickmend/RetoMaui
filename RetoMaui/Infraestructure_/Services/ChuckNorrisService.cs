using Domain.DTOs;
using Domain.Interfaces;
using Requestor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Infraestructure_.Services
{
    public class ChuckNorrisService : IChuckNorrisService
    {
        private readonly IRequestorService _requestorService;
        private const string BaseUrl = "https://api.chucknorris.io/jokes/";

        public ChuckNorrisService(IRequestorService requestorService)
        {
            _requestorService = requestorService;
        }

        public async Task<ApiResponse<ChuckNorrisDTO>> GetRandomJoke()
        {
            string url = $"{BaseUrl}random";
            var response = await _requestorService.GetAsync(url);

            if (!response.Success)
            {
                return new ApiResponse<ChuckNorrisDTO>
                {
                    Success = false,
                    Message = response.Message,
                    StatusCode = response.StatusCode,
                    Data = new ChuckNorrisDTO()
                };
            }
            var result = JsonSerializer.Deserialize<ChuckNorrisDTO>(response.Data,
            new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            return new ApiResponse<ChuckNorrisDTO>
            {
                Success = true,
                Data = result ?? new ChuckNorrisDTO(),
                Message = "Success",
                StatusCode = 200
            };
        }
    }
}
