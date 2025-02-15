# WinUI 3 Bug: `ExtendsContentIntoTitleBar` and Child Windows  

This project demonstrates a bug in WinUI 3 where enabling `ExtendsContentIntoTitleBar` in the main window causes child windows to receive incorrect cursor signals.  

## 🐛 Bug Description  

When `ExtendsContentIntoTitleBar = true;` is set in the main window, and main window is minimized, child windows start incorrectly processing cursor events.  

### Reproduction Steps  

1. **Run the app.**  
2. Click **"Show Second Window"** button.  
3. **Minimize the Main Window.**  
4. **Hover over any controls in the Second Window.**  

### Expected Behavior  

- `PointerEntered` should trigger **only once** when the cursor enters a control.  

### Actual Behavior  

- The debug console **continuously logs** `"PointerEntered"` messages while hovering.  
- This can lead to **flickering UI elements**, such as **ToggleSwitch**.  
- If the **Main Window** is **visible** (not minimized) or **completely closed**, everything works as expected.  

## 🔍 Additional Notes  

- The bug is likely tied to how **WinUI 3** manages input events when `ExtendsContentIntoTitleBar` is enabled.  
- A fix or workaround is currently unknown.  

## 🛠 Environment  

- **OS:** Windows 10/11  
- **Framework:** WinUI 3  
- **Reproducible on:** Latest Windows App SDK 1.6.4
