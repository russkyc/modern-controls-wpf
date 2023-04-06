# Russkyc.ModernControls.WPF
A highly customizable custom control library for wpf

| Version                                                                                                                                                          | Package Name                                                                             |
|------------------------------------------------------------------------------------------------------------------------------------------------------------------|------------------------------------------------------------------------------------------|
| ![Nuget](https://img.shields.io/nuget/v/Russkyc.ModernControls.WPF?color=1f72de) ![](https://img.shields.io/badge/-.NET%206.0-blueviolet?color=1f72de&label=NET) | [Russkyc.ModernControls.WPF](https://www.nuget.org/packages/Russkyc.ModernControls.WPF/) |


### What sets this apart from the default WPF controls?

The default wpf control library is awesome when it comes to ui customization, but theres only one problem --you need to write a handful of style setters, dependency properties, and triggers to have a truly customized control. Which is why **Russkyc.ModernControls.WPF** is created. It saves you from having to write all of the style, templates, and triggers by providing controls that are highly customizable all using properties. Perfect for quick and easy UI Development.

---

<span align="center">
    
![image](https://raw.githubusercontent.com/russkyc/modern-controls-wpf/master/Russkyc.ModernControls.WPF.Demo/Resources/Demo.png)
    
</span>

---
## Setup

Add the following to App.xaml. **Order is Important!**

```xaml
<ResourceDictionary>
    <ResourceDictionary.MergedDictionaries>
        <ResourceDictionary Source="pack://application:,,,/Russkyc.ModernControls.WPF;component/Themes/ColorThemes/DefaultLight.xaml" />
        <ResourceDictionary Source="pack://application:,,,/Russkyc.ModernControls.WPF;component/Themes/Generic.xaml" />
    </ResourceDictionary.MergedDictionaries>
</ResourceDictionary>
```

Add the following to your window
```xaml
xmlns:russkyc="clr-namespace:org.russkyc.moderncontrols;assembly=Russkyc.ModernControls.WPF"
```

Sample Usage
```xaml
<russkyc:ModernButton Width="70" Text="Modern Button" />
```

---

### A Taste of ModernControls Customization

```xaml
<russkyc:ModernButton Width="70"
                             CornerRadius="5"
                             FontWeight="SemiBold"
                             HoverBackground="#3d88ff"
                             HoverForeground="#7BFFA3" 
                             PressedBackground="#1F5ABD"
                             PressedForeground="#FFBE46"
                             Text="Modern Button" />
```

---

## Control Library
> - [x] ModernTextBox
> - [x] ModernButton
> - [x] ModernToggleButton
> - [x] ModernRadio
> - [x] ModernRadioButton
> - [x] ModernComboBox
> - [ ] ModernAutocompleteBox

---

## Global Theme Management

<span align="center">

![image](https://raw.githubusercontent.com/russkyc/modern-controls-wpf/master/Russkyc.ModernControls.WPF.Demo/Resources/ThemeManagementDemo.gif)

</span>

### Using the new Theme Helper

Imports
```csharp
using org.russkyc.moderncontrols.Helpers;
```

Adding Themes

```csharp
ThemeHelper.AddTheme("Light","pack://application:,,,/Russkyc.ModernControls.WPF;component/Themes/ColorThemes/DefaultLight.xaml");
ThemeHelper.AddTheme("Dark","pack://application:,,,/Russkyc.ModernControls.WPF;component/Themes/ColorThemes/RazerDark.xaml");
```

Changing Themes (Live)

```csharp
ThemeHelper.SetGlobalTheme("Dark");
```

Get List of Themes (names)
```csharp
ThemeHelper.GetThemes();
```

Removing Themes

```csharp
ThemeHelper.RemoveTheme("Light");
```

## Want to create your own Theme?

Use This Template

```xaml
<!--  ModernControls Default Light Theme  -->
<ResourceDictionary xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation" xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml">

    <!--  Background  -->
    <SolidColorBrush x:Key="bg-000" Color="#f8fdff" />
    <SolidColorBrush x:Key="bg-100" Color="#EEF3F5" />
    <SolidColorBrush x:Key="bg-200" Color="#E1E6E8" />
    <SolidColorBrush x:Key="bg-300" Color="#D7DCDE" />
    <SolidColorBrush x:Key="bg-400" Color="#D3D8DA" />
    <SolidColorBrush x:Key="bg-500" Color="#CFD4D6" />
    <SolidColorBrush x:Key="bg-600" Color="#BFC4C5" />

    <!--  Foreground  -->
    <SolidColorBrush x:Key="fg-000" Color="#0c0e17" />
    <SolidColorBrush x:Key="fg-100" Color="#161820" />
    <SolidColorBrush x:Key="fg-200" Color="#1f222a" />
    <SolidColorBrush x:Key="fg-300" Color="#292b33" />
    <SolidColorBrush x:Key="fg-400" Color="#33353c" />
    <SolidColorBrush x:Key="fg-500" Color="#3c3f46" />
    <SolidColorBrush x:Key="fg-600" Color="#46494f" />

    <!--  Primary  -->
    <SolidColorBrush x:Key="primary-lighten-3" Color="#3d9be6" />
    <SolidColorBrush x:Key="primary-lighten-2" Color="#2989e1" />
    <SolidColorBrush x:Key="primary-lighten-1" Color="#1576db" />
    <SolidColorBrush x:Key="primary-default" Color="#0462d4" />
    <SolidColorBrush x:Key="primary-darken-1" Color="#0152c6" />
    <SolidColorBrush x:Key="primary-darken-2" Color="#0043b8" />
    <SolidColorBrush x:Key="primary-darken-3" Color="#0035a9" />

    <!--  Inverted  -->
    <SolidColorBrush x:Key="inverted-lighten-3" Color="#f2f9ff" />
    <SolidColorBrush x:Key="inverted-lighten-2" Color="#ebf4ff" />
    <SolidColorBrush x:Key="inverted-lighten-1" Color="#e3f0ff" />
    <SolidColorBrush x:Key="inverted-default" Color="#dceaff" />
    <SolidColorBrush x:Key="inverted-darken-1" Color="#d3e1f6" />
    <SolidColorBrush x:Key="inverted-darken-2" Color="#cad9ec" />
    <SolidColorBrush x:Key="inverted-darken-3" Color="#c1d0e3" />

</ResourceDictionary>
```

#### Add your theme to the ThemeHelper

```csharp
ThemeHelper.AddTheme("MyTheme","path_to_your_theme/MyThemeName.xaml");
```

#### And Apply

```csharp
ThemeHelper.SetGlobalTheme("MyTheme");
```

---

## API Reference
> This contains all the custom control properties present in each control, their values, and their sample use case. this is the compact version of the API documentation and will be moved to its respective documentation page in the future.

### ModernButton

| Custom Property     | Value         | Sample Usage                                                       |
|---------------------|---------------|--------------------------------------------------------------------|
| CornerRadius        | CornerRadius  | `<russkyc:ModernButton CornerRadius="10"/>`                        |
| LeftIcon            | object        | `<russkyc:ModernButton LeftIcon="{StaticResource Icon}"/>`         |
| RightIcon           | object        | `<russkyc:ModernButton RightIcon="{StaticResource Icon}"/>`        |
| LeftCenterIcon      | object        | `<russkyc:ModernButton LeftCenterIcon="{StaticResource Icon}"/>`   |
| RightCenterIcon     | object        | `<russkyc:ModernButton RightCenterIcon="{StaticResource Icon}"/>`  |
| IconSize            | double        | `<russkyc:ModernButton IconSize="20"/>`                            |
| IconForeground      | Brush         | `<russkyc:ModernButton IconForeground="Green"/>`                   |
| IconPadding         | Thickness     | `<russkyc:ModernButton IconPadding="5"/>`                          |
| DefaultBackground   | Brush         | `<russkyc:ModernButton DefaultBackground="LightGray"/>`            |
| DisabledBackground  | Brush         | `<russkyc:ModernButton DisabledBackground="Gray"/>`                |
| HoverBackground     | Brush         | `<russkyc:ModernButton HoverBackground="DarkGray"/>`               |
| PressedBackground   | Brush         | `<russkyc:ModernButton PressedBackground="Black"/>`                |
| DefaultForeground   | Brush         | `<russkyc:ModernButton DefaultForeground="White"/>`                |
| DisabledForeground  | Brush         | `<russkyc:ModernButton DisabledForeground="LightGray"/>`           |
| HoverForeground     | Brush         | `<russkyc:ModernButton HoverForeground="Green"/>`                  |
| PressedForeground   | Brush         | `<russkyc:ModernButton PressedForeground="Red"/>`                  |
| DefaultBorderBrush  | Brush         | `<russkyc:ModernButton DefaultBorderBrush="Black"/>`               |
| DisabledBorderBrush | Brush         | `<russkyc:ModernButton DisabledBorderBrush="Gray"/>`               |
| HoverBorderBrush    | Brush         | `<russkyc:ModernButton HoverBorderBrush="DarkGray"/>`              |
| PressedBorderBrush  | Brush         | `<russkyc:ModernButton PressedBorderBrush="Black"/>`               |

### ModernTextBox

| Custom Property               | Value        | Sample Usage                                                          |
|-------------------------------|--------------|-----------------------------------------------------------------------|
| Placeholder                   | string       | `<russkyc:ModernTextBox Placeholder="Enter your name" />`             |
| CornerRadius                  | CornerRadius | `<russkyc:ModernTextBox CornerRadius="5" />`                          |
| LeftIcon                      | object       | `<russkyc:ModernTextBox LeftIcon="{StaticResource Icon}" />`          |
| RightIcon                     | object       | `<russkyc:ModernTextBox RightIcon="{StaticResource Icon}" />`         |
| IconSize                      | double       | `<russkyc:ModernTextBox IconSize="20" />`                             |
| IconForeground                | Brush        | `<russkyc:ModernTextBox IconForeground="Red" />`                      |
| Prefix                        | string       | `<russkyc:ModernTextBox Prefix="$" />`                                |
| Suffix                        | string       | `<russkyc:ModernTextBox Suffix="USD" />`                              |
| IconPadding                   | Thickness    | `<russkyc:ModernTextBox IconPadding="5" />`                           |
| DefaultBackground             | Brush        | `<russkyc:ModernTextBox DefaultBackground="White" />`                 |
| DisabledBackground            | Brush        | `<russkyc:ModernTextBox DisabledBackground="Gray" />`                 |
| HoverBackground               | Brush        | `<russkyc:ModernTextBox HoverBackground="LightGray" />`               |
| PressedBackground             | Brush        | `<russkyc:ModernTextBox PressedBackground="DarkGray" />`              |
| DefaultForeground             | Brush        | `<russkyc:ModernTextBox DefaultForeground="Black" />`                 |
| DisabledForeground            | Brush        | `<russkyc:ModernTextBox DisabledForeground="LightGray" />`            |
| HoverForeground               | Brush        | `<russkyc:ModernTextBox HoverForeground="Red" />`                     |
| PressedForeground             | Brush        | `<russkyc:ModernTextBox PressedForeground="Blue" />`                  |
| DefaultPlaceholderForeground  | Brush        | `<russkyc:ModernTextBox DefaultPlaceholderForeground="Gray" />`       |
| DisabledPlaceholderForeground | Brush        | `<russkyc:ModernTextBox DisabledPlaceholderForeground="LightGray" />` |
| HoverPlaceholderForeground    | Brush        | `<russkyc:ModernTextBox HoverPlaceholderForeground="DarkGray" />`     |
| PressedPlaceholderForeground  | Brush        | `<russkyc:ModernTextBox PressedPlaceholderForeground="Black" />`      |
| DefaultBorderBrush            | Brush        | `<russkyc:ModernTextBox DefaultBorderBrush="Gray" />`                 |
| DisabledBorderBrush           | Brush        | `<russkyc:ModernTextBox DisabledBorderBrush="LightGray" />`           |
| HoverBorderBrush              | Brush        | `<russkyc:ModernTextBox HoverBorderBrush="DarkGray" />`               |
| PressedBorderBrush            | Brush        | `<russkyc:ModernTextBox PressedBorderBrush="Black" />`                |


### ModernComboBox

| Custom Property       | Value         | Sample Usage                                                 |
|-----------------------|---------------|--------------------------------------------------------------|
| Icon                  | object        | `<russkyc:ModernComboBox Icon="{StaticResource MyIcon}" />`  |
| IconSize              | double        | `<russkyc:ModernComboBox IconSize="16" />`                   |
| IconPadding           | Thickness     | `<russkyc:ModernComboBox IconPadding="4" />`                 |
| PlaceholderForeground | Brush         | `<russkyc:ModernComboBox PlaceholderForeground="Gray" />`    |
| Placeholder           | string        | `<russkyc:ModernComboBox Placeholder="Select an item" />`    |
| CornerRadius          | CornerRadius  | `<russkyc:ModernComboBox CornerRadius="2" />`                |
| ItemCornerRadius      | CornerRadius  | `<russkyc:ModernComboBox ItemCornerRadius="2" />`            |
| DefaultBackground     | Brush         | `<russkyc:ModernComboBox DefaultBackground="White" />`       |
| DisabledBackground    | Brush         | `<russkyc:ModernComboBox DisabledBackground="LightGray" />`  |
| HoverBackground       | Brush         | `<russkyc:ModernComboBox HoverBackground="LightBlue" />`     |
| PressedBackground     | Brush         | `<russkyc:ModernComboBox PressedBackground="Blue" />`        |
| CheckedBackground     | Brush         | `<russkyc:ModernComboBox CheckedBackground="Green" />`       |
| ItemBackground        | Brush         | `<russkyc:ModernComboBox ItemBackground="White" />`          |
| HoverItemBackground   | Brush         | `<russkyc:ModernComboBox HoverItemBackground="LightBlue" />` |
| CheckedItemBackground | Brush         | `<russkyc:ModernComboBox CheckedItemBackground="Green" />`   |
| ItemForeground        | Brush         | `<russkyc:ModernComboBox ItemForeground="Black" />`          |
| HoverItemForeground   | Brush         | `<russkyc:ModernComboBox HoverItemForeground="White" />`     |
| CheckedItemForeground | Brush         | `<russkyc:ModernComboBox CheckedItemForeground="White" />`   |
| DropdownBackground    | Brush         | `<russkyc:ModernComboBox DropdownBackground="White" />`      |
| DropdownBorderBrush   | Brush         | `<russkyc:ModernComboBox DropdownBorderBrush="Gray" />`      |

### ModernRadio

| Custom Property   | Value        | Sample Usage                                         |
|-------------------|--------------|------------------------------------------------------|
| CornerRadius      | CornerRadius | `<russkyc:ModernRadio CornerRadius="5"/>`            |
| HoverForeground   | Brush        | `<russkyc:ModernRadio HoverForeground="Red"/>`       |
| HoverBackground   | Brush        | `<russkyc:ModernRadio HoverBackground="Green"/>`     |
| PressedForeground | Brush        | `<russkyc:ModernRadio PressedForeground="Yellow"/>`  |
| PressedBackground | Brush        | `<russkyc:ModernRadio PressedBackground="Blue"/>`    |
| CheckedForeground | Brush        | `<russkyc:ModernRadio CheckedForeground="Orange"/>`  |
| CheckedBackground | Brush        | `<russkyc:ModernRadio CheckedBackground="Purple"/>`  |

### ModernRadioButton

| Custom Property     | Value         | Sample Usage                                                                     |
|---------------------|---------------|----------------------------------------------------------------------------------|
| CornerRadius        | CornerRadius  | `<russkyc:ModernRadioButton CornerRadius="5"/>`                                  |
| LeftIcon            | object        | `<russkyc:ModernRadioButton LeftIcon="{StaticResource SomeIcon}"/>`              |
| RightIcon           | object        | `<russkyc:ModernRadioButton RightIcon="{StaticResource SomeIcon}"/>`             |
| LeftCenterIcon      | object        | `<russkyc:ModernRadioButton LeftCenterIcon="{StaticResource SomeIcon}"/>`        |
| RightCenterIcon     | object        | `<russkyc:ModernRadioButton RightCenterIcon="{StaticResource SomeIcon}"/>`       |
| IconSize            | double        | `<russkyc:ModernRadioButton IconSize="16"/>`                                     |
| IconForeground      | Brush         | `<russkyc:ModernRadioButton IconForeground="Red"/>`                              |
| IconPadding         | Thickness     | `<russkyc:ModernRadioButton IconPadding="5"/>`                                   |
| DefaultBackground   | Brush         | `<russkyc:ModernRadioButton DefaultBackground="Gray"/>`                          |
| DisabledBackground  | Brush         | `<russkyc:ModernRadioButton IsEnabled="False" DisabledBackground="LightGray"/>`  |
| HoverBackground     | Brush         | `<russkyc:ModernRadioButton Background="White" HoverBackground="LightGray"/>`    |
| PressedBackground   | Brush         | `<russkyc:ModernRadioButton Background="White" PressedBackground="Gray"/>`       |
| CheckedBackground   | Brush         | `<russkyc:ModernRadioButton IsChecked="True" CheckedBackground="Green"/>`        |
| DefaultForeground   | Brush         | `<russkyc:ModernRadioButton DefaultForeground="Black"/>`                         |
| DisabledForeground  | Brush         | `<russkyc:ModernRadioButton IsEnabled="False" DisabledForeground="DarkGray"/>`   |
| HoverForeground     | Brush         | `<russkyc:ModernRadioButton Foreground="Black" HoverForeground="Blue"/>`         |
| PressedForeground   | Brush         | `<russkyc:ModernRadioButton Foreground="Black" PressedForeground="Red"/>`        |
| CheckedForeground   | Brush         | `<russkyc:ModernRadioButton IsChecked="True" CheckedForeground="White"/>`        |
| DefaultBorderBrush  | Brush         | `<russkyc:ModernRadioButton DefaultBorderBrush="Black"/>`                        |
| DisabledBorderBrush | Brush         | `<russkyc:ModernRadioButton IsEnabled="False" DisabledBorderBrush="Gray"/>`      |
| HoverBorderBrush    | Brush         | `<russkyc:ModernRadioButton BorderBrush="Black" HoverBorderBrush="Blue"/>`       |
| PressedBorderBrush  | Brush         | `<russkyc:ModernRadioButton BorderBrush="Black" PressedBorderBrush="Red"/>`      |
| CheckedBorderBrush  | Brush         | `<russkyc:ModernRadioButton IsChecked="True" CheckedBorderBrush="Green"/>`       |

### ModernToggleButton

| Custom Property     | Value        | Sample Usage                                                              |
|---------------------|--------------|---------------------------------------------------------------------------|
| CornerRadius        | CornerRadius | `<russkyc:ModernToggleButton CornerRadius="5"/>`                          |
| LeftIcon            | object       | `<russkyc:ModernToggleButton LeftIcon="{StaticResource MyIcon}"/>`        |
| RightIcon           | object       | `<russkyc:ModernToggleButton RightIcon="{StaticResource MyIcon}"/>`       |
| LeftCenterIcon      | object       | `<russkyc:ModernToggleButton LeftCenterIcon="{StaticResource MyIcon}"/>`  |
| RightCenterIcon     | object       | `<russkyc:ModernToggleButton RightCenterIcon="{StaticResource MyIcon}"/>` |
| IconSize            | double       | `<russkyc:ModernToggleButton IconSize="16"/>`                             |
| IconForeground      | Brush        | `<russkyc:ModernToggleButton IconForeground="Black"/>`                    |
| IconPadding         | Thickness    | `<russkyc:ModernToggleButton IconPadding="4"/>`                           |
| DefaultBackground   | Brush        | `<russkyc:ModernToggleButton DefaultBackground="White"/>`                 |
| DisabledBackground  | Brush        | `<russkyc:ModernToggleButton DisabledBackground="Gray"/>`                 |
| HoverBackground     | Brush        | `<russkyc:ModernToggleButton HoverBackground="LightGray"/>`               |
| PressedBackground   | Brush        | `<russkyc:ModernToggleButton PressedBackground="DarkGray"/>`              |
| CheckedBackground   | Brush        | `<russkyc:ModernToggleButton CheckedBackground="Yellow"/>`                |
| DefaultForeground   | Brush        | `<russkyc:ModernToggleButton DefaultForeground="Black"/>`                 |
| DisabledForeground  | Brush        | `<russkyc:ModernToggleButton DisabledForeground="DarkGray"/>`             |
| HoverForeground     | Brush        | `<russkyc:ModernToggleButton HoverForeground="Blue"/>`                    |
| PressedForeground   | Brush        | `<russkyc:ModernToggleButton PressedForeground="White"/>`                 |
| CheckedForeground   | Brush        | `<russkyc:ModernToggleButton CheckedForeground="Red"/>`                   |
| DefaultBorderBrush  | Brush        | `<russkyc:ModernToggleButton DefaultBorderBrush="Black"/>`                |
| DisabledBorderBrush | Brush        | `<russkyc:ModernToggleButton DisabledBorderBrush="DarkGray"/>`            |
| HoverBorderBrush    | Brush        | `<russkyc:ModernToggleButton HoverBorderBrush="Blue"/>`                   |
| PressedBorderBrush  | Brush        | `<russkyc:ModernToggleButton PressedBorderBrush="White"/>`                |
| CheckedBorderBrush  | Brush        | `<russkyc:ModernToggleButton CheckedBorderBrush="Red"/>`                  |

---

## Background/Foreground is not updating on click/hover, what to do?

#### DO:
> Set the `DefaultBackground` or `DefaultForeground` property instead of the _Background_ and _Foreground_ property to change the default state color.

#### DO NOT:
> Set the `Background` and `Foreground` property directly.

#### WHY?
> WPF has very strict style precedence rules, setting the Background and Foreground property on the controls directly will break the hover / click / check / pressed color functionality since it will supersede all colors set by the control and make the properties unmodifiable to the control template.
