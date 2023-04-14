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
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace org.russkyc.moderncontrols;

public class ModernSwitch : ToggleButton
{
    
    /// <summary>
    /// Customization Properties
    /// </summary>
    public static readonly DependencyProperty ToggleCornerRadiusProperty = DependencyProperty.Register(
        nameof(ToggleCornerRadius), typeof(CornerRadius), typeof(ModernSwitch), new FrameworkPropertyMetadata());
    public CornerRadius ToggleCornerRadius
    {
        get { return (CornerRadius)GetValue(ToggleCornerRadiusProperty); }
        set { SetValue(ToggleCornerRadiusProperty, value); }
    }
    
    public static readonly DependencyProperty CornerRadiusProperty = DependencyProperty.Register(
        nameof(CornerRadius),
        typeof(CornerRadius),
        typeof(ModernSwitch),
        new FrameworkPropertyMetadata());
    public CornerRadius CornerRadius
    {
        get => (CornerRadius)GetValue(CornerRadiusProperty);
        set => SetValue(CornerRadiusProperty, value);
    }
    
    public static readonly DependencyProperty LeftIconProperty = DependencyProperty.Register(
        nameof(LeftIcon),
        typeof(object),
        typeof(ModernSwitch),
        new FrameworkPropertyMetadata());
    public object? LeftIcon
    {
        get => (object?)GetValue(LeftIconProperty);
        set => SetValue(LeftIconProperty, value);
    }
    
    public static readonly DependencyProperty RightIconProperty = DependencyProperty.Register(
        nameof(RightIcon),
        typeof(object),
        typeof(ModernSwitch),
        new FrameworkPropertyMetadata());
    public object? RightIcon
    {
        get => (object?)GetValue(RightIconProperty);
        set => SetValue(RightIconProperty, value);
    }
    
    public static readonly DependencyProperty LeftCenterIconProperty = DependencyProperty.Register(
        nameof(LeftCenterIcon),
        typeof(object),
        typeof(ModernSwitch),
        new FrameworkPropertyMetadata());
    public object? LeftCenterIcon
    {
        get => (object?)GetValue(LeftCenterIconProperty);
        set => SetValue(LeftCenterIconProperty, value);
    }
    
    public static readonly DependencyProperty RightCenterIconProperty = DependencyProperty.Register(
        nameof(RightCenterIcon),
        typeof(object),
        typeof(ModernSwitch),
        new FrameworkPropertyMetadata());
    public object? RightCenterIcon
    {
        get => (object?)GetValue(RightCenterIconProperty);
        set => SetValue(RightCenterIconProperty, value);
    }
    
    public static readonly DependencyProperty IconSizeProperty = DependencyProperty.Register(
        nameof(IconSize),
        typeof(double),
        typeof(ModernSwitch),
        new FrameworkPropertyMetadata());
    public double IconSize
    {
        get => (double)GetValue(IconSizeProperty);
        set => SetValue(IconSizeProperty, value);
    }
    
    public static readonly DependencyProperty IconForegroundProperty = DependencyProperty.Register(
        nameof(IconForeground),
        typeof(Brush),
        typeof(ModernSwitch),
        new FrameworkPropertyMetadata());
    public Brush? IconForeground
    {
        get => (Brush?)GetValue(IconForegroundProperty);
        set => SetValue(IconForegroundProperty, value);
    }
    
    public static readonly DependencyProperty IconPaddingProperty = DependencyProperty.Register(
        nameof(IconPadding),
        typeof(Thickness),
        typeof(ModernSwitch),
        new FrameworkPropertyMetadata());
    public Thickness IconPadding
    {
        get => (Thickness)GetValue(IconPaddingProperty);
        set => SetValue(IconPaddingProperty, value);
    }
    
    /// <summary>
    /// Background Properties
    /// </summary>
    public static readonly DependencyProperty DefaultBackgroundProperty = DependencyProperty.Register(
        nameof(DefaultBackground),
        typeof(Brush),
        typeof(ModernSwitch),
        new FrameworkPropertyMetadata());
    public Brush? DefaultBackground
    {
        get => (Brush?)GetValue(DefaultBackgroundProperty);
        set => SetValue(DefaultBackgroundProperty, value);
    }
    
    public static readonly DependencyProperty DisabledBackgroundProperty = DependencyProperty.Register(
        nameof(DisabledBackground),
        typeof(Brush),
        typeof(ModernSwitch),
        new FrameworkPropertyMetadata());
    public Brush? DisabledBackground
    {
        get => (Brush?)GetValue(DisabledBackgroundProperty);
        set => SetValue(DisabledBackgroundProperty, value);
    }
    
    public static readonly DependencyProperty HoverBackgroundProperty = DependencyProperty.Register(
        nameof(HoverBackground),
        typeof(Brush),
        typeof(ModernSwitch),
        new FrameworkPropertyMetadata());
    public Brush? HoverBackground
    {
        get => (Brush?)GetValue(HoverBackgroundProperty);
        set => SetValue(HoverBackgroundProperty, value);
    }
    
    public static readonly DependencyProperty PressedBackgroundProperty = DependencyProperty.Register(
        nameof(PressedBackground),
        typeof(Brush),
        typeof(ModernSwitch),
        new FrameworkPropertyMetadata());
    public Brush? PressedBackground
    {
        get => (Brush?)GetValue(PressedBackgroundProperty);
        set => SetValue(PressedBackgroundProperty, value);
    }
    
    public static readonly DependencyProperty CheckedBackgroundProperty = DependencyProperty.Register(
        nameof(CheckedBackground),
        typeof(Brush),
        typeof(ModernSwitch),
        new FrameworkPropertyMetadata());
    public Brush? CheckedBackground
    {
        get => (Brush?)GetValue(CheckedBackgroundProperty);
        set => SetValue(CheckedBackgroundProperty, value);
    }
    
    /// <summary>
    /// Foreground Properties
    /// </summary>
    public static readonly DependencyProperty DefaultForegroundProperty = DependencyProperty.Register(
        nameof(DefaultForeground),
        typeof(Brush),
        typeof(ModernSwitch),
        new FrameworkPropertyMetadata());
    public Brush? DefaultForeground
    {
        get => (Brush?)GetValue(DefaultForegroundProperty);
        set => SetValue(DefaultForegroundProperty, value);
    }
    
    public static readonly DependencyProperty DisabledForegroundProperty = DependencyProperty.Register(
        nameof(DisabledForeground),
        typeof(Brush),
        typeof(ModernSwitch),
        new FrameworkPropertyMetadata());
    public Brush? DisabledForeground
    {
        get => (Brush?)GetValue(DisabledForegroundProperty);
        set => SetValue(DisabledForegroundProperty, value);
    }
    
    public static readonly DependencyProperty HoverForegroundProperty = DependencyProperty.Register(
        nameof(HoverForeground),
        typeof(Brush),
        typeof(ModernSwitch),
        new FrameworkPropertyMetadata());
    public Brush? HoverForeground
    {
        get => (Brush?)GetValue(HoverForegroundProperty);
        set => SetValue(HoverForegroundProperty, value);
    }
    
    public static readonly DependencyProperty PressedForegroundProperty = DependencyProperty.Register(
        nameof(PressedForeground),
        typeof(Brush),
        typeof(ModernSwitch),
        new FrameworkPropertyMetadata());
    public Brush? PressedForeground
    {
        get => (Brush?)GetValue(PressedForegroundProperty);
        set => SetValue(PressedForegroundProperty, value);
    }
    
    public static readonly DependencyProperty CheckedForegroundProperty = DependencyProperty.Register(
        nameof(CheckedForeground),
        typeof(Brush),
        typeof(ModernSwitch),
        new FrameworkPropertyMetadata());
    public Brush? CheckedForeground
    {
        get => (Brush?)GetValue(CheckedForegroundProperty);
        set => SetValue(CheckedForegroundProperty, value);
    }
    
    /// <summary>
    /// Border Properties
    /// </summary>
    public static readonly DependencyProperty DefaultBorderBrushProperty = DependencyProperty.Register(
        nameof(DefaultBorderBrush),
        typeof(Brush),
        typeof(ModernSwitch),
        new FrameworkPropertyMetadata());
    public Brush? DefaultBorderBrush
    {
        get => (Brush?)GetValue(DefaultBorderBrushProperty);
        set => SetValue(DefaultBorderBrushProperty, value);
    }
    
    public static readonly DependencyProperty DisabledBorderBrushProperty = DependencyProperty.Register(
        nameof(DisabledBorderBrush),
        typeof(Brush),
        typeof(ModernSwitch),
        new FrameworkPropertyMetadata());
    public Brush? DisabledBorderBrush
    {
        get => (Brush?)GetValue(DisabledBorderBrushProperty);
        set => SetValue(DisabledBorderBrushProperty, value);
    }
    
    public static readonly DependencyProperty HoverBorderBrushProperty = DependencyProperty.Register(
        nameof(HoverBorderBrush),
        typeof(Brush),
        typeof(ModernSwitch),
        new FrameworkPropertyMetadata());
    public Brush? HoverBorderBrush
    {
        get => (Brush?)GetValue(HoverBorderBrushProperty);
        set => SetValue(HoverBorderBrushProperty, value);
    }
    
    public static readonly DependencyProperty PressedBorderBrushProperty = DependencyProperty.Register(
        nameof(PressedBorderBrush),
        typeof(Brush),
        typeof(ModernSwitch),
        new FrameworkPropertyMetadata());    
    public Brush? PressedBorderBrush
    {
        get => (Brush?)GetValue(PressedBorderBrushProperty);
        set => SetValue(PressedBorderBrushProperty, value);
    }
    
    public static readonly DependencyProperty CheckedBorderBrushProperty = DependencyProperty.Register(
        nameof(CheckedBorderBrush),
        typeof(Brush),
        typeof(ModernSwitch),
        new FrameworkPropertyMetadata());    
    public Brush? CheckedBorderBrush
    {
        get => (Brush?)GetValue(CheckedBorderBrushProperty);
        set => SetValue(CheckedBorderBrushProperty, value);
    }
        
}