# Projekt-Dokumentation

Marku

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
| 23.08.2022     | 0.0.1   | Projekt-Dokumentation gemacht |
|       | ...     |                                                              |
|       | 1.0.0   |                                                              |

## 1 Informieren 

### 1.1 Ihr Projekt

In diesem Projekt geht es darum, einen eigenen Numberguesser zu programmieren
### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |  muss  |   funktional   | Als Benutzer möchte ich informiert werden, ob meine Zahl richtig/falsch ist |
| 2    |  muss  |   funktional   | Als Benutzer möchte ich eine Nachricht erhalten, ob die generierte Zufallszahl höher oder Tiefer ist, damit ich eiene Idee habe, welche Zahl ich als Nächstes eintippen möchte |
| 3    |  muss  |   funktional   | Als Benutzer möchte ich eine Chance bekommen nochmals zu spielen, wenn meine Zahl falsch ist |
| 4    |  muss  |   funktional   | Als Benutzer möchte ich, nachdem ich die Zufallszahl erraten habe, informiert werden, dass ich gewonnen habe |
| 5    |  muss  |   funktional   | Als Benutzer möchte ich, nachdem ich gewonnen habe gefragt werden, ob ich nochmals eine Runde spielen möchte |
| 6    |  muss  |   funktional   | Als Programmier möchte ich, dass das Spiel von neu beginnt |
### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
|  1.1  | Das Programm gibt dir an, ob deine Zahl richtig/falsch ist| Zahl eingeben und enter  | Die Eingabe ist falsch/richtig |
|  2.1  | Fals falsch gibt dir Programm an ob Zufallszahl höher/tiefer ist | enter | Die Zufallszahl ist tiefer |
|  3.1  | Programm startet neu und Zufallszahl bleibt gleich | 50 | Geben sie eine Zahl 1-100 ein |
|  4.1  | Die richtige Zufallszahl ist gefunden worden | enter | sie haben gewonnen |
|  5.1  | Programm fragt ab ob mann nochmals spielen möchte | enter | möchten sie nochmals spielen ? |
|  6.1  | Programm generiert neue Zufallszahl und fragt benutzer eine neue eingabe zu machen | enter | Geben sie eine Zahl 1-100 ein  |

### 1.4 Diagramme

<img width="519" alt="image" src="https://user-images.githubusercontent.com/110892575/186114556-6030ee6e-d9f6-48c8-8cd2-35b019279479.png">

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  | 06.09.2022 | Marku | Das Programm generiert eine Zahl 1-100 | 1A |
| 1.B  | 06.09.2022 | Marku | Das Programm prüft ob die eingabe vom benutzer richtig/falsch ist | 2A |
| 2.A  | 06.09.2022 | Marku | Das Programm sagt dem Benutzer ob die Zufallszahl höher/tiefer ist | 1A |
| 3.A  | 06.09.2022 | Marku | Das Programm soll dem spieler unendliche Chancen geben die zahl zu erraten | 2A |
| 4.A  | 06.09.2022 | Marku | Fals der Benutzer die Zufallszahl errät soll das Programm im sagen, dass er gewonnen hat | 2A |
| 5.A  | 06.09.2022 | Marku | Das Programm sollte den Benutzer fragen, ob er nochmals spielen möchte | 1/5 A |
| 6.A  | 06.09.2022 | Marku | Das Programm sollte neu gestartet werden | 3 A |

Total: 

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  | 06.09.2022 | Marku | 1A | 1/5 |
| 1.B  | 06.09.2022 | Marku | 2A | 1/5 |
| 2.A  | 06.09.2022 | Marku | 1A | 1/3 |
| 3.A  | 06.09.2022 | Marku | 2A | |
| 4.A  | 06.09.2022 | Marku | 2A | |
| 5.A  | 06.09.2022 | Marku | 1/5A | |
| 6.A  | 06.09.2022 | Marku | 3A | |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
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
