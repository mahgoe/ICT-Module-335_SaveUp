# SaveUp

SaveUp ist eine mobile Applikation, die Benutzern ermöglicht, kleine, alltägliche Ausgaben zu verfolgen und zu sparen. Nutzer können auf Ausgaben wie Kaffee, Süßigkeiten oder andere kleine Einkäufe verzichten und diese Einsparungen in der App festhalten.

## Überblick

Die SaveUp-App bietet eine benutzerfreundliche Oberfläche, mit der Benutzer ihre gesparten Beträge einfach erfassen und verwalten können. Ziel der Anwendung ist es, den Benutzern einen Überblick über ihre Einsparungen zu geben und sie zu motivieren, weiterhin bewusst auf kleine Ausgaben zu verzichten, um größere finanzielle Ziele zu erreichen.

## Funktionen

- **Erfassung von Einsparungen:** Nutzer können eine Kurzbeschreibung und den Preis der gesparten Artikel eingeben und speichern.
- **Anzeigen der Einsparungen:** Eine Liste der gesparten Artikel inklusive der Gesamtsumme wird angezeigt.
- **Clear-Funktion:** Möglichkeit, alle gespeicherten Einträge mit einem einzigen Befehl zu löschen.
- **Datumseingabe:** Speicherung des Datums, an dem der Kaufverzicht erfolgte.
- **Informationsseite:** Bereitstellung von Informationen zur App und den Entwicklern.

## Installation

### Voraussetzungen

- [.NET MAUI](https://dotnet.microsoft.com/apps/maui)
- [Visual Studio mit .NET MAUI-Unterstützung](https://visualstudio.microsoft.com/vs/preview/vs2022/)

### Schritte zur Installation

1. **Repository klonen:**

   ```bash
   git clone https://github.com/Benutzername/SaveUp.git
   ```

2. **Projekt öffnen:**

   Öffnen Sie das geklonte Projekt in Visual Studio.

3. **Abhängigkeiten installieren:**

   Stellen Sie sicher, dass alle notwendigen NuGet-Pakete installiert sind. Dies sollte automatisch beim Öffnen des Projekts in Visual Studio geschehen. Die wichtigsten Pakete sind:

- CommunityToolkit.Mvvm
- Microsoft.Maui.Controls
- Microsoft.Maui.Controls.Compatibility

4. **Projekt ausführen:**

   Wählen Sie im Visual Studio die Zielplattform (z.B. Android, iOS, Windows) und führen Sie das Projekt aus.

## Nutzung

### Einsparungen erfassen:

1. Navigieren Sie zur Eingabeseite.
2. Geben Sie die Kurzbeschreibung und den Preis des gesparten Artikels ein.
3. Speichern Sie den Eintrag.

### Einsparungen anzeigen:

1. Gehen Sie zur Anzeigeseite, um eine Liste der gesparten Artikel und die Gesamtsumme zu sehen.

### Einträge löschen:

1. Wählen Sie einen Eintrag aus und bestätigen Sie die Löschung über die Popup-Seite.
2. Alternativ können Sie die Clear-Funktion nutzen, um alle Einträge zu löschen.
