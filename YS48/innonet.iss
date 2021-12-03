; �ű��� Inno Setup �ű��� ���ɣ�
; �йش��� Inno Setup �ű��ļ�����ϸ��������İ����ĵ���

#define MyAppName "Zeus-V3.8(demo)"
#define MyAppVersion "1.0"
#define IncludeFramework true
#define IsExternal ""
#define MyAppPublisher "App"
#define MyAppURL "http://www.MyApp.cn"
#define MyAppExeName "Zeus.exe"

[Setup]
; ע: AppId��ֵΪ������ʶ��Ӧ�ó���
; ��ҪΪ������װ����ʹ����ͬ��AppIdֵ��
; (�����µ�GUID����� ����|��IDE������GUID��)
AppId={{B0C52F2E-939F-4CE2-89F3-2F0677584L48}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\{#MyAppName}
DefaultGroupName={#MyAppName}
OutputDir=E:\step
Compression=lzma
SolidCompression=yes
Uninstallable=yes
UninstallDisplayName=ж��{#MyAppName}


#if IncludeFramework
  OutputBaseFilename={#MyAppName}
#else
  OutputBaseFilename=Setup
#endif

[Languages]
Name: "chinesesimp"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: ;

[Files]
Source: "E:\����\YS48\YS48\IGT.UI.Client4Net20\bin\Release\Zeus.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\����\YS48\YS48\IGT.UI.Client4Net20\bin\Release\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

#if IncludeFramework
Source: "D:\���\Altium Designer 14.1.5.30772\dotNetFx40_Full_x86_x64.exe"; DestDir: "{tmp}"; Flags: ignoreversion {#IsExternal}; Check: NeedsFramework
#endif
; ע��: ��Ҫ���κι���ϵͳ�ļ���ʹ�á�Flags: ignoreversion��

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{group}\ж�� {#MyAppName}"; Filename: "{uninstallexe}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
#if IncludeFramework
Filename: {tmp}\dotNetFx40_Full_x86_x64.exe; Parameters: "/q:a /c:""install /l /q"""; WorkingDir: {tmp}; Flags: skipifdoesntexist; StatusMsg: "Installing .NET Framework if needed"
#endif
Filename: {win}\Microsoft.NET\Framework\v4.0.30319\CasPol.exe; Parameters: "-q -machine -remgroup ""{#MyAppName}"""; WorkingDir: {tmp}; Flags: skipifdoesntexist runhidden; StatusMsg: "Setting Program Access Permissions..."
Filename: {win}\Microsoft.NET\Framework\v4.0.30319\CasPol.exe; Parameters: "-q -machine -addgroup 1.2 -url ""file://{app}/*"" FullTrust -name ""{#MyAppName}"""; WorkingDir: {tmp}; Flags: skipifdoesntexist runhidden; StatusMsg: "Setting Program Access Permissions..."

Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

[UninstallRun]
Filename: {win}\Microsoft.NET\Framework\v4.0.30319\CasPol.exe; Parameters: "-q -machine -remgroup ""{#MyAppName}"""; Flags: skipifdoesntexist runhidden;

[code]
// Indicates whether .NET Framework 2.0 is installed.
function IsDotNET40Detected(): boolean;
var
    success: boolean;
    install: cardinal;
begin
    success := RegQueryDWordValue(HKLM, 'SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full', 'Install', install);
     //success := RegQueryDWordValue(HKLM, 'SOFTWARE\Microsoft\NET Framework Setup\NDP\v2.0.50727', 'Install', install);
    Result :=  success and (install = 1);
end;

//RETURNS OPPOSITE OF IsDotNet20Detected FUNCTION
//Remember this method from the Files section above
function NeedsFramework(): Boolean;
begin
  Result := (IsDotNET40Detected = false);
end;



function GetCustomSetupExitCode(): Integer;
begin
  if (IsDotNET40Detected = false) then
    begin
      MsgBox('.NET Framework δ����ȷ��װ!',mbError, MB_OK);
      result := -1
    end
end;

//ж�س���
function InitializeUninstall(): Boolean;
begin
  Result := MsgBox('ж�س���:' #13#13 '�����Ҫж�ظó���?', mbConfirmation, MB_YESNO) = idYes;
  //if Result = False then
  //  MsgBox('InitializeUninstall:' #13#13 'Ok, bye bye.', mbInformation, MB_OK);
end;


procedure CurUninstallStepChanged(CurUninstallStep: TUninstallStep);
var
  ErrorCode: Integer;
begin
  case CurUninstallStep of
    usUninstall:
      begin
        //MsgBox('ж�س���:' #13#13 '����ж��...', mbInformation, MB_OK)
        // ...insert code to perform pre-uninstall tasks here...
      end;
    usPostUninstall:
      begin
        //MsgBox('ж�س���:' #13#13 'ж�����.', mbInformation, MB_OK);
        // ...insert code to perform post-uninstall tasks here...
    //    ShellExec('open', 'http://www.asiafinance.cn', '', '', SW_SHOW, ewNoWait, ErrorCode)

      end;
  end;
end;