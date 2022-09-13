# Projekt-Dokumentation

Marku

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
| 23.08.2022     | 0.0.1   | Projekt-Dokumentation gemacht |
| 30.08.2022     | 0.0.2   | Programmiert                  |
| 06.09.2022     | 0.0.3   | Programmiert                  |
## 1 Informieren 

### 1.1 Ihr Projekt

In diesem Projekt geht es darum, einen eigenen Numberguesser zu programmieren
### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |  muss  |   funktional   | Als Benutzer möchte ich informiert werden, ob meine Zahl richtig/falsch ist |
| 2    |  muss  |   funktional   | Als Benutzer möchte ich eine Nachricht erhalten, ob die generierte Zufallszahl höher oder Tiefer ist, damit ich eine Idee habe, welche Zahl ich als Nächstes eintippen möchte |
| 3    |  muss  |   funktional   | Als Benutzer möchte ich eine Chance bekommen nochmals zu spielen, wenn meine Zahl falsch ist |
| 4    |  muss  |   funktional   | Als Benutzer möchte ich, nachdem ich die Zufallszahl erraten habe, informiert werden, dass ich gewonnen habe |
| 5    |  muss  |   funktional   | Als Benutzer möchte ich, nachdem ich gewonnen habe gefragt werden, ob ich nochmals eine Runde spielen möchte |
| 6    |  muss  |   funktional   | Als Programmierer möchte ich, dass das Spiel von neu beginnt |
### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
|  1.1  | Das Programm gibt dir an, ob deine Zahl richtig/falsch ist| Zahl eingeben und enter  | Die Eingabe ist falsch/richtig |
|  2.1  | Falls falsch gibt dir Programm an, ob Zufallszahl höher/tiefer ist | enter | Die Zufallszahl ist tiefer |
|  3.1  | Programm läst dich eine neue Zahl eingeben und Zufallszahl bleibt gleich | 50 | Geben sie eine Zahl 1-100 ein |
|  4.1  | Die richtige Zufallszahl ist gefunden worden | enter | sie haben gewonnen |
|  5.1  | Programm fragt ab, ob man nochmals spielen möchte | enter | möchten sie nochmals spielen? |
|  6.1  | Programm generiert neue Zufallszahl und fragt Benutzer eine neue Eingabe zu machen | enter | Geben sie eine Zahl 1-100 ein  |

### 1.4 Diagramme

<img width="519" alt="image" src="https://user-images.githubusercontent.com/110892575/186114556-6030ee6e-d9f6-48c8-8cd2-35b019279479.png">

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  | 06.09.2022 | Marku | Das Programm generiert eine Zahl 1-100 | 1A |
| 1.B  | 06.09.2022 | Marku | Das Programm prüft, ob die Eingabe vom Benutzer richtig/falsch ist | 2A |
| 2.A  | 06.09.2022 | Marku | Das Programm sagt dem Benutzer, ob die Zufallszahl höher/tiefer ist | 1A |
| 3.A  | 06.09.2022 | Marku | Das Programm soll dem Spieler unendliche Chancen geben, die Zahl zu erraten | 2A |
| 4.A  | 06.09.2022 | Marku | Falls der Benutzer die Zufallszahl errät, soll das Programm dem Benutzer sagen, dass er gewonnen hat | 2A |
| 5.A  | 06.09.2022 | Marku | Das Programm sollte den Benutzer fragen, ob er nochmals spielen möchte | 1/5 A |
| 6.A  | 06.09.2022 | Marku | Das Programm sollte neu gestartet werden | 3 A |

Total: 11 1/5 A

## 3 Entscheiden

Ich habe bemerkt, dass ich Arbeitspakete unter und überschäzt habe und habe mich entschieden einfach zu programmieren und zu schauen wie weit ich halt komme.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  | 06.09.2022 | Marku | 1A | 1/5 A |
| 1.B  | 06.09.2022 | Marku | 2A | 1/5 A |
| 2.A  | 06.09.2022 | Marku | 1A | 2 A |
| 3.A  | 06.09.2022 | Marku | 2A | 3A |
| 4.A  | 06.09.2022 | Marku | 2A | 2A |
| 5.A  | 06.09.2022 | Marku | 1/5A | 2A |
| 6.A  | 06.09.2022 | Marku | 3A | 2A |

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |  13.09.2022  | OK |  Marku  |
| 2.1  |  13.09.2022  | OK |  Marku  |
| 3.1  |  13.09.2022  | OK |  Marku  |
| 4.1  |  13.09.2022  | OK |  Marku  |
| 5.1  |  13.09.2022  | OK |  Marku  |
| 6.1  |  13.09.2022  | OK |  Marku  |

###Fazit
Das Programm läuft einwandfrei.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    | Wenn man gefragt wird ob man nochmals spielen möchte und man nicht Ja eingibt stürzt es ab | "hjxghdsgjhds" | ungültige Eiengabe | Das Spiel wird beendet |

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
