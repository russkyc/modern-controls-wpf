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

namespace org.russkyc.moderncontrols;

public class ModernTextBox : TextBox
{

    /// <summary>
    /// Customization Properties
    /// </summary>
    public static readonly DependencyProperty PlaceholderProperty = DependencyProperty.Register(
        nameof(Placeholder),
        typeof(string),
        typeof(ModernTextBox),
        new FrameworkPropertyMetadata());
    public string? Placeholder
    {
        get => (string?)GetValue(PlaceholderProperty);
        set => SetValue(PlaceholderProperty, value);
    }
    
    public static readonly DependencyProperty HelperTextProperty = DependencyProperty.Register(
        nameof(HelperText),
        typeof(string),
        typeof(ModernTextBox),
        new FrameworkPropertyMetadata());
    public string? HelperText
    {
        get => (string?)GetValue(HelperTextProperty);
        set => SetValue(HelperTextProperty, value);
    }

    public static readonly DependencyProperty IsPasswordBoxProperty = DependencyProperty.Register(
        nameof(IsPasswordBox), typeof(bool), typeof(ModernTextBox), new PropertyMetadata());

    public bool IsPasswordBox
    {
        get { return (bool)GetValue(IsPasswordBoxProperty); }
        set { SetValue(IsPasswordBoxProperty, value); }
    }
    
    public static readonly DependencyProperty PrefixProperty = DependencyProperty.Register(
        nameof(Prefix),
        typeof(string),
        typeof(ModernTextBox),
        new FrameworkPropertyMetadata());
    public string? Prefix
    {
        get => (string?)GetValue(PrefixProperty);
        set => SetValue(PrefixProperty, value);
    }
    
    public static readonly DependencyProperty SuffixProperty = DependencyProperty.Register(
        nameof(Suffix),
        typeof(string),
        typeof(ModernTextBox),
        new FrameworkPropertyMetadata());
    public string? Suffix
    {
        get => (string?)GetValue(SuffixProperty);
        set => SetValue(SuffixProperty, value);
    }
    
    public static readonly DependencyProperty CornerRadiusProperty = DependencyProperty.Register(
        nameof(CornerRadius),
        typeof(CornerRadius),
        typeof(ModernTextBox),
        new FrameworkPropertyMetadata());
    public CornerRadius CornerRadius
    {
        get => (CornerRadius)GetValue(CornerRadiusProperty);
        set => SetValue(CornerRadiusProperty, value);
    }
    
    public static readonly DependencyProperty LeftIconProperty = DependencyProperty.Register(
        nameof(LeftIcon),
        typeof(object),
        typeof(ModernTextBox),
        new FrameworkPropertyMetadata());
    public object? LeftIcon
    {
        get => (object?)GetValue(LeftIconProperty);
        set => SetValue(LeftIconProperty, value);
    }
    
    public static readonly DependencyProperty RightIconProperty = DependencyProperty.Register(
        nameof(RightIcon),
        typeof(object),
        typeof(ModernTextBox),
        new FrameworkPropertyMetadata());
    public object? RightIcon
    {
        get => (object?)GetValue(RightIconProperty);
        set => SetValue(RightIconProperty, value);
    }
    
    public static readonly DependencyProperty IconSizeProperty = DependencyProperty.Register(
        nameof(IconSize),
        typeof(double),
        typeof(ModernTextBox),
        new FrameworkPropertyMetadata());
    public double IconSize
    {
        get => (double)GetValue(IconSizeProperty);
        set => SetValue(IconSizeProperty, value);
    }
    
    public static readonly DependencyProperty IconForegroundProperty = DependencyProperty.Register(
        nameof(IconForeground),
        typeof(Brush),
        typeof(ModernTextBox),
        new FrameworkPropertyMetadata());
    public Brush? IconForeground
    {
        get => (Brush?)GetValue(IconForegroundProperty);
        set => SetValue(IconForegroundProperty, value);
    }
    
    public static readonly DependencyProperty IconPaddingProperty = DependencyProperty.Register(
        nameof(IconPadding),
        typeof(Thickness),
        typeof(ModernTextBox),
        new FrameworkPropertyMetadata());
    public Thickness IconPadding
    {
        get => (Thickness)GetValue(IconPaddingProperty);
        set => SetValue(IconPaddingProperty, value);
    }
    
    /// <summary>
    /// Placeholder Properties
    /// </summary>
    public static readonly DependencyProperty PlaceholderForegroundProperty = DependencyProperty.Register(
        nameof(PlaceholderForeground),
        typeof(Brush),
        typeof(ModernTextBox),
        new FrameworkPropertyMetadata());
    public Brush? PlaceholderForeground
    {
        get => (Brush?)GetValue(PlaceholderForegroundProperty);
        set => SetValue(PlaceholderForegroundProperty, value);
    }
    
    /// <summary>
    /// Background Properties
    /// </summary>
    public static readonly DependencyProperty DefaultBackgroundProperty = DependencyProperty.Register(
        nameof(DefaultBackground),
        typeof(Brush),
        typeof(ModernTextBox),
        new FrameworkPropertyMetadata());
    public Brush? DefaultBackground
    {
        get => (Brush?)GetValue(DefaultBackgroundProperty);
        set => SetValue(DefaultBackgroundProperty, value);
    }
    
    public static readonly DependencyProperty DisabledBackgroundProperty = DependencyProperty.Register(
        nameof(DisabledBackground),
        typeof(Brush),
        typeof(ModernTextBox),
        new FrameworkPropertyMetadata());
    public Brush? DisabledBackground
    {
        get => (Brush?)GetValue(DisabledBackgroundProperty);
        set => SetValue(DisabledBackgroundProperty, value);
    }
    
    public static readonly DependencyProperty HoverBackgroundProperty = DependencyProperty.Register(
        nameof(HoverBackground),
        typeof(Brush),
        typeof(ModernTextBox),
        new FrameworkPropertyMetadata());
    public Brush? HoverBackground
    {
        get => (Brush?)GetValue(HoverBackgroundProperty);
        set => SetValue(HoverBackgroundProperty, value);
    }
    
    public static readonly DependencyProperty FocusedBackgroundProperty = DependencyProperty.Register(
        nameof(FocusedBackground),
        typeof(Brush),
        typeof(ModernTextBox),
        new FrameworkPropertyMetadata());
    public Brush? FocusedBackground
    {
        get => (Brush?)GetValue(FocusedBackgroundProperty);
        set => SetValue(FocusedBackgroundProperty, value);
    }
    
    /// <summary>
    /// Foreground Properties
    /// </summary>
    public static readonly DependencyProperty DefaultForegroundProperty = DependencyProperty.Register(
        nameof(DefaultForeground),
        typeof(Brush),
        typeof(ModernTextBox),
        new FrameworkPropertyMetadata());
    public Brush? DefaultForeground
    {
        get => (Brush?)GetValue(DefaultForegroundProperty);
        set => SetValue(DefaultForegroundProperty, value);
    }
    
    public static readonly DependencyProperty DisabledForegroundProperty = DependencyProperty.Register(
        nameof(DisabledForeground),
        typeof(Brush),
        typeof(ModernTextBox),
        new FrameworkPropertyMetadata());
    public Brush? DisabledForeground
    {
        get => (Brush?)GetValue(DisabledForegroundProperty);
        set => SetValue(DisabledForegroundProperty, value);
    }
    
    public static readonly DependencyProperty HoverForegroundProperty = DependencyProperty.Register(
        nameof(HoverForeground),
        typeof(Brush),
        typeof(ModernTextBox),
        new FrameworkPropertyMetadata());
    public Brush? HoverForeground
    {
        get => (Brush?)GetValue(HoverForegroundProperty);
        set => SetValue(HoverForegroundProperty, value);
    }
    
    public static readonly DependencyProperty FocusedForegroundProperty = DependencyProperty.Register(
        nameof(FocusedForeground),
        typeof(Brush),
        typeof(ModernTextBox),
        new FrameworkPropertyMetadata());
    public Brush? FocusedForeground
    {
        get => (Brush?)GetValue(FocusedForegroundProperty);
        set => SetValue(FocusedForegroundProperty, value);
    }

    /// <summary>
    /// Border Properties
    /// </summary>
    public static readonly DependencyProperty DefaultBorderBrushProperty = DependencyProperty.Register(
        nameof(DefaultBorderBrush),
        typeof(Brush),
        typeof(ModernTextBox),
        new FrameworkPropertyMetadata());
    public Brush? DefaultBorderBrush
    {
        get => (Brush?)GetValue(DefaultBorderBrushProperty);
        set => SetValue(DefaultBorderBrushProperty, value);
    }
    
    public static readonly DependencyProperty DisabledBorderBrushProperty = DependencyProperty.Register(
        nameof(DisabledBorderBrush),
        typeof(Brush),
        typeof(ModernTextBox),
        new FrameworkPropertyMetadata());
    public Brush? DisabledBorderBrush
    {
        get => (Brush?)GetValue(DisabledBorderBrushProperty);
        set => SetValue(DisabledBorderBrushProperty, value);
    }
    
    public static readonly DependencyProperty HoverBorderBrushProperty = DependencyProperty.Register(
        nameof(HoverBorderBrush),
        typeof(Brush),
        typeof(ModernTextBox),
        new FrameworkPropertyMetadata());
    public Brush? HoverBorderBrush
    {
        get => (Brush?)GetValue(HoverBorderBrushProperty);
        set => SetValue(HoverBorderBrushProperty, value);
    }
    
    public static readonly DependencyProperty FocusedBorderBrushProperty = DependencyProperty.Register(
        nameof(FocusedBorderBrush),
        typeof(Brush),
        typeof(ModernTextBox),
        new FrameworkPropertyMetadata());    
    public Brush? FocusedBorderBrush
    {
        get => (Brush?)GetValue(FocusedBorderBrushProperty);
        set => SetValue(FocusedBorderBrushProperty, value);
    }

}