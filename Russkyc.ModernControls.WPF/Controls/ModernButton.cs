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
using System.Windows.Controls;
using System.Windows.Media;
using Bindables.Wpf;

namespace org.russkyc.moderncontrols;

public partial class ModernButton : Button
{
    
    /// <summary>
    /// Customization Properties
    /// </summary>
    [DependencyProperty(typeof(CornerRadius))]
    public static readonly DependencyProperty CornerRadiusProperty;
    [DependencyProperty(typeof(object))]
    public static readonly DependencyProperty LeftIconProperty;
    [DependencyProperty(typeof(object))]
    public static readonly DependencyProperty RightIconProperty;
    [DependencyProperty(typeof(object))]
    public static readonly DependencyProperty LeftCenterIconProperty;
    [DependencyProperty(typeof(object))]
    public static readonly DependencyProperty RightCenterIconProperty;
    [DependencyProperty(typeof(double))]
    public static readonly DependencyProperty IconSizeProperty;
    [DependencyProperty(typeof(Brush))]
    public static readonly DependencyProperty IconForegroundProperty;
    [DependencyProperty(typeof(Thickness))]
    public static readonly DependencyProperty IconPaddingProperty;
    
    /// <summary>
    /// Background Properties
    /// </summary>
    [DependencyProperty(typeof(Brush))]
    public static readonly DependencyProperty DefaultBackgroundProperty;
    [DependencyProperty(typeof(Brush))]
    public static readonly DependencyProperty DisabledBackgroundProperty;
    [DependencyProperty(typeof(Brush))]
    public static readonly DependencyProperty HoverBackgroundProperty;
    [DependencyProperty(typeof(Brush))]
    public static readonly DependencyProperty PressedBackgroundProperty;
    
    /// <summary>
    /// Foreground Properties
    /// </summary>
    [DependencyProperty(typeof(Brush))]
    public static readonly DependencyProperty DefaultForegroundProperty;
    [DependencyProperty(typeof(Brush))]
    public static readonly DependencyProperty DisabledForegroundProperty;
    [DependencyProperty(typeof(Brush))]
    public static readonly DependencyProperty HoverForegroundProperty;
    [DependencyProperty(typeof(Brush))]
    public static readonly DependencyProperty PressedForegroundProperty;
    
    /// <summary>
    /// Border Properties
    /// </summary>
    [DependencyProperty(typeof(Brush))]
    public static readonly DependencyProperty DefaultBorderBrushProperty;
    [DependencyProperty(typeof(Brush))]
    public static readonly DependencyProperty DisabledBorderBrushProperty;
    [DependencyProperty(typeof(Brush))]
    public static readonly DependencyProperty HoverBorderBrushProperty;
    [DependencyProperty(typeof(Brush))]
    public static readonly DependencyProperty PressedBorderBrushProperty;

}