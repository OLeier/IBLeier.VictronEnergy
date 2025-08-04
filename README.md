# Solar Monitor

Heutige Solar-Regler stellen eine ganze Reihe von Daten zur Verfügung. Bei einem leeren Akku rechtzeitig vor dem Abschalten gewarnt zu werden,
ist wahrscheinlich zu viel verlangt. Zu vielfältig sind die möglichen Kommunikationswege.

Die smarten Geräte von Victron Energy haben Bluetooth integriert. Bluetooth gibt es aber auch als Zusatz.
Allerdings reicht das Signal gerade ein Stockwerk tiefer. Und für Besitzer eines Smartphone, welches nicht im Handbuch gelistet ist, ist die Verbindungaufnahme ein Geduldsspiel.

Einen speziellen WLAN-Dongle gibt es nicht.

Für den Ve.Direct Anschluss gibt es u.a. ein Kabel zum Anbinden an USB. Via OTG Adapter lässt sich das Ve.direkt Kabel auch mit dem Smartphone nutzen.

Wie kommt man nun in das heimische Netzwerk?
- Das USB-Kabel verlängern bis zum WLAN-Router
- USB - Ip Server
https://www.photovoltaikforum.com/thread/96187-j%C3%BCrgen-bastelt-victron-wr-und-bmv-wireless-bis-zum-pc/
- RasPi + usbip
https://www.tecchannel.de/a/usb-geraete-in-linux-im-netzwerk-verfuegbar-machen,2075505,2
https://www.florian-diesch.de/doc/linux/usb-over-ip-mit-usbipd.html
https://www.henrykoch.de/de/usb-ueber-ip-netz-wlan-verlaengern-mit-raspberry-pi-arduino-scetches-programmieren
- RasPi + Grafana
- Open Source von VE
https://www.victronenergy.com/live/open_source:start

## Voraussetzungen für den Solar Monitor

- SmartSolar Charger MPPT 75/10
- Ve.direkt to USB Kabel
- Raspberry PI 3 mit Venus OS
- Verbindung zum VRM Portal (https://vrm.victronenergy.com/)

## Funktionsumfang

- Abrufen der aktuellen Werte vom VRM Portal
- Alarm Message Box bei verschiedenen Batterie-Spannungen
- Abrufen der aktuellen Werte via Modbus-TCP
- Abschalten des Reglers bei niedriger Solar Leistung

## Historie

### v1.0 (Master_V1)
Alle Projekte hatten als Ziel das .NET Framework 4.8.
Damit war die Nutzung von EasyModbus (https://github.com/rossmann-engineering/EasyModbusTCP.NET) möglich.

### v2.0 (Master)
Die ModbusTcp Dll wurde zur Nutzung von Xamarin auf .NET Standard geändert.
Dafür musste auch das Modbus Paket auf NModbus (https://github.com/NModbus/NModbus) geändert werden.

## Quellen
https://github.com/OLeier/IBLeier.VictronEnergy

## Fortsetzung folgt

## Upgrade von Xamarin auf .NET MAUI

- ModbusTcp
- ModbusTcpTests

- MonitoringApp
NU1201: Das Projekt MonitoringApp ist nicht mit xamarinios10 (Xamarin.iOS,Version=v1.0) kompatibel. Das Projekt MonitoringApp unterstützt Folgendes:
  - net9.0 (.NETCoreApp,Version=v9.0)
  - net9.0-android35.0 (.NETCoreApp,Version=v9.0)
  - net9.0-ios18.0 (.NETCoreApp,Version=v9.0)
  - net9.0-windows10.0.19041 (.NETCoreApp,Version=v9.0)

C:\Program Files\dotnet\packs\Microsoft.Maui.Sdk\9.0.51\Sdk\BundledVersions.targets(85,5):
  warning MA002: Starting with .NET 8, setting  <UseMaui>true</UseMaui>  does not automatically include
  NuGet package references in your project.  Update your project by including this item:
    <PackageReference Include="Microsoft.Maui.Controls" Version="9.0.51" />.
  You can skip this warning by setting
    <SkipValidateMauiImplicitPackageReferences>true</SkipValidateMauiImplicitPackageReferences>
  in your project file.

- MonitoringApp: 26 sek
  TODO Xamarin.Forms.Device.StartTimer wird nicht mehr unterstützt.
  warning CS0618: "Application.MainPage.set" ist veraltet:
    "This property is deprecated. Initialize your application by overriding Application.CreateWindow rather than setting MainPage.
    To modify the root page in an active application, use Windows[0].Page for applications with a single window.
    For applications with multiple windows, use Application.Windows to identify and update the root page on the correct window.
     Additionally, each element features a Window property, accessible when it's part of the current window."
  warning XC0025: Binding was not compiled because it has an explicitly set Source property and
    compilation of bindings with Source is not enabled. Consider enabling this optimization by setting the
      <MauiEnableXamlCBindingWithSourceCompilation>true</MauiEnableXamlCBindingWithSourceCompilation>
    in your project file and make sure the correct x:DataType is specified for this binding.
    See https://learn.microsoft.com/dotnet/maui/fundamentals/data-binding/compiled-bindings for more information.

- MonitoringApp.UWP
