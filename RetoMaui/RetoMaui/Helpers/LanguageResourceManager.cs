using RetoMaui.Resources.Languages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoMaui.Helpers
{
    public class LanguageResourceManager : INotifyPropertyChanged
    {
        public LanguageResourceManager()
        {
            LanguageResources.Culture = CultureInfo.CurrentCulture;
        }
        public static LanguageResourceManager Instance { get; } = new();
        public object this[string resourceKey]
            => LanguageResources.ResourceManager.GetObject(resourceKey, LanguageResources.Culture) ?? Array.Empty<byte>();
        
        
        public event PropertyChangedEventHandler? PropertyChanged;

        public void SetCulture(CultureInfo culture)
        {
            LanguageResources.Culture = culture;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
        }
    }
}
