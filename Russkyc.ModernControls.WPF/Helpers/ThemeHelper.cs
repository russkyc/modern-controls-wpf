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
using System.Windows.Threading;

namespace org.russkyc.moderncontrols.Helpers;

public static class ThemeHelper
{
    private static readonly Object _lock = new Object();
    private static Dictionary<string,string> _themes = new Dictionary<string, string>();

    public static void AddTheme(string key, string source)
    {
        lock (_lock)
        {
            _themes.Add(key,source);
        }
    }

    public static void RemoveTheme(string name, string source)
    {
        lock (_lock)
        {
            _themes.Remove(name);
        }
    }

    public static IEnumerable<string> GetThemes()
    {
        lock (_lock)
        {
            return _themes.Keys
                .AsEnumerable();
        }
    }
    public static void SetGlobalTheme(string name)
    {
        lock (_lock)
        {
            Dispatcher.CurrentDispatcher.BeginInvoke(
                () => Application.Current
                    .Resources
                    .MergedDictionaries
                    .First(dict => dict.Source.LocalPath.Contains("Russkyc.ModernControls.WPF;component/Themes/"))!
                    .Source = new Uri(_themes[name], UriKind.RelativeOrAbsolute));
        }
    }
}