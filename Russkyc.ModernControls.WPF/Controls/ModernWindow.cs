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
using System.Windows.Input;
using System.Windows.Media;

namespace org.russkyc.moderncontrols;

public class ModernWindow : Window
{
    public static readonly RoutedCommand CloseCommand = new RoutedCommand();
    public static readonly RoutedCommand MinimizeCommand = new RoutedCommand();
    public static readonly RoutedCommand MaximizeCommand = new RoutedCommand();

    public ModernWindow()
    {
        SetResourceReference(StyleProperty, typeof(ModernWindow));
        CommandBindings.Add(new CommandBinding(CloseCommand, Close));
        CommandBindings.Add(new CommandBinding(MaximizeCommand, Maximize));
        CommandBindings.Add(new CommandBinding(MinimizeCommand, Minimize));
    }

    static ModernWindow()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(ModernWindow), new FrameworkPropertyMetadata(typeof(ModernWindow)));
    }

    private void Close(object sender, ExecutedRoutedEventArgs e)
    {
        Close();
    }
    
    private void Minimize(object sender, ExecutedRoutedEventArgs e)
    {
        WindowState = WindowState.Minimized;
    }
    
    private void Maximize(object sender, ExecutedRoutedEventArgs e)
    {
        if (WindowState == WindowState.Normal)
        {
            WindowState = WindowState.Maximized;
        } else if (WindowState == WindowState.Maximized)
        {
            WindowState = WindowState.Normal;
        }
    }

    public static readonly DependencyProperty HideDefaultWindowTitleProperty = DependencyProperty.Register(
        nameof(HideDefaultWindowTitle), typeof(bool), typeof(ModernWindow), new FrameworkPropertyMetadata());

    public bool HideDefaultWindowTitle
    {
        get { return (bool)GetValue(HideDefaultWindowTitleProperty); }
        set { SetValue(HideDefaultWindowTitleProperty, value); }
    }

    public static readonly DependencyProperty TitleBarTemplateProperty = DependencyProperty.Register(
        nameof(TitleBarTemplate), typeof(object), typeof(ModernWindow), new PropertyMetadata(default(object)));

    public object TitleBarTemplate
    {
        get => GetValue(TitleBarTemplateProperty);
        set => SetValue(TitleBarTemplateProperty, value);
    }

    public static readonly DependencyProperty TitleBarHeightProperty = DependencyProperty.Register(
        nameof(TitleBarHeight), typeof(double), typeof(ModernWindow), new FrameworkPropertyMetadata());
    public double TitleBarHeight
    {
        get => (double)GetValue(TitleBarHeightProperty);
        set => SetValue(TitleBarHeightProperty, value);
    }

    public static readonly DependencyProperty TitleBarBackgroundProperty = DependencyProperty.Register(
        nameof(TitleBarBackground), typeof(Brush), typeof(ModernWindow), new FrameworkPropertyMetadata());

    public Brush TitleBarBackground
    {
        get => (Brush)GetValue(TitleBarBackgroundProperty);
        set => SetValue(TitleBarBackgroundProperty, value);
    }
    
    public static readonly DependencyProperty TitleBarForegroundProperty = DependencyProperty.Register(
        nameof(TitleBarForeground), typeof(Brush), typeof(ModernWindow), new FrameworkPropertyMetadata());

    public Brush TitleBarForeground
    {
        get => (Brush)GetValue(TitleBarForegroundProperty);
        set => SetValue(TitleBarForegroundProperty, value);
    }
    
    public static readonly DependencyProperty IconSizeProperty = DependencyProperty.Register(
        nameof(IconSize),
        typeof(double),
        typeof(ModernWindow),
        new FrameworkPropertyMetadata());
    public double IconSize
    {
        get => (double)GetValue(IconSizeProperty);
        set => SetValue(IconSizeProperty, value);
    }
    
    public static readonly DependencyProperty IconPaddingProperty = DependencyProperty.Register(
        nameof(IconPadding),
        typeof(Thickness),
        typeof(ModernWindow),
        new FrameworkPropertyMetadata());
    public Thickness IconPadding
    {
        get => (Thickness)GetValue(IconPaddingProperty);
        set => SetValue(IconPaddingProperty, value);
    }

}