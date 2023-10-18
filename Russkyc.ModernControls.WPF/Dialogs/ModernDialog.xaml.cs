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

namespace org.russkyc.moderncontrols.Dialogs;

public partial class ModernDialog
{
    public MessageBoxButton Buttons { get; set; }
    public string? MessageBoxText { get; set; }
    public string? Caption { get; set; }

    public ModernDialog()
    {
        Buttons = MessageBoxButton.YesNo;
        InitializeComponent();
        BuildButtons();
    }

    public ModernDialog(string messageBoxText, string caption)
    {
        Buttons = MessageBoxButton.YesNo;
        MessageBoxText = messageBoxText;
        Caption = caption;
        InitializeComponent();
        BuildButtons();
    }

    public ModernDialog(string messageBoxText, string caption, MessageBoxButton button)
    {
        MessageBoxText = messageBoxText;
        Caption = caption;
        Buttons = button;
        InitializeComponent();
        BuildButtons();
    }

    private void ButtonYes_OnClick(object sender, RoutedEventArgs e)
    {
        DialogResult = true;
    }

    private void ButtonCancel_OnClick(object sender, RoutedEventArgs e)
    {
        DialogResult = false;
    }

    void BuildButtons()
    {
        ButtonYes.Visibility =
            Buttons == MessageBoxButton.YesNo || Buttons == MessageBoxButton.YesNoCancel
                ? Visibility.Visible
                : Visibility.Collapsed;
        ButtonNo.Visibility =
            Buttons == MessageBoxButton.YesNo || Buttons == MessageBoxButton.YesNoCancel
                ? Visibility.Visible
                : Visibility.Collapsed;
        ButtonOk.Visibility =
            Buttons == MessageBoxButton.OK || Buttons == MessageBoxButton.OKCancel
                ? Visibility.Visible
                : Visibility.Collapsed;
        ButtonCancel.Visibility =
            Buttons == MessageBoxButton.YesNoCancel || Buttons == MessageBoxButton.OKCancel
                ? Visibility.Visible
                : Visibility.Collapsed;

        if (Buttons == MessageBoxButton.YesNo || Buttons == MessageBoxButton.YesNoCancel)
            ButtonYes.Focus();
        if (Buttons == MessageBoxButton.OK || Buttons == MessageBoxButton.OKCancel)
            ButtonOk.Focus();
    }
}