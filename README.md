Dieses Programm berechnet den Abstand und die Richtung zwischen zwei Locatorstandorten. 

Im Amateurfunk werden keine Koordinaten, sondern Locatorfelder genutzt. Dies ist ein Raster über den ganzen Globus.
Das Locatorfeld um Berlin und Brandenburg herum hat die Buchstaben JO62. Hinzu kommen noch die Kleinfelder mit den Buchstaben A bis X. Dies sind die Zeilen und Spalten.

Berlin hat z.B. den Locator **JO62QM**. (Zeile Q, Spalte M) und noch andere. 

Rom hat den Locator **JN61GV** und ist von der Stadt Brandenburg an der Havel (JO62GJ) nur 
1166 Kilometer entfernt und liegt in 180 Grad (das ist Süden). Der Amateurfunker dreht also seine Antenne in 180 Grad.


> [!NOTE]
In dieses Programm muss eine Klasse importiert werden.
// Copyright (c) 2011, Yves Goergen, http://unclassified.software/source/maidenheadlocator
//
// Das Kopieren und Verbreiten dieser Datei, mit oder ohne Änderung, ist unter der Voraussetzung gestattet
// Copyright-Hinweis und dieser Hinweis bleiben erhalten. Diese Datei wird ohne jegliche Gewährleistung angeboten.
// Diese Klasse basiert auf einem Perl-Modul von Dirk Koopman, G1TLH, vom 07.11.2002. Quelle: http://www.koders.com/

> [!NOTE]
Zeichnen der Kompassrose Quelle: C# Helper (http://www.csharphelper.com/howtos/howto_horizontal_compass.html)

![image](https://github.com/DL1RLB/MyLocator/assets/69315366/08bf2a04-7a5f-4621-9db2-5709bcc0b845)
![image](https://github.com/DL1RLB/MyLocator/assets/69315366/755fbd94-04f5-4fcb-81b7-d6bac2ac7c18)


> [!WARNING]
> - [ ] Es kommt eine Exeption wenn man die Buchstaben Y und Z am Ende eingibt. Diese Zeichen gibt es im Locator nicht. Als Zwischenlösung wird der Text in den Locatorfeldern farblich gändert. Bei den Koordinaten müssen auch Kommas verwendet werden (z.B. 12,55 52,41). Bei Punkte kommt es ebenfalls zur Exeption.

> [!NOTE]
> - [ ] Ein Link zu einer Locatorkarte findest du hier: (https://de.wikipedia.org/wiki/QTH-Locator)https://de.wikipedia.org/wiki/QTH-Locator


