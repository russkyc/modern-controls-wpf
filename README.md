## Russkyc.ModernControls.WPF
A highly customizable custom control library for wpf

---

<span align="center">
    
![image](https://raw.githubusercontent.com/russkyc/modern-controls-wpf/master/Russkyc.ModernControls.WPF/Images/Sample.png)
    
</span>

---
### Setup

Add the following to App.xaml > Application.Resources

```xaml
<ResourceDictionary>
    <!--  Modern Controls  -->
    <ResourceDictionary.MergedDictionaries>
        <!--  Order is Important  -->
        <!--  Control Theme  -->
        <ResourceDictionary Source="pack://application:,,,/Russkyc.ModernControls.WPF;component/Themes/ColorThemes/Default.xaml" />
        <!--  Control Resource  -->
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

**Modern Button**
```xaml
<moderncontrols:ModernButton Width="70"
                             CornerRadius="5"
                             FontWeight="SemiBold"
                             HoverBackground="#3d88ff"
                             HoverForeground="#7BFFA3" 
                             PressedBackground="#1F5ABD"
                             PressedForeground="#FFBE46"
                             Text="Modern Button" />
```
---

### Control Library
> - [x] ModernTextBox
> - [x] ModernButton
> - [x] ModernToggleButton
> - [x] ModernRadio
> - [x] ModernRadioButton
> - [x] ModernComboBox
> - [ ] ModernAutocompleteBox

