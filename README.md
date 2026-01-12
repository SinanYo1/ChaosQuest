ChaosQuest
------------------------------------------------------------------------------------
Wichtige Informationen

um das Spiel in Unity zu importieren brauchen die Ordner "Packages", "ProjectSettings" und Assets. Da es Probleme beim Importieren des Assets Folder gab
müssen sie die Zip Datei dieses Ordners leider über diesen Link Downloaden: https://mega.nz/folder/V3E0FLhL#76xuC7fC-p5mL0JljFKQog
falls sie nur das Spiel sehen wollen müssen sie die "Chaos Quest.exe" Downloaden und ausführen.
Das Spiel ist nicht vollständig und nicht perfekt entwickelt, da der zeitliche Rahmen dies nicht zugelassen hat und es für das Schulprojekt auch nicht vorgesehen war, ein komplett fertiges Spiel zu erstellen.
Außerdem können vereinzelt Importierungsfehler auftreten, die bestimmte Aspekte des Spiels beeinträchtigen.

Sollten Fragen auftreten, beispielsweise zur Bedienung von Unity oder zum Öffnen der einzelnen Minispiele, können Sie mir gerne eine Nachricht senden
(@sinanyapraky@gmail.com).

Falls ich in die zweite Phase des Bewerbungsverfahrens kommen sollte, können dort gerne detailliertere Fragen gestellt werden. 🙂

-----------------------------------------------------------------------------------
Spielprinzip

ChaosQuest ist ein lokales, rundenbasiertes Spiel, das an Mario Party angelehnt ist.
Die Spieler würfeln abwechselnd und landen auf verschiedenen Feldern, von denen jedes einen eigenen Effekt besitzt (z. B. +Münzen, −Münzen, Teleportation usw.).
Nach jeder Würfelrunde wird ein zufälliges Minispiel ausgelöst. Der Gewinner dieses Minispiels erhält Münzen.
Mit diesen Münzen können sogenannte Chaos-Sterne gekauft werden.
Das Ziel des Spiels ist es, als erster genügend Chaos-Sterne zu sammeln, um den Zauberwald zu verlassen und das Spiel zu gewinnen.

-----------------------------------------------------------------------------------
Vorgeschichte

Für ein Abschlussprojekt im Rahmen meiner Fachhochschulreife sollte man im Team ein Projekt entwickeln, entweder im Hardware- oder Softwarebereich.
Ich entschied mich gemeinsam mit zwei weiteren Teammitgliedern für ein Softwareprojekt. Uns war schnell klar, dass wir ein Spiel entwickeln wollten.

Als Game-Engine wählten wir Unity, da wir in der Schule hauptsächlich C# gelernt hatten und Unity auf dieser Programmiersprache basiert.
Da wir uns die meisten Unity-Funktionen selbst beibringen mussten, kam ich auf die Idee, ein Spiel mit mehreren Minispielen zu entwickeln.
So konnten wir klein anfangen und alles, was wir zum Üben programmierten, direkt als Minispiel integrieren. Dadurch konnten wir uns stetig steigern und weiterentwickeln.
-----------------------------------------------------------------------------------
Probleme

Eine große Herausforderung bestand darin, dass wir viele Bereiche wie UI-Design, Game Design, Animation, Soundbearbeitung und weitere Aspekte ohne Vorkenntnisse selbst erlernen mussten.
Zudem ist es nicht möglich, mit reinem C#-Wissen direkt mit Unity zu arbeiten, da Unity auf der vererbten Klasse MonoBehaviour basiert.
Diese Klasse bringt zahlreiche neue Methoden und Parameter mit sich, bei denen man aufgrund der Vielzahl leicht den Überblick verlieren kann.
-----------------------------------------------------------------------------------
Meine Vorgehensweise

Da – wie bereits erwähnt – neue Fähigkeiten erforderlich waren, um das gesamte Projekt umzusetzen, habe ich mir Unterstützung durch verschiedene YouTube-Tutorials geholt.
Da ich jedoch nicht zu jeder Idee ein passendes oder vollständig erklärendes Video finden konnte, habe ich meine Arbeit in kleine, überschaubare Teilschritte unterteilt.

Am Beispiel des Minispiels „Count Clash“ (die Funktionsweise ist unten beschrieben) lässt sich meine Vorgehensweise gut erklären:
Zunächst benötigte ich eine zufällige Anzahl an NPCs, die sich eigenständig durch die Map bewegen.
Daher habe ich mich zuerst damit beschäftigt, wie ich die Generierung der NPCs umsetzen kann.
Anschließend habe ich mich mit der Frage befasst, wie ich diese NPCs dazu bringe, sich zufällig über die Map zu bewegen.

Diese Vorgehensweise – das Zerlegen eines größeren Problems in mehrere kleinere Aufgaben – habe ich während des gesamten Projekts angewendet, um Schritt für Schritt funktionierende Lösungen zu entwickeln.
Die obige Erklärung stellt dabei nur eine vereinfachte Darstellung des tatsächlichen Entwicklungsprozesses dar.
-----------------------------------------------------------------------------------
Meine Aufgaben im Projekt

Ich entwickelte die Minispiele „Count Clash“, „Flash Attack“ und „Meteor Madness“ vollständig eigenständig.
Darüber hinaus unterstützte ich das Team auch beim Hauptspiel sowie bei anderen Minispielen, insbesondere in den Bereichen UI-Design, Animation, Sound und Spiellogik.
-----------------------------------------------------------------------------------

Erklärung meiner Minispiele
Flash Attack:

Zwei Spieler stehen sich gegenüber, während eine spannende Musik abgespielt wird.
Sobald die Musik endet und das Signal „Fight“ erscheint, muss der jeweilige Spieler seinen Aktionsknopf drücken
(Spieler 1: Taste „D“, Spieler 2: linke Pfeiltaste).
Der Spieler, der zuerst korrekt reagiert, zieht seinem Gegner eines von drei Leben ab.
Drückt ein Spieler jedoch vor dem Signal, verliert er selbst ein Leben.
-----------------------------------------------------------------------------------
Meteor Madness:

In diesem Minispiel fallen Meteoriten vom Himmel, die nach und nach das Spielfeld füllen.
Das Ziel ist es, den Meteoriten auszuweichen.
Der Spieler, der zuerst von einem Meteoriten getroffen wird, verliert das Spiel.
-----------------------------------------------------------------------------------
Count Clash

Eine zufällige Anzahl beweglicher NPCs füllt die Map.
Die Spieler haben 30 Sekunden Zeit, um die Anzahl der NPCs zu zählen.
Der Spieler, dessen Schätzung näher an der tatsächlichen Anzahl liegt, gewinnt.
-----------------------------------------------------------------------------------
