using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Plugin.Maui.Biometric;
using RetoMaui.Helpers;

namespace RetoMaui.ViewModels;

public partial class BiometricsFunctionViewModel: ObservableObject
{
    public BiometricsFunctionViewModel(LanguageResourceManager lng)
    {
        languageResourceManager = lng;
    }
    [ObservableProperty]
    private LanguageResourceManager languageResourceManager;

    [ObservableProperty]
    private string dataInfo = string.Empty;

     [RelayCommand]
    public async Task Auth(){
        var result = await BiometricAuthenticationService.Default.AuthenticateAsync(new AuthenticationRequest(){
            Title ="Auth",
            NegativeText="Cancelar"
        }, CancellationToken.None);

        if(result.Status ==  BiometricResponseStatus.Success){
            DataInfo ="La autenticación fue exitosa";
        }else{
            DataInfo ="La autenticación fue fallida";
        }
    }
}
