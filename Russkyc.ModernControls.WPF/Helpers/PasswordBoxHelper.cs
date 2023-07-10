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

namespace org.russkyc.moderncontrols.Helpers;

public class PasswordBoxHelper : Control
{
    /// <summary>
    /// Customization Properties
    /// </summary>

    public static readonly DependencyProperty PlaceholderProperty = DependencyProperty.RegisterAttached(
        "Placeholder",
        typeof(string),
        typeof(PasswordBoxHelper),
        new FrameworkPropertyMetadata());

    [AttachedPropertyBrowsableForType(typeof(TextBox))]
    [AttachedPropertyBrowsableForType(typeof(PasswordBox))]
    public static string? GetPlaceholder(DependencyObject obj)
    {
        return (string?)obj.GetValue(PlaceholderProperty);
    }

    [AttachedPropertyBrowsableForType(typeof(TextBox))]
    [AttachedPropertyBrowsableForType(typeof(PasswordBox))]
    public static void SetPlaceholder(DependencyObject obj, string? value)
    {
        obj.SetValue(PlaceholderProperty, value);
    }

    public static readonly DependencyProperty HelperTextProperty = DependencyProperty.RegisterAttached(
        "HelperText",
        typeof(string),
        typeof(PasswordBoxHelper),
        new FrameworkPropertyMetadata());

    [AttachedPropertyBrowsableForType(typeof(TextBox))]
    [AttachedPropertyBrowsableForType(typeof(PasswordBox))]
    public static string? GetHelperText(DependencyObject obj)
    {
        return (string?)obj.GetValue(HelperTextProperty);
    }

    [AttachedPropertyBrowsableForType(typeof(TextBox))]
    [AttachedPropertyBrowsableForType(typeof(PasswordBox))]
    public static void SetHelperText(DependencyObject obj, string? value)
    {
        obj.SetValue(HelperTextProperty, value);
    }

    public static readonly DependencyProperty PrefixProperty = DependencyProperty.RegisterAttached(
        "Prefix",
        typeof(string),
        typeof(PasswordBoxHelper),
        new FrameworkPropertyMetadata());

    [AttachedPropertyBrowsableForType(typeof(TextBox))]
    [AttachedPropertyBrowsableForType(typeof(PasswordBox))]
    public static string? GetPrefix(DependencyObject obj)
    {
        return (string?)obj.GetValue(PrefixProperty);
    }

    [AttachedPropertyBrowsableForType(typeof(TextBox))]
    [AttachedPropertyBrowsableForType(typeof(PasswordBox))]
    public static void SetPrefix(DependencyObject obj, string? value)
    {
        obj.SetValue(PrefixProperty, value);
    }

    public static readonly DependencyProperty SuffixProperty = DependencyProperty.RegisterAttached(
        "Suffix",
        typeof(string),
        typeof(PasswordBoxHelper),
        new FrameworkPropertyMetadata());

    [AttachedPropertyBrowsableForType(typeof(TextBox))]
    [AttachedPropertyBrowsableForType(typeof(PasswordBox))]
    public static string? GetSuffix(DependencyObject obj)
    {
        return (string?)obj.GetValue(SuffixProperty);
    }

    [AttachedPropertyBrowsableForType(typeof(TextBox))]
    [AttachedPropertyBrowsableForType(typeof(PasswordBox))]
    public static void SetSuffix(DependencyObject obj, string? value)
    {
        obj.SetValue(SuffixProperty, value);
    }

    public static readonly DependencyProperty CornerRadiusProperty = DependencyProperty.RegisterAttached(
        "CornerRadius",
        typeof(CornerRadius),
        typeof(PasswordBoxHelper),
        new FrameworkPropertyMetadata());

    [AttachedPropertyBrowsableForType(typeof(TextBox))]
    [AttachedPropertyBrowsableForType(typeof(PasswordBox))]
    public static CornerRadius GetCornerRadius(DependencyObject obj)
    {
        return (CornerRadius)obj.GetValue(CornerRadiusProperty);
    }

    [AttachedPropertyBrowsableForType(typeof(TextBox))]
    [AttachedPropertyBrowsableForType(typeof(PasswordBox))]
    public static void SetCornerRadius(DependencyObject obj, CornerRadius value)
    {
        obj.SetValue(CornerRadiusProperty, value);
    }
    
    public static readonly DependencyProperty LeftIconProperty = DependencyProperty.RegisterAttached(
        "LeftIcon",
        typeof(object),
        typeof(PasswordBoxHelper),
        new FrameworkPropertyMetadata());

    [AttachedPropertyBrowsableForType(typeof(TextBox))]
    [AttachedPropertyBrowsableForType(typeof(PasswordBox))]
    public static object? GetLeftIcon(DependencyObject obj)
    {
        return (object?)obj.GetValue(LeftIconProperty);
    }

    [AttachedPropertyBrowsableForType(typeof(TextBox))]
    [AttachedPropertyBrowsableForType(typeof(PasswordBox))]
    public static void SetLeftIcon(DependencyObject obj, object? value)
    {
        obj.SetValue(LeftIconProperty, value);
    }

    public static readonly DependencyProperty RightIconProperty = DependencyProperty.RegisterAttached(
        "RightIcon",
        typeof(object),
        typeof(PasswordBoxHelper),
        new FrameworkPropertyMetadata());

    [AttachedPropertyBrowsableForType(typeof(TextBox))]
    [AttachedPropertyBrowsableForType(typeof(PasswordBox))]
    public static object? GetRightIcon(DependencyObject obj)
    {
        return (object?)obj.GetValue(RightIconProperty);
    }

    [AttachedPropertyBrowsableForType(typeof(TextBox))]
    [AttachedPropertyBrowsableForType(typeof(PasswordBox))]
    public static void SetRightIcon(DependencyObject obj, object? value)
    {
        obj.SetValue(RightIconProperty, value);
    }

    public static readonly DependencyProperty IconSizeProperty = DependencyProperty.RegisterAttached(
        "IconSize",
        typeof(double),
        typeof(PasswordBoxHelper),
        new FrameworkPropertyMetadata());

    [AttachedPropertyBrowsableForType(typeof(TextBox))]
    [AttachedPropertyBrowsableForType(typeof(PasswordBox))]
    public static double GetIconSize(DependencyObject obj)
    {
        return (double)obj.GetValue(IconSizeProperty);
    }

    [AttachedPropertyBrowsableForType(typeof(TextBox))]
    [AttachedPropertyBrowsableForType(typeof(PasswordBox))]
    public static void SetIconSize(DependencyObject obj, double value)
    {
        obj.SetValue(IconSizeProperty, value);
    }

    public static readonly DependencyProperty IconForegroundProperty = DependencyProperty.RegisterAttached(
        "IconForeground",
        typeof(Brush),
        typeof(PasswordBoxHelper),
        new FrameworkPropertyMetadata());

    [AttachedPropertyBrowsableForType(typeof(TextBox))]
    [AttachedPropertyBrowsableForType(typeof(PasswordBox))]
    public static Brush? GetIconForeground(DependencyObject obj)
    {
        return (Brush?)obj.GetValue(IconForegroundProperty);
    }

    [AttachedPropertyBrowsableForType(typeof(TextBox))]
    [AttachedPropertyBrowsableForType(typeof(PasswordBox))]
    public static void SetIconForeground(DependencyObject obj, Brush? value)
    {
        obj.SetValue(IconForegroundProperty, value);
    }

    public static readonly DependencyProperty IconPaddingProperty = DependencyProperty.RegisterAttached(
        "IconPadding",
        typeof(Thickness),
        typeof(PasswordBoxHelper),
        new FrameworkPropertyMetadata());

    [AttachedPropertyBrowsableForType(typeof(TextBox))]
    [AttachedPropertyBrowsableForType(typeof(PasswordBox))]
    public static Thickness GetIconPadding(DependencyObject obj)
    {
        return (Thickness)obj.GetValue(IconPaddingProperty);
    }

    [AttachedPropertyBrowsableForType(typeof(TextBox))]
    [AttachedPropertyBrowsableForType(typeof(PasswordBox))]
    public static void SetIconPadding(DependencyObject obj, Thickness value)
    {
        obj.SetValue(IconPaddingProperty, value);
    }
    
    /// <summary>
    /// Placeholder Properties
    /// </summary>
    public static readonly DependencyProperty PlaceholderForegroundProperty = DependencyProperty.RegisterAttached(
        "PlaceholderForeground",
        typeof(Brush),
        typeof(PasswordBoxHelper),
        new FrameworkPropertyMetadata());

    [AttachedPropertyBrowsableForType(typeof(TextBox))]
    [AttachedPropertyBrowsableForType(typeof(PasswordBox))]
    public static Brush? GetPlaceholderForeground(DependencyObject obj)
    {
        return (Brush?)obj.GetValue(PlaceholderForegroundProperty);
    }

    [AttachedPropertyBrowsableForType(typeof(TextBox))]
    [AttachedPropertyBrowsableForType(typeof(PasswordBox))]
    public static void SetPlaceholderForeground(DependencyObject obj, Brush? value)
    {
        obj.SetValue(PlaceholderForegroundProperty, value);
    }

    /// <summary>
    /// Background Properties
    /// </summary>
    public static readonly DependencyProperty DefaultBackgroundProperty = DependencyProperty.RegisterAttached(
        "DefaultBackground",
        typeof(Brush),
        typeof(PasswordBoxHelper),
        new FrameworkPropertyMetadata());

    [AttachedPropertyBrowsableForType(typeof(TextBox))]
    [AttachedPropertyBrowsableForType(typeof(PasswordBox))]
    public static Brush? GetDefaultBackground(DependencyObject obj)
    {
        return (Brush?)obj.GetValue(DefaultBackgroundProperty);
    }

    [AttachedPropertyBrowsableForType(typeof(TextBox))]
    [AttachedPropertyBrowsableForType(typeof(PasswordBox))]
    public static void SetDefaultBackground(DependencyObject obj, Brush? value)
    {
        obj.SetValue(DefaultBackgroundProperty, value);
    }

    public static readonly DependencyProperty DisabledBackgroundProperty = DependencyProperty.RegisterAttached(
        "DisabledBackground",
        typeof(Brush),
        typeof(PasswordBoxHelper),
        new FrameworkPropertyMetadata());

    [AttachedPropertyBrowsableForType(typeof(TextBox))]
    [AttachedPropertyBrowsableForType(typeof(PasswordBox))]
    public static Brush? GetDisabledBackground(DependencyObject obj)
    {
        return (Brush?)obj.GetValue(DisabledBackgroundProperty);
    }

    [AttachedPropertyBrowsableForType(typeof(TextBox))]
    [AttachedPropertyBrowsableForType(typeof(PasswordBox))]
    public static void SetDisabledBackground(DependencyObject obj, Brush? value)
    {
        obj.SetValue(DisabledBackgroundProperty, value);
    }

    public static readonly DependencyProperty HoverBackgroundProperty = DependencyProperty.RegisterAttached(
        "HoverBackground",
        typeof(Brush),
        typeof(PasswordBoxHelper),
        new FrameworkPropertyMetadata());

    [AttachedPropertyBrowsableForType(typeof(TextBox))]
    [AttachedPropertyBrowsableForType(typeof(PasswordBox))]
    public static Brush? GetHoverBackground(DependencyObject obj)
    {
        return (Brush?)obj.GetValue(HoverBackgroundProperty);
    }

    [AttachedPropertyBrowsableForType(typeof(TextBox))]
    [AttachedPropertyBrowsableForType(typeof(PasswordBox))]
    public static void SetHoverBackground(DependencyObject obj, Brush? value)
    {
        obj.SetValue(HoverBackgroundProperty, value);
    }

    public static readonly DependencyProperty FocusedBackgroundProperty = DependencyProperty.RegisterAttached(
        "FocusedBackground",
        typeof(Brush),
        typeof(PasswordBoxHelper),
        new FrameworkPropertyMetadata());

    [AttachedPropertyBrowsableForType(typeof(TextBox))]
    [AttachedPropertyBrowsableForType(typeof(PasswordBox))]
    public static Brush? GetFocusedBackground(DependencyObject obj)
    {
        return (Brush?)obj.GetValue(FocusedBackgroundProperty);
    }

    [AttachedPropertyBrowsableForType(typeof(TextBox))]
    [AttachedPropertyBrowsableForType(typeof(PasswordBox))]
    public static void SetFocusedBackground(DependencyObject obj, Brush? value)
    {
        obj.SetValue(FocusedBackgroundProperty, value);
    }
    
    /// <summary>
    /// Foreground Properties
    /// </summary>
    public static readonly DependencyProperty DefaultForegroundProperty = DependencyProperty.RegisterAttached(
        "DefaultForeground",
        typeof(Brush),
        typeof(PasswordBoxHelper),
        new FrameworkPropertyMetadata());

    [AttachedPropertyBrowsableForType(typeof(TextBox))]
    [AttachedPropertyBrowsableForType(typeof(PasswordBox))]
    public static Brush? GetDefaultForeground(DependencyObject obj)
    {
        return (Brush?)obj.GetValue(DefaultForegroundProperty);
    }

    [AttachedPropertyBrowsableForType(typeof(TextBox))]
    [AttachedPropertyBrowsableForType(typeof(PasswordBox))]
    public static void SetDefaultForeground(DependencyObject obj, Brush? value)
    {
        obj.SetValue(DefaultForegroundProperty, value);
    }

    public static readonly DependencyProperty DisabledForegroundProperty = DependencyProperty.RegisterAttached(
        "DisabledForeground",
        typeof(Brush),
        typeof(PasswordBoxHelper),
        new FrameworkPropertyMetadata());

    [AttachedPropertyBrowsableForType(typeof(TextBox))]
    [AttachedPropertyBrowsableForType(typeof(PasswordBox))]
    public static Brush? GetDisabledForeground(DependencyObject obj)
    {
        return (Brush?)obj.GetValue(DisabledForegroundProperty);
    }

    [AttachedPropertyBrowsableForType(typeof(TextBox))]
    [AttachedPropertyBrowsableForType(typeof(PasswordBox))]
    public static void SetDisabledForeground(DependencyObject obj, Brush? value)
    {
        obj.SetValue(DisabledForegroundProperty, value);
    }

    public static readonly DependencyProperty HoverForegroundProperty = DependencyProperty.RegisterAttached(
        "HoverForeground",
        typeof(Brush),
        typeof(PasswordBoxHelper),
        new FrameworkPropertyMetadata());

    [AttachedPropertyBrowsableForType(typeof(TextBox))]
    [AttachedPropertyBrowsableForType(typeof(PasswordBox))]
    public static Brush? GetHoverForeground(DependencyObject obj)
    {
        return (Brush?)obj.GetValue(HoverForegroundProperty);
    }

    [AttachedPropertyBrowsableForType(typeof(TextBox))]
    [AttachedPropertyBrowsableForType(typeof(PasswordBox))]
    public static void SetHoverForeground(DependencyObject obj, Brush? value)
    {
        obj.SetValue(HoverForegroundProperty, value);
    }

    public static readonly DependencyProperty FocusedForegroundProperty = DependencyProperty.RegisterAttached(
        "FocusedForeground",
        typeof(Brush),
        typeof(PasswordBoxHelper),
        new FrameworkPropertyMetadata());

    [AttachedPropertyBrowsableForType(typeof(TextBox))]
    [AttachedPropertyBrowsableForType(typeof(PasswordBox))]
    public static Brush? GetFocusedForeground(DependencyObject obj)
    {
        return (Brush?)obj.GetValue(FocusedForegroundProperty);
    }

    [AttachedPropertyBrowsableForType(typeof(TextBox))]
    [AttachedPropertyBrowsableForType(typeof(PasswordBox))]
    public static void SetFocusedForeground(DependencyObject obj, Brush? value)
    {
        obj.SetValue(FocusedForegroundProperty, value);
    }

    /// <summary>
    /// Border Properties
    /// </summary>
    public static readonly DependencyProperty DefaultBorderBrushProperty = DependencyProperty.RegisterAttached(
        "DefaultBorderBrush",
        typeof(Brush),
        typeof(PasswordBoxHelper),
        new FrameworkPropertyMetadata());

    [AttachedPropertyBrowsableForType(typeof(TextBox))]
    [AttachedPropertyBrowsableForType(typeof(PasswordBox))]
    public static Brush? GetDefaultBorderBrush(DependencyObject obj)
    {
        return (Brush?)obj.GetValue(DefaultBorderBrushProperty);
    }

    [AttachedPropertyBrowsableForType(typeof(TextBox))]
    [AttachedPropertyBrowsableForType(typeof(PasswordBox))]
    public static void SetDefaultBorderBrush(DependencyObject obj, Brush? value)
    {
        obj.SetValue(DefaultBorderBrushProperty, value);
    }

    public static readonly DependencyProperty DisabledBorderBrushProperty = DependencyProperty.RegisterAttached(
        "DisabledBorderBrush",
        typeof(Brush),
        typeof(PasswordBoxHelper),
        new FrameworkPropertyMetadata());

    [AttachedPropertyBrowsableForType(typeof(TextBox))]
    [AttachedPropertyBrowsableForType(typeof(PasswordBox))]
    public static Brush? GetDisabledBorderBrush(DependencyObject obj)
    {
        return (Brush?)obj.GetValue(DisabledBorderBrushProperty);
    }

    [AttachedPropertyBrowsableForType(typeof(TextBox))]
    [AttachedPropertyBrowsableForType(typeof(PasswordBox))]
    public static void SetDisabledBorderBrush(DependencyObject obj, Brush? value)
    {
        obj.SetValue(DisabledBorderBrushProperty, value);
    }

    public static readonly DependencyProperty HoverBorderBrushProperty = DependencyProperty.RegisterAttached(
        "HoverBorderBrush",
        typeof(Brush),
        typeof(PasswordBoxHelper),
        new FrameworkPropertyMetadata());

    [AttachedPropertyBrowsableForType(typeof(TextBox))]
    [AttachedPropertyBrowsableForType(typeof(PasswordBox))]
    public static Brush? GetHoverBorderBrush(DependencyObject obj)
    {
        return (Brush?)obj.GetValue(HoverBorderBrushProperty);
    }

    [AttachedPropertyBrowsableForType(typeof(TextBox))]
    [AttachedPropertyBrowsableForType(typeof(PasswordBox))]
    public static void SetHoverBorderBrush(DependencyObject obj, Brush? value)
    {
        obj.SetValue(HoverBorderBrushProperty, value);
    }

    public static readonly DependencyProperty FocusedBorderBrushProperty = DependencyProperty.RegisterAttached(
        "FocusedBorderBrush",
        typeof(Brush),
        typeof(PasswordBoxHelper),
        new FrameworkPropertyMetadata());

    [AttachedPropertyBrowsableForType(typeof(TextBox))]
    [AttachedPropertyBrowsableForType(typeof(PasswordBox))]
    public static Brush? GetFocusedBorderBrush(DependencyObject obj)
    {
        return (Brush?)obj.GetValue(FocusedBorderBrushProperty);
    }

    [AttachedPropertyBrowsableForType(typeof(TextBox))]
    [AttachedPropertyBrowsableForType(typeof(PasswordBox))]
    public static void SetFocusedBorderBrush(DependencyObject obj, Brush? value)
    {
        obj.SetValue(FocusedBorderBrushProperty, value);
    }
    
    /// <summary>
    /// For Password Event
    /// </sumamry>
    
    [AttachedPropertyBrowsableForType(typeof(PasswordBox))]
    public static bool GetIsMonitoring(DependencyObject obj) {
        return (bool)obj.GetValue(IsMonitoringProperty);
    }

    [AttachedPropertyBrowsableForType(typeof(PasswordBox))]
    public static void SetIsMonitoring(DependencyObject obj, bool value) {
        obj.SetValue(IsMonitoringProperty, value);
    }

    public static readonly DependencyProperty IsMonitoringProperty =
        DependencyProperty.RegisterAttached("IsMonitoring", typeof(bool), typeof(PasswordBoxHelper), new UIPropertyMetadata(false, OnIsMonitoringChanged));

    [AttachedPropertyBrowsableForType(typeof(PasswordBox))]
    public static int GetPasswordLength(DependencyObject obj) {
        return (int)obj.GetValue(PasswordLengthProperty);
    }

    [AttachedPropertyBrowsableForType(typeof(PasswordBox))]
    public static void SetPasswordLength(DependencyObject obj, int value) {
        obj.SetValue(PasswordLengthProperty, value);
    }

    public static readonly DependencyProperty PasswordLengthProperty =
        DependencyProperty.RegisterAttached("PasswordLength", typeof(int), typeof(PasswordBoxHelper), new UIPropertyMetadata(0));

    [AttachedPropertyBrowsableForType(typeof(PasswordBox))]
    public static string GetPassword(DependencyObject obj) {
        return (string)obj.GetValue(PasswordProperty);
    }

    [AttachedPropertyBrowsableForType(typeof(PasswordBox))]
    public static void SetPassword(DependencyObject obj, string? value) {
        obj.SetValue(PasswordProperty, value);
    }

    public static readonly DependencyProperty PasswordProperty =
        DependencyProperty.RegisterAttached("Password", typeof(string), typeof(PasswordBoxHelper), new FrameworkPropertyMetadata(string.Empty, OnPasswordPropertyChanged));

    private static void OnIsMonitoringChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) {
        var pb = d as PasswordBox;
        if (pb == null) {
            return;
        }
        if ((bool) e.NewValue) {
            pb.PasswordChanged += PasswordChanged;
        } else {
            pb.PasswordChanged -= PasswordChanged;
        }
    }
    
    private static void OnPasswordPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        var pb = d as PasswordBox;
        if (pb == null) {
            return;
        }
        if (e.NewValue != e.OldValue) {
            pb.PasswordChanged += PasswordChanged;
        } else {
            pb.PasswordChanged -= PasswordChanged;
        }
    }

    static void PasswordChanged(object sender, RoutedEventArgs e) {
        var passwordBox = sender as PasswordBox;
        if (passwordBox == null) {
            return;
        }
        SetPasswordLength(passwordBox, passwordBox.Password.Length);
        SetPassword(passwordBox, passwordBox.Password);
    }

}