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

using System.Windows;
using System.Windows.Media;
using Bindables.Wpf;

namespace org.russkyc.moderncontrols.Helpers;

public partial class ModernProperty : DependencyObject
{
    // Border Styling
    [AttachedProperty(typeof(CornerRadius))] public static readonly DependencyProperty CornerRadiusProperty;
    [AttachedProperty(typeof(Thickness))] public static readonly DependencyProperty BorderThicknessProperty;
    
    // Global Theming
    [AttachedProperty(typeof(Brush))] public static readonly DependencyProperty DefaultBackgroundProperty;
    [AttachedProperty(typeof(Brush))] public static readonly DependencyProperty DisabledBackgroundProperty;
    [AttachedProperty(typeof(Brush))] public static readonly DependencyProperty HoverBackgroundProperty;
    [AttachedProperty(typeof(Brush))] public static readonly DependencyProperty FocusedBackgroundProperty;
    [AttachedProperty(typeof(Brush))] public static readonly DependencyProperty PressedBackgroundProperty;
    [AttachedProperty(typeof(Brush))] public static readonly DependencyProperty CheckedBackgroundProperty;

    [AttachedProperty(typeof(Brush))] public static readonly DependencyProperty DefaultForegroundProperty;
    [AttachedProperty(typeof(Brush))] public static readonly DependencyProperty DisabledForegroundProperty;
    [AttachedProperty(typeof(Brush))] public static readonly DependencyProperty HoverForegroundProperty;
    [AttachedProperty(typeof(Brush))] public static readonly DependencyProperty FocusedForegroundProperty;
    [AttachedProperty(typeof(Brush))] public static readonly DependencyProperty PressedForegroundProperty;
    [AttachedProperty(typeof(Brush))] public static readonly DependencyProperty CheckedForegroundProperty;

    [AttachedProperty(typeof(Brush))] public static readonly DependencyProperty DefaultBorderBrushProperty;
    [AttachedProperty(typeof(Brush))] public static readonly DependencyProperty DisabledBorderBrushProperty;
    [AttachedProperty(typeof(Brush))] public static readonly DependencyProperty HoverBorderBrushProperty;
    [AttachedProperty(typeof(Brush))] public static readonly DependencyProperty FocusedBorderBrushProperty;
    [AttachedProperty(typeof(Brush))] public static readonly DependencyProperty PressedBorderBrushProperty;
    [AttachedProperty(typeof(Brush))] public static readonly DependencyProperty CheckedBorderBrushProperty;
}