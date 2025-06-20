
# Windows Sleep Assist
## Pre-Release Alpha Version 0.1.3
This is a pre-release alpha version of the Windows Sleep Assist app.  This app may be useful if you are having problems with Windows not going to sleep as expected (as I was). It is now tested on Windows 11 and requires the **.NET Framework 4.8**.

### Changelog from 0.1.2
* Added CPU monitoring
* Windows 11 compatibility

### Compatibility
Windows Sleep Assist uses Windows power management APIs that Microsoft has supported since Windows XP. Functions such as `SetSuspendState`[^setSuspend] and the `powercfg` utility are documented as working on Windows 11. The application now targets **.NET Framework 4.8**, ensuring compatibility with modern Windows versions.

[^setSuspend]: [SetSuspendState function - Microsoft Learn](https://learn.microsoft.com/en-us/windows/win32/api/powrprof/nf-powrprof-setsuspendstate)

### Windows Sleep Assist Dashboard:
![image](https://cloud.githubusercontent.com/assets/1501921/6792193/a3b8f98a-d1ad-11e4-966d-348925b989e7.png)


#### Currently working idle detectors are:
* powercfg -requests
* Network traffic
* User activity (mouse keyboard)
* CPU activity detector

#### Still to be added:
* Hard disk drive activity detector
* User customizable thresholds for idle detection
