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
