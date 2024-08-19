[![Open in Visual Studio Code](https://classroom.github.com/assets/open-in-vscode-2e0aaae1b6195c2367325f4f02e2d04e9abb55f0b24a779b69b11b9e10269abc.svg)](https://classroom.github.com/online_ide?assignment_repo_id=15567257&assignment_repo_type=AssignmentRepo)
# Utvecklingsmiljön

## Intro till *VS Code*
*VS Code* är en fantastisk editor som är gratis och som fungerar på alla plattformar.
Här är en genomgång av *VS Code*:

https://www.youtube.com/embed/B-s71n0dHUk?list=PLj6YeMhvp2S5UgiQnBfvD7XgOMKs3O_G6

## Komma igång med github
Ett bra komplement till *VS Code* är *Github*. Att programmera utan att använda versionshantering är som att köra bil utan att använda säkerhetsbälte.\
Github är en tjänst för att lagra och dela kod. Du kommer att använda github för att lagra dina projekt och för att lämna in labbar och prov.

* Skapa ett konto på [https://github.com](https://github.com)
  * Döp kontot till: **klass-förnamn-efternamn**
  * Valfritt lösenord
  * Använd din skolmail

## Installera git och Dotnet 8
För att kunna använda Visual Studio Code för att skapa C#-projekt behöver du installera **git** och **Dotnet 7**.

> Öppna **Windows Powershell** och *skriv/kör* följande kommandon:

```Powershell
winget install git.git
winget install Microsoft.DotNet.SDK.8
```

Eller gå till följande webbsidor och ladda ner och installera följande mjukvaror:

1. [git](https://git-scm.com/downloads)
2. [Dotnet 7](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-7.0.400-windows-x64-installer)

## Installera tillägg i VS Code
Med tillägg i VS Code förenklas arbetet med att skapa och underhålla projekt.  
Följande tillägg kommer att installeras automatiskt:

* [C#](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp) – Ger VS Code stöd för C#
* [C# Toolbox of Productivity](https://marketplace.visualstudio.com/items?itemName=RichardZampieriprog.csharp-snippet-productivity) – Lägger till en del extra användbara genvägar och funktioner, tex för att skapa nya projekt och klasser
* [Open Folder Context Menu](https://marketplace.visualstudio.com/items?itemName=chrisdias.vscode-opennewinstance) - För att enkelt öppna en mapp
* [gitignore](https://marketplace.visualstudio.com/items?itemName=codezombiech.gitignore) – Underlättar arbetet med git och VS Code. Om du söker efter den, se till att ta den av CodeZombie!
* [VSCode Great Icons](https://marketplace.visualstudio.com/items?itemName=emmanuelbeziat.vscode-great-icons) – Gör det lättare att känna igen filtyper
* [XML Complete](https://marketplace.visualstudio.com/items?itemName=rogalmic.vscode-xml-complete) – För att jobba med WPF och Xaml
* [RedHat XML](https://marketplace.visualstudio.com/items?itemName=redhat.vscode-xml) - För att jobba med WPF och Xaml
* [C# XML Documentation Comments](https://marketplace.visualstudio.com/items?itemName=k--kato.docomment) - För att kommentera metoder och klasser

## Ställ in VS Code från profil-fil
För att få en bra och fungerande utvecklingsmiljö i VS Code, behöver VS Code inställningar ställas in. Detta görs genom att importera en profil.

> Gå in i inställningar och välj **Profile** -> **Import profile** och välj filen *.vscode/Prog.code-profile*.

## Korta ned prompten i terminalen
I terminalen i *VS Code* är prompten väldigt lång och gör det svårt att få en överblick.  
Gör följande för att korta ned prompten i Terminalen/Konsolen i *VS Code*.

> Öppna **terminalen** och *skriv/kör* dessa rader:

```powershell
test-path $profile
new-item -path $profile -itemtype file -force
code $profile
```

> *Skriv in* följande i **fönstret** och *spara*:

```powershell
function prompt {
   $p = Split-Path -leaf -path (Get-Location)
   "$p> "
}
```

> I **terminalen** *skriv/kör*:

```powershell
Set-ExecutionPolicy RemoteSigned -Scope CurrentUser
```

> **Starta om** *VS Code*

Referens: [How to display ony the current folder name](https://superuser.com/questions/446827/configure-windows-powershell-to-display-only-the-current-folder-name-in-the-shel).
