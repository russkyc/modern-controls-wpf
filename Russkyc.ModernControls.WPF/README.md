# ModernControls.WPF

![](https://img.shields.io/nuget/v/Russkyc.ModernControls.WPF?color=1f72de)
![](https://img.shields.io/badge/-.NET%206.0-blueviolet?color=1f72de&label=NET)
![](https://img.shields.io/badge/-.NET%20Framework%204.6-blueviolet?color=1f72de&label=NET)

An easy to use and highly customizable modern control library for wpf

### What sets this apart from the default WPF controls?

The default wpf control library is awesome when it comes to ui customization, but theres only one problem --you need to write a handful of style setters, dependency properties, and triggers to have a truly customized control. Which is why **Russkyc.ModernControls.WPF** is created. It saves you from having to write all of the style, templates, and triggers by providing controls that are highly customizable all using properties. Perfect for quick and easy UI Development.

---

![image](https://raw.githubusercontent.com/russkyc/modern-controls-wpf/master/Russkyc.ModernControls.WPF.Demo/Resources/Demo.png)

---
### Getting Strated

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

### [Visit the ModernControls.WPF Repository](https://github.com/russkyc/modern-controls-wpf)

Head over to the [Wiki](https://github.com/russkyc/modern-controls-wpf/wiki)
