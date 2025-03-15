using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Domain.DTOs;
using Domain.Interfaces;

namespace RetoMaui.ViewModels;

public partial class RandomJokeViewModel :ObservableObject
{
    IChuckNorrisService _service;
    public RandomJokeViewModel(IChuckNorrisService  service){
        _service = service;
    }

    [ObservableProperty]
private ChuckNorrisDTO dto = new ChuckNorrisDTO();

    [RelayCommand]
    private async Task GetData()
    {
        var response = await _service.GetRandomJoke();
        if (response.Success && response.Data != null)
        {
            Dto = response.Data;
        }
    }
}
