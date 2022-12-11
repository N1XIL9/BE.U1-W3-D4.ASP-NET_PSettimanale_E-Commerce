using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BE.U1_W3_D4.ASP_NET_PSettimanale_E_Commerce
{
    public class Prodotto
    {
        public int Id { get; set; }

        public string NomeProdotto { get; set; }

        public string Descrizione { get; set;}

        public string Immagine { get; set; }

        public double Prezzo { get; set; }

        public static double TotCarrello { get; set; }

        public static List<Prodotto> GetProdotto()
        {
            List<Prodotto> listaProdotti = new List<Prodotto>();

            Prodotto articolo1 = new Prodotto { Id = 1, NomeProdotto = "Apple Watch 7 44mm ", Descrizione = "Cassa in Alluminio color Argento.Cinturino Sport Band Bianco.Taglia Regular.Touch screen.Sistema operativo incluso: watchOS 9", Immagine = "img/1.png", Prezzo = 489 };
            Prodotto articolo2 = new Prodotto { Id = 2, NomeProdotto = "Apple Watch 8 45mm", Descrizione = "Cassa in Alluminio color Mezzanotte.Cinturino Sport Band nero.Taglia Regular.Touch screen.Sistema operativo incluso: watchOS 9", Immagine = "img/2.png", Prezzo = 389 };
            Prodotto articolo3 = new Prodotto { Id = 3, NomeProdotto = "Apple Watch Ultra 49mm ", Descrizione = "Cassa in Titanio color Argento.Cinturino Sport Band Bianco.Taglia Regular.Touch screen.Sistema operativo incluso: watchOS 9", Immagine = "img/3.jpg", Prezzo = 1189 };
            Prodotto articolo4 = new Prodotto { Id = 4, NomeProdotto = "Apple Watch 7 41 mm", Descrizione = "Con il modello GPS rispondi a chiamate e messaggi dall’orologio\r\nIl display Retina always-on è quasi il 20% più ampio rispetto ai modelli Series 6: tutto è più semplice da vedere e da usare\r\nIl cristallo anteriore più robusto che un Apple Watch abbia mai avuto, resistenza alla polvere di grado IP6X e design a prova di nuotate\r\nMisura l’ossigeno nel sangue con un sensore e un’app all’avanguardia\r\nFai un ECG quando vuoi, dove vuoi\r\nNotifiche in caso di frequenza cardiaca troppo alta o troppo bassa, o di ritmo irregolare\r\nNuovi allenamenti Tai Chi e Pilates, e tantissimi altri fra cui Corsa, Yoga, Nuoto e Ballo\r\nCon Apple Watch misuri ogni giorno quanto ti muovi e controlli i tuoi progressi nell’app Fitness su iPhone\r\nSincronizza musica, podcast e audiolibri\r\nApple Watch Series 7 richiede iPhone 6s o successivo con iOS 15 o successivo", Immagine = "img/4.jpg", Prezzo = 389 };
            Prodotto articolo5 = new Prodotto { Id = 5, NomeProdotto = "Apple Watch 44mm", Descrizione = "Cassa in Alluminio color Argento.Cinturino Sport Band Bianco.Taglia Regular.Touch screen.Sistema operativo incluso: watchOS 9", Immagine = "img/5.png", Prezzo = 489 };
            Prodotto articolo6 = new Prodotto { Id = 6, NomeProdotto = "Apple Watch 44mm", Descrizione = "Cassa in Alluminio color Argento.Cinturino Sport Band Bianco.Taglia Regular.Touch screen.Sistema operativo incluso: watchOS 9", Immagine = "img/6.jpg", Prezzo = 489 };
            Prodotto articolo7 = new Prodotto { Id = 7, NomeProdotto = "Apple Watch 44mm", Descrizione = "Cassa in Alluminio color Argento.Cinturino Sport Band Bianco.Taglia Regular.Touch screen.Sistema operativo incluso: watchOS 9", Immagine = "img/7.jpg", Prezzo = 489 };
            Prodotto articolo8 = new Prodotto { Id = 8, NomeProdotto = "Apple Watch 44mm", Descrizione = "Cassa in Alluminio color Argento.Cinturino Sport Band Bianco.Taglia Regular.Touch screen.Sistema operativo incluso: watchOS 9", Immagine = "img/8.jpg", Prezzo = 489 };
            Prodotto articolo9 = new Prodotto { Id = 9, NomeProdotto = "Apple Watch 44mm", Descrizione = "Cassa in Alluminio color Argento.Cinturino Sport Band Bianco.Taglia Regular.Touch screen.Sistema operativo incluso: watchOS 9", Immagine = "img/9.jpg", Prezzo = 489 };

            listaProdotti.Add(articolo1);
            listaProdotti.Add(articolo2);
            listaProdotti.Add(articolo3);
            listaProdotti.Add(articolo4);
            listaProdotti.Add(articolo5);
            listaProdotti.Add(articolo6);
            listaProdotti.Add(articolo7);
            listaProdotti.Add(articolo8);
            listaProdotti.Add(articolo9);
            return listaProdotti;
        }
            public static List<Prodotto> listaCarrello = new List<Prodotto>();

    }

    
}