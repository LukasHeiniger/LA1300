# LA1300

# Projekt-Dokumentation

Pancakes: Grabriel Bischof, Ava Hassani, Steven Salie, Lukas Heiniger

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
| 1.12.2022      | 0.0.1   | Das Programm hat ein paar funktionale anforderungen ist aber noch am anfang.|
| 8.12.2022      | 0.0.2    | Das Programm besitzt alle funktionale anforderungen ist aber noch nicht fertig.                                                             |
| 14.12.2022      | 1.0.0   | Das Programm ist spielbar.                                                             |

## 1 Informieren

### 1.1 Ihr Projekt

Wir machen ein Spiel in dem man auf einen Knopf drücken kann der, dann einen Zähler hoch ticken lässt mit diesen Punkten kann man sich Upgrads kaufen welchen den Ticker schneller hochsteigen lässt. Idee Cookie Clicker

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |  muss               | funktional     | Als Benutzer möchte ich ein Button haben, damit ich auf den Button klicken kann|
| 2    |  muss               | funktional     | Als Benutzer möchte ich einen Zahler, damit ich sehen kann wie viel ich schon geklickt|
| 3    |  muss               | funktional     | Als Benutzer möchte ich Upgrades haben, damit der Zähler immer schneller nach oben schiesst|
| 4    |  muss               | randanforderung     | Als Benutzer möchte ich einen Resetbutton haben, damit ich das Spiel von vorne beginnen kann|
| 5    |  kann                | randanforderung     | Als Benutzer möchte ich mein Spielstand abspeicher, damit ich nicht immer wieder von vorne beginnen muss|
| 6    |  kann               | randanforderung     | Als Benutzer möchte ich einen Timer haben welcher mir Sagt wie lange ich schon spiele, damit ich weiss wie lange ich schon an einem Spielstand bin              |
| 7    | kann                | qualität      | Als Benutzer möchte ich schöne Modelle, damit das Spiel besser aussieht                                   |
| 8    | kann                | randanforderung     | Als Benutzer möchte ich das Spiel im Vollbild spielen, damit ich das Spiel besser sehen kann                                   |
| 9    | kann                |funktionale | Als Benutzer möchte ich verschiedene Modis haben, damit man mehr Spass hat und abwechslung.                                   |
| 10    |kann                 | randanforderung     | Als Benutzer möchte ich eine Datei mit der Bestenliste, damit ich mich mit anderen verlgleichen kann.                                   |




### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1    | Wenn der Button geklickt +1             |   klicken des Buttons      |     +1              |
| 2.1   | +1            |  Button wird weiter gecklickt       |  Zähler geht hoch      |
| 3.1    | Durch den Kauf eine Upgrad werden die Punkte abgezogen| kauf des Upgrads| X wert minus Kaufpreis |
| 4.1    | Falls Spiel vorbei oder keine Lust mehr | Reset Button drücken | Programm fängt von Vorne an |
| 5.1    | Keine Lust mehr oder Fertig | Drücken des Ende Buttons | Gesamt Cookie Anzahl wird gespeichert |
| 5.2    | Will wieder spielen | Speicherslot auswählen | Geht los mit der vorherigen Cookie Zahl und Upgrades |
| 6.1    | Der Timmer soll pro Sekunde hoch zählen.             |  Zeit vegeht       |  Timer zählt hoch                 |
| 7.1    | Spiel wird gestartet | - | Schönes Design wird angezeigt |
| 8.1    | Design erstellen falls Vollbild aktiviert | Vollbild einstellen | Vollbild mit guter Sklarierung wird angezeigt |
| 9.1    | Spiel wird gestartet, Auswahl wird angezeigt | Modi auswählen | Modi wird geladen |
| 10.1   | Spiel wird beendet            |   Ende Button wird gedrückt     |     Spielstand wird in Word oder .txt gespeichert             |


### 1.4 Diagramme
![image](https://user-images.githubusercontent.com/111046378/205611501-174ce13b-0339-4ad2-aa65-ba65fbf5388a.png)

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  | 01.12.22  | Bischof,Salie | Einen Button erstellen.           |5 min|
| 1.B | 01.12.22   | Bischof,Salie | Variablen definieren für den Button                 |5 min|
| 2.A  | 01.12.22  | Bischof,Salie | Label erstellen.                     |5 min|
| 2.B  | 01.12.22  | Bischof,Salie | Zählen bei Klick von Button.                     |15 min|
| 2.C  | 01.12.22  | Bischof,Salie | Zähler durch ein Label anzeigen.                        |5 min|
| 3.A  | 01.12.22  | Bischof,Salie | Label erstellen für Timer.                       |5 min|
| 3.B  | 01.12.22  | Bischof,Salie | Timer erstelllen.                       |5 min|
| 3.C  | 01.12.22  | Bischof,Salie | Timer in Minuten unterteilen.                       |5 min|
| 4.A  | 01.12.22  | Bischof,Salie | Resetbutton erstellen                        |5 min|
| 4.B  | 01.12.22  | Bischof,Salie | Resetbutton setzt den Zähler zurück.                        |10 min|
| 4.C  | 01.12.22  | Bischof,Salie | Resetbutton setzt Timer zurück.                        |30 min|
| 5.A  | 01.12.22  | Hassani,Heiniger | Backofen button erstellen.                 |5 min|
| 5.B  | 01.12.22  | Hassani,Heiniger | Backofen erhöht Punktzahl.                 |10 min|
| 5.C  | 01.12.22  | Hassani,Heiniger | Backofen zieht Punktzahl für kauf ab.                 |10 min|
| 6.A  | 01.12.22  | Hassani,Heiniger | Erstellen vom Bäckerei Button                |5 min|
| 6.B | 01.12.22  | Hassani,Heiniger | Bäckerei erhöht Punktzahl                 |15 min|
| 6.C  | 01.12.22  | Hassani,Heiniger | Bäckerei zieht Punktzahl für kauf ab.                 |10 min|
| 7.A  | 01.12.22  | Hassani,Heiniger | Fabrik button erstellen.                 |5 min|
| 7.B  | 01.12.22  | Hassani,Heiniger | Fabrik erhöht Punktzahl.                 |10 min|
| 7.C  | 01.12.22  | Hassani,Heiniger | Fabrik zieht Punktzahl für kauf ab.                 |10 min|
| 8.A  | 01.12.22  | Hassani,Heiniger | Restaurant button erstellen.                 |5 min|
| 8.B  | 01.12.22  | Hassani,Heiniger | Restaurant erhöht Punktzahl.                 |10 min|
| 8.C  | 01.12.22  | Hassani,Heiniger | Restaurant zieht Punktzahl für kauf ab.                 |10 min|
| 9.A  | 01.12.22  | Hassani,Heiniger | Atomkraftwerk button erstellen.                 |5 min|
| 9.B  | 01.12.22  | Hassani,Heiniger | Atomkraftwerk erhöht Punktzahl.                 |10 min|
| 9.C  | 01.12.22  | Hassani,Heiniger | Atomkraftwerk zieht Punktzahl für kauf ab.                 |10 min|
| 10.A  | 01.12.22  | Heiniger | Cookie Designen.                 |10 min|
| 11.A  | 08.12.22  | Bischof,Salie | Spielstand abspeichern.                  |45 min|
| 12.A  | 08.12.22  | Hassani,Heiniger | Highscore Board                |45 min|
| 12.A  | 08.12.22  | Bischof,Salie | Ausgabe von abgespeicherten Spielstand                |45 min|
Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

Wir haben entschieden, zuerst die Mussanforderungen zu machen und falls Zeit übrig ist die Kannanforderungen zuerstellen.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  | 01.12.22      |  Bischof,Salie         |  5 min            |    5 min              |
| 1.A  | 01.12.22      |  Bischof,Salie         |  5 min            |    6 min              |
| 2.A  | 01.12.22      |  Bischof,Salie         |  5 min              |   2 min                |
| 2.B  | 01.12.22      |  Bischof,Salie         |  15 min              |   15 min                |
| 2.C  | 01.12.22      |  Bischof,Salie         |  5 min             |    5 min               |
| 3.A  | 01.12.22      |  Bischof,Salie         |  5 min             |  5 min                 |
| 3.B  | 01.12.22      |  Bischof,Salie        |   5 min            |   5 min                |
| 3.C  | 01.12.22      |  Bischof,Salie        |   5 min            |   5 min                |
| 4.A  | 01.12.22      |  Bischof,Salie         |   5 min            |   3min                |
| 4.B  | 01.12.22      |  Bischof,Salie         |   10 min            |   12min                |
| 4.C  | 01.12.22      |  Bischof,Salie         |   30 min            |   30 min               |
| 5.A  | 01.12.22      |  Hassani,Heiniger         |  5 min             |   6 min                |
| 5.B  | 01.12.22      |  Hassani,Heiniger         |  10 min             |  9 min                 |
| 5.C  | 01.12.22      |  Hassani,Heiniger         |  10 min             |  8 min                 |
| 6.A  |       |           |               |                   |
| 6.B  |       |           |               |                   |
| 6.C  |       |           |               |                   |
| ...  |       |           |               |                   |
| ...  |       |           |               |                   |
| ...  |       |           |               |                   |
| ...  |       |           |               |                   |
| ...  |       |           |               |                   |
| ...  |       |           |               |                   |
| ...  |       |           |               |                   |
| ...  |       |           |               |                   |


✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1   | 01.12.22      |  stimmt        | Bischof,Salie       |
| 2   | 01.12.22      | stimmt         | Bischof,Salie       |
| 3   | 01.12.22      |stimmt        |  Hassani,Heiniger      |
| ...  |       |          |        |
| ...  |       |          |        |
| ...  |       |          |        |
| ...  |       |          |        |
| ...  |       |          |        |
| ...  |       |          |        |
| ...  |       |          |        |
| ...  |       |          |        |
| ...  |       |          |        |
| ...  |       |          |        |
| ...  |       |          |        |
| ...  |       |          |        |
| ...  |       |          |        |
| ...  |       |          |        |
| ...  |       |          |        |
| ...  |       |          |        |
| ...  |       |          |        |
| ...  |       |          |        |
| ...  |       |          |        |
| ...  |       |          |        |
| ...  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
