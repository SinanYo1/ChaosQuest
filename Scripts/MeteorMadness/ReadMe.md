Spielprinzip:
In diesem Minispiel fallen Meteoriten vom Himmel, die nach und nach das Spielfeld füllen. Das Ziel ist es, den Meteoriten auszuweichen. Der Spieler, der zuerst von einem Meteoriten getroffen wird, verliert das Spiel.

Wichtige Infos:
Die Code beschreibungen sind verkürzt ganz unten bei jeder Datei.

Mit meinem heutigen Wissensstand würde ich folgende Punkte anders umsetzen:

-Die UI klar von der Spiellogik trennen.

-Den Zugriff stärker einschränken, also deutlich weniger Variablen als public deklarieren.

-Den Code so weit wie möglich vereinfachen und reduzieren, zum Beispiel Char1Movement und Char2Movement in einer gemeinsamen Klasse zusammenfassen, da sich der Code in beiden Klassen lediglich für den jeweils anderen Spieler wiederholt.
