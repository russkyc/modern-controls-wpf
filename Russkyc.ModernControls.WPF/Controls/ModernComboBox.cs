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

public partial class ModernComboBox : ComboBox
{
    
    /// <summary>
    /// Customization Properties
    /// </summary>
    public static readonly DependencyProperty PlaceholderProperty = DependencyProperty.Register(
        nameof(Placeholder),
        typeof(string),
        typeof(ModernComboBox),
        new FrameworkPropertyMetadata());
    public string? Placeholder
    {
        get => (string?)GetValue(PlaceholderProperty);
        set => SetValue(PlaceholderProperty, value);
    }
    
    public static readonly DependencyProperty CornerRadiusProperty = DependencyProperty.Register(
        nameof(CornerRadius),
        typeof(CornerRadius),
        typeof(ModernComboBox),
        new FrameworkPropertyMetadata());
    public CornerRadius CornerRadius
    {
        get => (CornerRadius)GetValue(CornerRadiusProperty);
        set => SetValue(CornerRadiusProperty, value);
    }
    
    public static readonly DependencyProperty IconProperty = DependencyProperty.Register(
        nameof(Icon),
        typeof(object),
        typeof(ModernComboBox),
        new FrameworkPropertyMetadata());
    public object? Icon
    {
        get => (object?)GetValue(IconProperty);
        set => SetValue(IconProperty, value);
    }
    
    public static readonly DependencyProperty IconSizeProperty = DependencyProperty.Register(
        nameof(IconSize),
        typeof(double),
        typeof(ModernComboBox),
        new FrameworkPropertyMetadata());
    public double IconSize
    {
        get => (double)GetValue(IconSizeProperty);
        set => SetValue(IconSizeProperty, value);
    }
    
    public static readonly DependencyProperty IconForegroundProperty = DependencyProperty.Register(
        nameof(IconForeground),
        typeof(Brush),
        typeof(ModernComboBox),
        new FrameworkPropertyMetadata());
    public Brush? IconForeground
    {
        get => (Brush?)GetValue(IconForegroundProperty);
        set => SetValue(IconForegroundProperty, value);
    }
    
    public static readonly DependencyProperty IconPaddingProperty = DependencyProperty.Register(
        nameof(IconPadding),
        typeof(Thickness),
        typeof(ModernComboBox),
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
        typeof(ModernComboBox),
        new FrameworkPropertyMetadata());
    public Brush? PlaceholderForeground
    {
        get => (Brush?)GetValue(PlaceholderForegroundProperty);
        set => SetValue(PlaceholderForegroundProperty, value);
    }
    
    public static readonly DependencyProperty PressedPlaceholderForegroundProperty = DependencyProperty.Register(
        nameof(PressedPlaceholderForeground),
        typeof(Brush),
        typeof(ModernComboBox),
        new FrameworkPropertyMetadata());
    public Brush? PressedPlaceholderForeground
    {
        get => (Brush?)GetValue(PressedPlaceholderForegroundProperty);
        set => SetValue(PressedPlaceholderForegroundProperty, value);
    }
    
    public static readonly DependencyProperty ItemCornerRadiusProperty = DependencyProperty.Register(
        nameof(ItemCornerRadius),
        typeof(CornerRadius),
        typeof(ModernComboBox),
        new FrameworkPropertyMetadata());
    public CornerRadius ItemCornerRadius
    {
        get => (CornerRadius)GetValue(ItemCornerRadiusProperty);
        set => SetValue(ItemCornerRadiusProperty, value);
    }
    
    /// <summary>
    /// Background Properties
    /// </summary>
    public static readonly DependencyProperty DefaultBackgroundProperty = DependencyProperty.Register(
        nameof(DefaultBackground),
        typeof(Brush),
        typeof(ModernComboBox),
        new FrameworkPropertyMetadata());
    public Brush? DefaultBackground
    {
        get => (Brush?)GetValue(DefaultBackgroundProperty);
        set => SetValue(DefaultBackgroundProperty, value);
    }
    
    public static readonly DependencyProperty DisabledBackgroundProperty = DependencyProperty.Register(
        nameof(DisabledBackground),
        typeof(Brush),
        typeof(ModernComboBox),
        new FrameworkPropertyMetadata());
    public Brush? DisabledBackground
    {
        get => (Brush?)GetValue(DisabledBackgroundProperty);
        set => SetValue(DisabledBackgroundProperty, value);
    }
    
    public static readonly DependencyProperty HoverBackgroundProperty = DependencyProperty.Register(
        nameof(HoverBackground),
        typeof(Brush),
        typeof(ModernComboBox),
        new FrameworkPropertyMetadata());
    public Brush? HoverBackground
    {
        get => (Brush?)GetValue(HoverBackgroundProperty);
        set => SetValue(HoverBackgroundProperty, value);
    }
    
    public static readonly DependencyProperty PressedBackgroundProperty = DependencyProperty.Register(
        nameof(PressedBackground),
        typeof(Brush),
        typeof(ModernComboBox),
        new FrameworkPropertyMetadata());
    public Brush? PressedBackground
    {
        get => (Brush?)GetValue(PressedBackgroundProperty);
        set => SetValue(PressedBackgroundProperty, value);
    }
    
    public static readonly DependencyProperty SelectedBackgroundProperty = DependencyProperty.Register(
        nameof(SelectedBackground),
        typeof(Brush),
        typeof(ModernComboBox),
        new FrameworkPropertyMetadata());
    public Brush? SelectedBackground
    {
        get => (Brush?)GetValue(SelectedBackgroundProperty);
        set => SetValue(SelectedBackgroundProperty, value);
    }
    
    /// <summary>
    /// Foreground Properties
    /// </summary>
    public static readonly DependencyProperty DefaultForegroundProperty = DependencyProperty.Register(
        nameof(DefaultForeground),
        typeof(Brush),
        typeof(ModernComboBox),
        new FrameworkPropertyMetadata());
    public Brush? DefaultForeground
    {
        get => (Brush?)GetValue(DefaultForegroundProperty);
        set => SetValue(DefaultForegroundProperty, value);
    }
    
    public static readonly DependencyProperty DisabledForegroundProperty = DependencyProperty.Register(
        nameof(DisabledForeground),
        typeof(Brush),
        typeof(ModernComboBox),
        new FrameworkPropertyMetadata());
    public Brush? DisabledForeground
    {
        get => (Brush?)GetValue(DisabledForegroundProperty);
        set => SetValue(DisabledForegroundProperty, value);
    }
    
    public static readonly DependencyProperty HoverForegroundProperty = DependencyProperty.Register(
        nameof(HoverForeground),
        typeof(Brush),
        typeof(ModernComboBox),
        new FrameworkPropertyMetadata());
    public Brush? HoverForeground
    {
        get => (Brush?)GetValue(HoverForegroundProperty);
        set => SetValue(HoverForegroundProperty, value);
    }
    
    public static readonly DependencyProperty PressedForegroundProperty = DependencyProperty.Register(
        nameof(PressedForeground),
        typeof(Brush),
        typeof(ModernComboBox),
        new FrameworkPropertyMetadata());
    public Brush? PressedForeground
    {
        get => (Brush?)GetValue(PressedForegroundProperty);
        set => SetValue(PressedForegroundProperty, value);
    }
    
    /// <summary>
    /// Item Background Properties
    /// </summary>
    public static readonly DependencyProperty ItemBackgroundProperty = DependencyProperty.Register(
        nameof(ItemBackground),
        typeof(Brush),
        typeof(ModernComboBox),
        new FrameworkPropertyMetadata());
    public Brush? ItemBackground
    {
        get => (Brush?)GetValue(ItemBackgroundProperty);
        set => SetValue(ItemBackgroundProperty, value);
    }
    public static readonly DependencyProperty HoverItemBackgroundProperty = DependencyProperty.Register(
        nameof(HoverItemBackground),
        typeof(Brush),
        typeof(ModernComboBox),
        new FrameworkPropertyMetadata());
    public Brush? HoverItemBackground
    {
        get => (Brush?)GetValue(HoverItemBackgroundProperty);
        set => SetValue(HoverItemBackgroundProperty, value);
    }
    public static readonly DependencyProperty SelectedItemBackgroundProperty = DependencyProperty.Register(
        nameof(SelectedItemBackground),
        typeof(Brush),
        typeof(ModernComboBox),
        new FrameworkPropertyMetadata());
    public Brush? SelectedItemBackground
    {
        get => (Brush?)GetValue(SelectedItemBackgroundProperty);
        set => SetValue(SelectedItemBackgroundProperty, value);
    }
    
    /// <summary>
    /// Item Foreground Properties
    /// </summary>
    public static readonly DependencyProperty ItemForegroundProperty = DependencyProperty.Register(
        nameof(ItemForeground),
        typeof(Brush),
        typeof(ModernComboBox),
        new FrameworkPropertyMetadata());
    public Brush? ItemForeground
    {
        get => (Brush?)GetValue(ItemForegroundProperty);
        set => SetValue(ItemForegroundProperty, value);
    }
    public static readonly DependencyProperty HoverItemForegroundProperty = DependencyProperty.Register(
        nameof(HoverItemForeground),
        typeof(Brush),
        typeof(ModernComboBox),
        new FrameworkPropertyMetadata());
    public Brush? HoverItemForeground
    {
        get => (Brush?)GetValue(HoverItemForegroundProperty);
        set => SetValue(HoverItemForegroundProperty, value);
    }
    public static readonly DependencyProperty SelectedItemForegroundProperty = DependencyProperty.Register(
        nameof(SelectedItemForeground),
        typeof(Brush),
        typeof(ModernComboBox),
        new FrameworkPropertyMetadata());
    public Brush? SelectedItemForeground
    {
        get => (Brush?)GetValue(SelectedItemForegroundProperty);
        set => SetValue(SelectedItemForegroundProperty, value);
    }
    
    /// <summary>
    /// Dropdown Background Properties
    /// </summary>
    public static readonly DependencyProperty DropdownBackgroundProperty = DependencyProperty.Register(
        nameof(DropdownBackground),
        typeof(Brush),
        typeof(ModernComboBox),
        new FrameworkPropertyMetadata());
    public Brush? DropdownBackground
    {
        get => (Brush?)GetValue(DropdownBackgroundProperty);
        set => SetValue(DropdownBackgroundProperty, value);
    }
    
    public static readonly DependencyProperty DropdownBorderBrushProperty = DependencyProperty.Register(
        nameof(DropdownBorderBrush),
        typeof(Brush),
        typeof(ModernComboBox),
        new FrameworkPropertyMetadata());
    public Brush? DropdownBorderBrush
    {
        get => (Brush?)GetValue(DropdownBorderBrushProperty);
        set => SetValue(DropdownBorderBrushProperty, value);
    }
}