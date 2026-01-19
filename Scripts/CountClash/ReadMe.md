Spielprinzip:
Eine zufällige Anzahl beweglicher NPCs füllt die Map. Die Spieler haben 30 Sekunden Zeit, um die Anzahl der NPCs zu zählen. Der Spieler, dessen Schätzung näher an der tatsächlichen Anzahl liegt, gewinnt.

Wichtige Infos:
Die Code beschreibungen sind verkürzt ganz unten bei jeder Datei.

Dies war das erste Mini-Spiel, das ich erstellt habe. Zu diesem Zeitpunkt habe ich noch nicht auf Clean Code geachtet, da ich damals deutlich unerfahrener war.

Mit meinem heutigen Wissensstand würde ich folgende Punkte anders umsetzen:

-Die UI klar von der Spiellogik trennen.

-Den Zugriff stärker einschränken, also deutlich weniger Variablen als public deklarieren.

-Den Code so weit wie möglich vereinfachen und reduzieren, zum Beispiel Player2Movement und CameraMovement in einer gemeinsamen Klasse zusammenfassen, da sich der Code in 
beiden Klassen lediglich für den jeweils anderen Spieler wiederholt.
