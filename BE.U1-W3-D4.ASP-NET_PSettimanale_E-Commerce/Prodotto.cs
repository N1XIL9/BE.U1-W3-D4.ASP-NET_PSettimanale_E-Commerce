using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BE.U1_W3_D4.ASP_NET_PSettimanale_E_Commerce
{
    public class Prodotto
    {
        public string NomeProdotto { get; set; }

        public string Descrizione { get; set;}

        public string Immagine { get; set; }

        public double Prezzo { get; set; }

        public static List<Prodotto> GetProdotto()
        {
            List<Prodotto> listaProdotti = new List<Prodotto>();

            Prodotto articolo1 = new Prodotto { NomeProdotto = "Apple Watch 44mm - White", Descrizione = "Cassa in Alluminio color Argento.Cinturino Sport Band Bianco.Taglia Regular.Touch screen.Sistema operativo incluso: watchOS 9", Immagine = "img/1.png", Prezzo = 489 };
            Prodotto articolo2 = new Prodotto { NomeProdotto = "Apple Watch Series 8 GPS 45mm - Mezzanotte", Descrizione = "Cassa in Alluminio color Mezzanotte.Cinturino Sport Band nero.Taglia Regular.Touch screen.Sistema operativo incluso: watchOS 9", Immagine = "img/2.png", Prezzo = 389 };
            Prodotto articolo3 = new Prodotto { NomeProdotto = "Apple Watch Ultra 49mm - White", Descrizione = "Cassa in Titanio color Argento.Cinturino Sport Band Bianco.Taglia Regular.Touch screen.Sistema operativo incluso: watchOS 9", Immagine = "img/1.png", Prezzo = 1189 };
            Prodotto articolo4 = new Prodotto { NomeProdotto = "Apple Watch 44mm - White", Descrizione = "Cassa in Alluminio color Argento.Cinturino Sport Band Bianco.Taglia Regular.Touch screen.Sistema operativo incluso: watchOS 9", Immagine = "img/1.png", Prezzo = 489 };
            Prodotto articolo5 = new Prodotto { NomeProdotto = "Apple Watch 44mm - White", Descrizione = "Cassa in Alluminio color Argento.Cinturino Sport Band Bianco.Taglia Regular.Touch screen.Sistema operativo incluso: watchOS 9", Immagine = "img/1.png", Prezzo = 489 };
            Prodotto articolo6 = new Prodotto { NomeProdotto = "Apple Watch 44mm - White", Descrizione = "Cassa in Alluminio color Argento.Cinturino Sport Band Bianco.Taglia Regular.Touch screen.Sistema operativo incluso: watchOS 9", Immagine = "img/1.png", Prezzo = 489 };
            Prodotto articolo7 = new Prodotto { NomeProdotto = "Apple Watch 44mm - White", Descrizione = "Cassa in Alluminio color Argento.Cinturino Sport Band Bianco.Taglia Regular.Touch screen.Sistema operativo incluso: watchOS 9", Immagine = "img/1.png", Prezzo = 489 };
            Prodotto articolo8 = new Prodotto { NomeProdotto = "Apple Watch 44mm - White", Descrizione = "Cassa in Alluminio color Argento.Cinturino Sport Band Bianco.Taglia Regular.Touch screen.Sistema operativo incluso: watchOS 9", Immagine = "img/1.png", Prezzo = 489 };
            Prodotto articolo9 = new Prodotto { NomeProdotto = "Apple Watch 44mm - White", Descrizione = "Cassa in Alluminio color Argento.Cinturino Sport Band Bianco.Taglia Regular.Touch screen.Sistema operativo incluso: watchOS 9", Immagine = "img/1.png", Prezzo = 489 };

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

    }
}