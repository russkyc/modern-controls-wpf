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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using org.russkyc.moderncontrols.Enums;

namespace org.russkyc.moderncontrols.Helpers;

public class ThemeManager
{
    private static object _lock = new object();
    private static ThemeManager _instance;
    private readonly IDictionary<string, string> _baseThemes = new Dictionary<string, string>();
    private readonly IDictionary<string, string> _colorThemes = new Dictionary<string, string>();

    public static ThemeManager Instance
    {
        get
        {
            if (_instance is null)
            {
                lock (_lock)
                {
                    if (_instance is null)
                    {
                        _instance = new ThemeManager();
                    }
                }
            }

            return _instance;
        }
    }

    public ThemeManager()
    {
        _lock = new object();
        InitBaseThemes();
        InitColorThemes();
    }

    public void AddBaseTheme(string key, string source)
    {
        lock (_lock)
        {
            _baseThemes.Add(key, source);
        }
    }

    public void AddColorTheme(string key, string source)
    {
        lock (_lock)
        {
            _colorThemes.Add(key, source);
        }
    }

    public void RemoveBaseTheme(string name, string source)
    {
        lock (_lock)
        {
            _baseThemes.Remove(name);
        }
    }

    public void RemoveColorTheme(string name, string source)
    {
        lock (_lock)
        {
            _colorThemes.Remove(name);
        }
    }

    public IEnumerable<string> GetBaseThemes()
    {
        lock (_lock)
        {
            return _baseThemes.Keys.AsEnumerable();
        }
    }

    public IEnumerable<string> GetColorThemes()
    {
        lock (_lock)
        {
            return _colorThemes.Keys.AsEnumerable();
        }
    }

    public void SetBaseTheme(string name)
    {
        lock (_lock)
        {
            var baseThemeDict = Application.Current.Resources.MergedDictionaries.FirstOrDefault(
                dict => dict.Source?.LocalPath?.Contains("Themes/BaseThemes/") == true
            );

            if (baseThemeDict != null)
            {
                baseThemeDict.Source = new Uri(_baseThemes[name], UriKind.Absolute);
            }
        }
    }

    public void SetBaseTheme(BaseTheme baseTheme)
    {
        SetBaseTheme(baseTheme.ToString());
    }

    public void SetColorTheme(string name)
    {
        lock (_lock)
        {
            var baseThemeDict = Application.Current.Resources.MergedDictionaries.FirstOrDefault(
                dict => dict.Source?.LocalPath?.Contains("Themes/ColorThemes/") == true
            );

            if (baseThemeDict != null)
            {
                baseThemeDict.Source = new Uri(_colorThemes[name], UriKind.Absolute);
            }
        }
    }

    public void SetColorTheme(ColorTheme colorTheme)
    {
        SetBaseTheme(colorTheme.ToString());
    }

    private void InitBaseThemes()
    {
        // Add Base Themes
        AddBaseTheme(
            "Dark",
            "pack://application:,,,/Russkyc.ModernControls.WPF;component/Themes/BaseThemes/Dark.xaml"
        );
        AddBaseTheme(
            "Light",
            "pack://application:,,,/Russkyc.ModernControls.WPF;component/Themes/BaseThemes/Light.xaml"
        );
    }

    private void InitColorThemes()
    {
        AddColorTheme(
            "Blue",
            "pack://application:,,,/Russkyc.ModernControls.WPF;component/Themes/ColorThemes/Blue.xaml"
        );
        AddColorTheme(
            "Red",
            "pack://application:,,,/Russkyc.ModernControls.WPF;component/Themes/ColorThemes/Red.xaml"
        );
        AddColorTheme(
            "Yellow",
            "pack://application:,,,/Russkyc.ModernControls.WPF;component/Themes/ColorThemes/Yellow.xaml"
        );
        AddColorTheme(
            "Purple",
            "pack://application:,,,/Russkyc.ModernControls.WPF;component/Themes/ColorThemes/Purple.xaml"
        );
        AddColorTheme(
            "Lime",
            "pack://application:,,,/Russkyc.ModernControls.WPF;component/Themes/ColorThemes/Lime.xaml"
        );
        AddColorTheme(
            "Gray",
            "pack://application:,,,/Russkyc.ModernControls.WPF;component/Themes/ColorThemes/Gray.xaml"
        );
        AddColorTheme(
            "Teal",
            "pack://application:,,,/Russkyc.ModernControls.WPF;component/Themes/ColorThemes/Teal.xaml"
        );
        AddColorTheme(
            "Pink",
            "pack://application:,,,/Russkyc.ModernControls.WPF;component/Themes/ColorThemes/Pink.xaml"
        );
        AddColorTheme(
            "Green",
            "pack://application:,,,/Russkyc.ModernControls.WPF;component/Themes/ColorThemes/Green.xaml"
        );
        AddColorTheme(
            "Orange",
            "pack://application:,,,/Russkyc.ModernControls.WPF;component/Themes/ColorThemes/Orange.xaml"
        );
    }
}
