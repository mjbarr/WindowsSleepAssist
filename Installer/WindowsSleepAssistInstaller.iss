; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{BD39E7F4-5E26-43FE-8CAC-A5C022556140}
AppName=Windows Sleep Assist
AppVersion=0.1.2
;AppVerName=Windows Sleep Assist 0.1.1
AppPublisherURL=https://github.com/mjbarr/WindowsSleepAssist
AppSupportURL=https://github.com/mjbarr/WindowsSleepAssist
AppUpdatesURL=https://github.com/mjbarr/WindowsSleepAssist
AppPublisher=M Barr
DefaultDirName={pf}\Windows Sleep Assist
DefaultGroupName=Windows Sleep Assist
OutputBaseFilename=WindowsSleepAssist_Setup
Compression=lzma
SolidCompression=yes
PrivilegesRequired=admin

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "..\WindowsSleepAssist\bin\Release\WindowsSleepAssist.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\WindowsSleepAssist\bin\Release\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "..\WindowsSleepAssistService\bin\Release\*"; DestDir: "{app}\Service"; Flags: ignoreversion recursesubdirs createallsubdirs
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\Windows Sleep Assist"; Filename: "{app}\WindowsSleepAssist.exe"
Name: "{commonstartup}\Windows Sleep Assist"; Filename: "{app}\WindowsSleepAssist.exe"
Name: "{group}\{cm:UninstallProgram,Windows Sleep Assist}"; Filename: "{uninstallexe}"
Name: "{commondesktop}\Windows Sleep Assist"; Filename: "{app}\WindowsSleepAssist.exe"; Tasks: desktopicon

[Run]
Filename: "{app}\WindowsSleepAssist.exe"; Description: "{cm:LaunchProgram,Windows Sleep Assist}"; Flags: nowait postinstall skipifsilent
Filename: "{app}\Service\WindowsSleepAssistService.exe"; Parameters: " --install"; Flags: shellexec; StatusMsg: "Installing Windows Sleep Assist service component.."



