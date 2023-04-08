// MIT License
// 
// Copyright (c) 2023 Russell Camo (Russkyc)
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System.Collections.ObjectModel;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using org.russkyc.moderncontrols.Helpers;

namespace Russkyc.ModernControls.WPF.Demo;

public partial class RegistrationViewModel : ObservableObject
{
    
    [ObservableProperty]
    private string? _name;
    
    [ObservableProperty]
    private string? _email;
    

    [ObservableProperty]
    private int? _studentNumber;
    
    [ObservableProperty]
    private ObservableCollection<int>? _day;
    
    [ObservableProperty]
    private ObservableCollection<int>? _month;
    
    [ObservableProperty]
    private ObservableCollection<int>? _year;

    [ObservableProperty]
    private ObservableCollection<string>? _themes;

    private int _selectedIndex;

    public int SelectedIndex
    {
        get => _selectedIndex;
        set
        {
            _selectedIndex = value;
            OnPropertyChanged();
            ChangeTheme();
        }
    }
    
    public RegistrationViewModel()
    {

        Day = new ObservableCollection<int>();
        Month = new ObservableCollection<int>();
        Year = new ObservableCollection<int>();
        Themes = new ObservableCollection<string>();
            
        for (int i = 1; i <= 30; i++) Day.Add(i);
        for (int i = 1; i <= 12; i++) Month.Add(i);
        for (int i = 1900; i <= 2022; i++) Year.Add(i);
        
        ThemeHelper.GetThemes()
            .ToList()
            .ForEach(Themes.Add);
        
        SelectedIndex = 0;
    }

    private void ChangeTheme()
    {
        ThemeHelper.SetGlobalTheme(Themes![SelectedIndex]);
    }
}