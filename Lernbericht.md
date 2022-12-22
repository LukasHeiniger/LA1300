# Lern-Bericht
Gruppe: Pancakes
Teilnehmer: Gabriel Bischof, Ava Hassani, Steven Salie, Lukas Heiniger

## Einleitung

Wir haben ein Spiel mit Winforms erstellt, welches einem erlaubt einen Keks zudrücken. 

## Was habe ich gelernt?

Wir haben gelernt, wie man einen Timer richtig in Winforms einsetzt und wie man die Ticks in Sekunden und Minuten aufteilen kann.

## Beschreibung


Wir haben den Timer gebraucht, welcher einem seine Spieldauer anzeigen soll. Zudem brauchten wir den Timer nicht nur für die Anzeige, sondern auch für die einzelnen Upgrades, welche Punkte pro Sekunden bringen sollen. Das Problem war aber, dass der Timer nicht in Sekunden, sondern in Ticks zählte. Das heisst wir mussten zuerst die Ticks in Sekunden um wandeln und das geht so.

```C#



            int t = 0;
            int s = 0;
            int m = 0;

            if (t == 10)
            {
            
                t = 0;
                s++;
                label8.Text = m.ToString() + " : " + s.ToString();

                if (s == 60)
                {
                    m++;
                    s = 0;
                    label8.Text = m.ToString() + " : " + s.ToString();

                }
            }   

```

Hier ein Gif, welches den Timer in unserem Projekt zeigt:

![Timer](https://user-images.githubusercontent.com/111046378/209090228-ed8e29f7-c0d6-463c-ab6e-32b64ee45e0d.gif)
   
   
   
   

## Verifikation
Der Text zeigt, für was wir den Timer gebraucht haben und wie wir vorgegangen sind.
Der Code zeigt, wie wir dieses Problem gelöst haben und wie wir von Ticks auf Sekunden und Minuten gelangt sind.
Das Gif zeigt das Resultat wie ein Timer in Winforms aussehen könnte.

# Reflexion zum Arbeitsprozess

Wir arbeiteten effizient und effektiv zusammen die Arbeit hat uns allen sehr viel Spass bereitet.

Die Beteiligung in der Gruppe an den Arbeiten war nicht immer sehr hoch.

Verbesserungsvorschlag:
Wir möchten alle das nächste Mal unsere Gruppenmitglieder mehr anspornen und ermutigen, mehr mit der Gruppe zu arbeiten.
