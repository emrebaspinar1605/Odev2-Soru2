using System;
using System.Collections;

        ArrayList liste = new ArrayList();
        int mintop = 0;
        int maxtop = 0;
        for (int i = 0; i <= 19; i++)
        {
            int sayi = Convert.ToInt32(Console.ReadLine());

            liste.Add(sayi);
        }
      int x=0;
        foreach (var list in liste)
        {
            if (x<3)
            {mintop+=Convert.ToInt32(list);
            x++;
            }
        }
        Console.WriteLine("En Küçük 3 Eleman=" + liste[0] + "," + liste[1] + "," + liste[2]);
        x=0;
        liste.Reverse();
        foreach (var list in liste)
        {
            if (x<3)
            {
                 maxtop += Convert.ToInt32(list);
                 x++;
            }
           

        }
        
        Console.WriteLine("En Büyük 3 Eleman=" + liste[0] + "," + liste[1] + "," + liste[2]);

        Console.WriteLine("En Küçük 3 Elemanın Ortalaması= " + mintop / 3);
        Console.WriteLine("En Büyük 3 Elemanın Ortalaması= " + maxtop / 3);
        Console.WriteLine("En büyük 3 Eleman ile En Küçük 3 Elemanın Kendi Aralarında ki Ortalama Toplamları= " + (mintop / 3 + maxtop / 3));
