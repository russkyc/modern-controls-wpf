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
using System.Windows;
using System.Windows.Markup;
using org.russkyc.moderncontrols.Enums;
using org.russkyc.moderncontrols.Helpers;

namespace org.russkyc.moderncontrols.Styles;

[UsableDuringInitialization(true)]
[Localizability(LocalizationCategory.Ignore)]
public class ModernControlsWpf : ResourceDictionary
{
    private BaseTheme _baseTheme;
    private ColorTheme _colorTheme;

    public BaseTheme BaseTheme
    {
        get => _baseTheme;
        set
        {
            _baseTheme = value;
            ThemeManager.Instance.SetBaseTheme(value);
        }
    }
    public ColorTheme ColorTheme
    {
        get => _colorTheme;
        set
        {
            _colorTheme = value;
            ThemeManager.Instance.SetColorTheme(value);
        }
    }

    public ModernControlsWpf()
    {
        MergedDictionaries.Add(
            new ResourceDictionary
            {
                Source = new Uri(
                    $"pack://application:,,,/Russkyc.ModernControls.WPF;component/Themes/BaseThemes/{BaseTheme.ToString()}.xaml"
                )
            }
        );
        MergedDictionaries.Add(
            new ResourceDictionary
            {
                Source = new Uri(
                    $"pack://application:,,,/Russkyc.ModernControls.WPF;component/Themes/ColorThemes/{ColorTheme.ToString()}.xaml"
                )
            }
        );
        MergedDictionaries.Add(
            new ResourceDictionary
            {
                Source = new Uri(
                    "pack://application:,,,/Russkyc.ModernControls.WPF;component/Themes/Generic.xaml"
                )
            }
        );
    }
}
