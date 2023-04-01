using System;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using Bindables.Wpf;

namespace org.russkyc.moderncontrols;

public partial class ModernButton : ButtonBase
{
    [DependencyProperty(typeof(CornerRadius))]
    public static readonly DependencyProperty CornerRadiusProperty;
    [DependencyProperty(typeof(Thickness))]
    public static readonly DependencyProperty PaddingProperty;
    [DependencyProperty(typeof(HorizontalAlignment))]
    public static readonly DependencyProperty HorizontalContentAlignmentProperty;
    [DependencyProperty(typeof(Brush))]
    public static readonly DependencyProperty HoverForegroundProperty;
    [DependencyProperty(typeof(Brush))]
    public static readonly DependencyProperty HoverBackgroundProperty;
    [DependencyProperty(typeof(Brush))]
    public static readonly DependencyProperty PressedForegroundProperty;
    [DependencyProperty(typeof(Brush))]
    public static readonly DependencyProperty PressedBackgroundProperty;
        
}