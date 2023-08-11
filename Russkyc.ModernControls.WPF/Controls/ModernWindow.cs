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
using Bindables.Wpf;

namespace org.russkyc.moderncontrols;

public partial class ModernWindow : Window
{
    public static readonly RoutedCommand CloseCommand = new();
    public static readonly RoutedCommand MinimizeCommand = new();
    public static readonly RoutedCommand MaximizeCommand = new();

    public ModernWindow()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(ModernWindow), new FrameworkPropertyMetadata(typeof(ModernWindow)));
        SetResourceReference(StyleProperty, typeof(ModernWindow));
        CommandBindings.Add(new CommandBinding(CloseCommand, Close));
        CommandBindings.Add(new CommandBinding(MaximizeCommand, Maximize));
        CommandBindings.Add(new CommandBinding(MinimizeCommand, Minimize));
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

    // TitleBar Styling
    [DependencyProperty(typeof(bool))] public static readonly DependencyProperty HideDefaultWindowTitleProperty;
    [DependencyProperty(typeof(bool))] public static readonly DependencyProperty NoDecorationsProperty;
    [DependencyProperty(typeof(bool))] public static readonly DependencyProperty ExtendClientAreaToChromeProperty;
    [DependencyProperty(typeof(object))] public static readonly DependencyProperty TitleBarTemplateProperty;
    [DependencyProperty(typeof(double))] public static readonly DependencyProperty TitleBarHeightProperty;

    // Icon Styling
    [DependencyProperty(typeof(double))] public static readonly DependencyProperty IconSizeProperty;
    [DependencyProperty(typeof(double))] public static readonly DependencyProperty IconPaddingProperty;
    [DependencyProperty(typeof(Brush))] public static readonly DependencyProperty IconForegroundProperty;
    
    // Global Theming
    [DependencyProperty(typeof(Brush))] public static readonly DependencyProperty TitleBarButtonDefaultBackgroundProperty;
    [DependencyProperty(typeof(Brush))] public static readonly DependencyProperty TitleBarButtonDisabledBackgroundProperty;
    [DependencyProperty(typeof(Brush))] public static readonly DependencyProperty TitleBarButtonHoverBackgroundProperty;
    [DependencyProperty(typeof(Brush))] public static readonly DependencyProperty TitleBarButtonFocusedBackgroundProperty;
    [DependencyProperty(typeof(Brush))] public static readonly DependencyProperty TitleBarButtonPressedBackgroundProperty;
    [DependencyProperty(typeof(Brush))] public static readonly DependencyProperty TitleBarButtonCheckedBackgroundProperty;
    
    [DependencyProperty(typeof(Brush))] public static readonly DependencyProperty TitleBarButtonDefaultForegroundProperty;
    [DependencyProperty(typeof(Brush))] public static readonly DependencyProperty TitleBarButtonDisabledForegroundProperty;
    [DependencyProperty(typeof(Brush))] public static readonly DependencyProperty TitleBarButtonHoverForegroundProperty;
    [DependencyProperty(typeof(Brush))] public static readonly DependencyProperty TitleBarButtonFocusedForegroundProperty;
    [DependencyProperty(typeof(Brush))] public static readonly DependencyProperty TitleBarButtonPressedForegroundProperty;
    [DependencyProperty(typeof(Brush))] public static readonly DependencyProperty TitleBarButtonCheckedForegroundProperty;
    
    // Titlebar Theming
    [DependencyProperty(typeof(Brush))] public static readonly DependencyProperty TitleBarBackgroundProperty;
    [DependencyProperty(typeof(Brush))] public static readonly DependencyProperty TitleBarForegroundProperty;
    
}