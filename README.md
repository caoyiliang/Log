# Log
日志存储
## 第一步
### 一般情况，可加参数表示指定文件名
```
Logs.LogFactory = new NLogFactory();
```
### Android下自动读取Assets下的配置
```
Logs.LogFactory = new NLogFactory("assets/NLog.config");
```
## 第二步
### Android下的配置文件，其他的无非给下路径，Android下路径不熟，给个例子，详见文章尾部摘抄
```
<?xml version="1.0" encoding="utf-8" ?>
<nlog xmlns="http://www.nlog-project.org/schemas/NLog.xsd"
      xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
      xsi:schemaLocation="http://www.nlog-project.org/schemas/NLog.xsd NLog.xsd"
      autoReload="true"
      throwExceptions="false"
      internalLogLevel="Off" internalLogFile="c:\temp\nlog-internal.log">
	<variable name="myvar" value="myvalue"/>
	<variable name="logDir" value="${specialfolder:folder=MyDocuments}/Logs/"/>
	<targets async="true">
		<target xsi:type="File" name="error" fileName="${logDir}/Error/${shortdate}.log" layout="${level:upperCase=true} ${longdate}  ${logger} ${callsite:skipFrames=2} ${message} ${onexception:${newline} ${exception:format=toString,Data} ${newline} ${stacktrace} ${newline}"/>
		<target xsi:type="File" name="info" fileName="${logDir}/Info/${shortdate}.log" layout="${level:upperCase=true} ${longdate}  ${logger} ${callsite:skipFrames=2} ${message}"/>
		<target xsi:type="File" name="warn" fileName="${logDir}/Warn/${shortdate}.log" layout=" ${level:upperCase=true} ${longdate}  ${logger} ${callsite:skipFrames=2} ${message} ${onexception:${newline} ${exception:format=toString,Data} ${newline} ${stacktrace} ${newline}"/>
		<target xsi:type="File" name="trace" fileName="${logDir}/Trace/${shortdate}.log" layout=" ${longdate} ${message}"/>
		<target xsi:type="File" name="debug" fileName="${logDir}/Debug/${shortdate}.log" layout=" ${longdate} ${message}"/>
	</targets>
	<rules>
		<logger name="*" minlevel="Error" maxlevel="Error" writeTo="error"/>
		<logger name="*" minlevel="Info" maxlevel="Info" writeTo="info"/>
		<logger name="*" minlevel="Warn" maxlevel="Warn" writeTo="warn"/>
		<logger name="*" minlevel="Trace" maxlevel="Trace" writeTo="trace"/>
		<logger name="*" minlevel="Debug" maxlevel="Debug" writeTo="debug"/>
	</rules>
</nlog>
```
## 第三步
### 在使用到的类中加入
```
//Main是你需要调用的类
private static readonly ILogger _logger = Logs.LogFactory.GetLogger<Main>();
```
## 第四步
### 可在需要位置输出日志,比如：
```
_logger.Info("hello");
_logger.Error(e.Exception);
```






## *附NLog文件路径规则
System special folder path (includes My Documents, My Music, Program Files, Desktop, and more). 

> Platforms Supported: **Limited** (Not supported on NetStandard1.3+1.5)

> See also [${processdir}](https://github.com/NLog/NLog/wiki/ProcessDir-Layout-Renderer) , [${basedir}](https://github.com/NLog/NLog/wiki/Basedir-Layout-Renderer) , [${currentdir}](https://github.com/NLog/NLog/wiki/CurrentDir-Layout-Renderer) , [${tempdir}](https://github.com/NLog/NLog/wiki/TempDir-Layout-Renderer)

## Configuration Syntax
```
${specialfolder:dir=String:file=String:folder=Enum}
```

## Parameters

### Advanced Options
* **dir** - Name of the directory to be Path.Combine()'d with the directory name.
* **file** - Name of the file to be Path.Combine()'d with the directory name.

### Rendering Options
* **folder** - System special folder to use. Full list of options is available at [MSDN](https://msdn.microsoft.com/en-us/library/system.environment.specialfolder(v=vs.110).aspx). The most common ones are:

  * **ApplicationData** - Roaming application data for current user
    * Windows Path = `C:\Users\%USERNAME%\AppData\Roaming`
    * Xamarin Mono = `$HOME/.config` (or $XDG_CONFIG_HOME if set)
    * Xamarin iOS = `/data/Containers/Data/Application/@GENERATED_NAME@/Documents/.config`
    * Xamarin Android = `/data/data/@PACKAGE_NAME@/files/.config`
  * **LocalApplicationData** - Non roaming application data for current user
    * Windows Path = `C:\Users\%USERNAME%\AppData\Local`
    * Xamarin Mono = `$HOME/.local/share` (or $XDG_DATA_HOME if set)
    * Xamarin iOS = `/data/Containers/Data/Application/@GENERATED_NAME@/Documents`
    * Xamarin Android = `/data/data/@PACKAGE_NAME@/files/.local/share`
  * **CommonApplicationData** - Application data for all users (Good when running as Windows Service)
    * Windows Path = `C:\ProgramData`
    * Xamarin Mono = `/usr/share`
    * Xamarin iOS = `/usr/share`
    * Xamarin Android = `/usr/share`
  * **MyDocuments** - My Documents
    * Windows Path = `C:\Users\%USERNAME%\Documents`
    * Xamarin Mono = `$HOME`
    * Xamarin iOS = `/data/Containers/Data/Application/@GENERATED_NAME@/Documents`
    * Xamarin Android = `/data/data/@PACKAGE_NAME@/files`
  * **Desktop** - My Desktop
    * Windows Path = `C:\Users\%USERNAME%\Desktop`
    * Xamarin Mono = `$HOME/Desktop` (or $XDG_DESKTOP_DIR if set)
    * Xamarin iOS = `/data/Containers/Data/Application/@GENERATED_NAME@/Documents/Desktop`
    * Xamarin Android = `/data/data/@PACKAGE_NAME@/files/Desktop`
  * **UserProfile**
    * Windows Path = `C:\Users\%USERNAME%`
    * Xamarin Mono = `$HOME`
    * Xamarin iOS = `/data/Containers/Data/Application/@GENERATED_NAME@`
    * Xamarin Android = `/data/data/@PACKAGE_NAME@/files`
  * **Templates**
    * Windows Path = `C:\Users\%USERNAME%\AppData\Roaming\Microsoft\Windows\Templates`
    * Xamarin Mono = `$HOME/Templates` (or $XDG_TEMPLATES_DIR if set)
    * Xamarin iOS = `/data/Containers/Data/Application/@GENERATED_NAME@/Documents/Templates`
    * Xamarin Android = `/data/data/@PACKAGE_NAME@/files/Templates`
  * **CommonTemplates**
    * Windows Path = `C:\ProgramData\Microsoft\Windows\Templates`
    * Xamarin Mono = `/usr/share/templates`
    * Xamarin iOS = `/usr/share/templates`
    * Xamarin Android = `/usr/share/templates`
  * **Resources**
    * Windows Path = `C:\WINDOWS\resources`
    * Xamarin iOS = `/Library`
  * **AdminTools**
  * **CommonAdminTools**
  * **CommonDesktopDirectory**
  * **CommonDocuments**
  * **CommonMusic**
  * **CommonPictures**
  * **CommonProgramFiles**
  * **CommonProgramFilesX86**
  * **CommonPrograms**
  * **CommonStartMenu**
  * **CommonStartup**
  * **CommonVideos**
  * **Cookies**
  * **DesktopDirectory** (Same as **Desktop**)
  * **Favorites**
  * **Fonts**
  * **History**
  * **LocalizedResources**
  * **MyComputer**
  * **MyMusic**
  * **MyPictures**
  * **MyVideos**
  * **NetworkShortcuts**
  * **Personal** (Same as **MyDocuments**)
  * **PrinterShortcuts**
  * **ProgramFiles**
  * **ProgramFilesX86**
  * **Programs**
  * **Recent**
  * **SendTo**
  * **StartMenu**
  * **Startup**
  * **System**
  * **SystemX86**
  * **Windows**
