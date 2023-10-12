<h2 align="center">ModernControls.WPF</h2>

<p align="center">
    <a href="https://www.nuget.org/packages/Russkyc.ModernControls.WPF">
        <img src="https://img.shields.io/nuget/v/Russkyc.ModernControls.WPF?color=1f72de" alt="Nuget">
    </a>
    <a href="#">
        <img src="https://img.shields.io/badge/-.NET%206.0-blueviolet?color=1f72de&label=NET" alt="">
    </a>
    <a href="#">
        <img src="https://img.shields.io/badge/-.NET%20Framework%204.6-blueviolet?color=1f72de&label=NET" alt="">
    </a>
</p>

<p align="center">
<a href="https://www.nuget.org/packages/Russkyc.ModernControls.WPF">Russkyc.ModernControls.WPF</a> is an easy to use and highly customizable modern control library for wpf
</p>

### What sets this apart from the default WPF controls?

The default wpf control library is awesome when it comes to ui customization, but theres only one problem --you need to write a handful of style setters, dependency properties, and triggers to have a truly customized control. Which is why **Russkyc.ModernControls.WPF** is created. It saves you from having to write all of the style, templates, and triggers by providing controls that are highly customizable all using properties. Perfect for quick and easy UI Development.

---

<span align="center">
    
![image](https://raw.githubusercontent.com/russkyc/modern-controls-wpf/master/Russkyc.ModernControls.WPF.Demo/Resources/Demo.png)
    
</span>

---
## Setup

Add This Reference to App.xaml
```xaml
xmlns:russkyc="clr-namespace:org.russkyc.moderncontrols.Styles;assembly=Russkyc.ModernControls.WPF"
```

Add the Resource and set default theme in App.xaml

```xaml
    <Application.Resources>
        <!--  ModernControls WPF  -->
        <styles:ModernControlsWpf BaseTheme="Dark" ColorTheme="Green" />
    </Application.Resources>
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
> - [x] ModernWindow - **_New! in 1.5.0_**
> - [x] ModernTextBox - **_Updated! in 1.5.0_**
> - [x] ModernButton
> - [x] ModernToggleButton
> - [x] ModernRadio
> - [x] ModernSwitch - **_New! in 1.5.0_**
> - [x] ModernRadioButton
> - [x] ModernComboBox - **_Updated! in 1.5.0_**

---

## Global Theme Management

<span align="center">

![image](https://raw.githubusercontent.com/russkyc/modern-controls-wpf/master/Russkyc.ModernControls.WPF.Demo/Resources/ThemeManagementDemo.gif)

</span>

### Using the Theme Manager

> **Breaking Changes in 1.5.2**
> - `ThemeManager` is now uses `Instance`
> - There are now 2 Theme resources. `Base Theme` corresponds to the overall base(dark/light) and `ColorTheme` corresponds to the theme colors (blue/red/etc.)
> - Default Base Themes are now located in `pack://application:,,,/Russkyc.ModernControls.WPF;component/Themes/BaseTheme/`
> - Color Themes are in `pack://application:,,,/Russkyc.ModernControls.WPF;component/Themes/ColorThemes/`

Imports
```csharp
using org.russkyc.moderncontrols.Helpers;
```

Adding Base or Color Themes

```csharp
ThemeManager.Instance.AddBaseTheme("Light","pack://application:,,,/Russkyc.ModernControls.WPF;component/Themes/BaseTheme/DefaultLight.xaml");
ThemeManager.Instance.AddColorTheme("Blue","pack://application:,,,/Russkyc.ModernControls.WPF;component/Themes/ColorThemes/Blue.xaml");
```

Changing Base or Color Themes (Live)

```csharp
ThemeManager.Instance.SetBaseTheme(Dark);
ThemeManager.Instance.SetColorTheme(Blue);
```

Get List of Base or Color Themes (names)
```csharp
ThemeManager.Instance.GetBaseThemes();
ThemeManager.Instance.GetColorThemes();
```

Removing Base or Color Themes

```csharp
ThemeManager.Instance.RemoveBaseTheme(Light);
ThemeManager.Instance.RemoveColorTheme(Blue);
```

## Default Color Themes

#### Base Themes:
- Light
- Dark

#### Color Themes:
- Blue
- Gray
- Green
- Lime
- Orange
- Pink
- Purple
- Red
- Teal
- Yellow

---
## Documentation, API References, and More

Head over to the [Wiki](https://github.com/russkyc/modern-controls-wpf/wiki)

---

## Sponsors
Special thanks to [JetBrains](https://www.jetbrains.com/) for supporting this project by providing licences to the JetBrains Suite!

<a href="https://www.jetbrains.com/community/opensource/#support">
<img width="200px" src="https://resources.jetbrains.com/storage/products/company/brand/logos/jb_beam.png" alt="JetBrains Logo (Main) logo.">
</a>