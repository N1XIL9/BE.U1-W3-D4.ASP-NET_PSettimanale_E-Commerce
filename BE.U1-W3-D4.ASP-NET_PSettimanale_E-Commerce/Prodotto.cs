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

            Prodotto articolo1 = new Prodotto { Id = 1, NomeProdotto = "Apple Watch 7 44mm ", Descrizione = "Apple Watch Series 7 GPS + Cellular, 45 mm in acciaio inossidabile color Oro con Cinturino Sport Blu Abisso. Tipo di display: OLED, Risoluzione del display: 396 x 484 Pixel, Touch screen. Memoria flash: 32 GB. Wi-Fi. GPS (satellitare). Peso: 51,5 g. Impermeabile fino a: 50 m, Colore cinturino: Blu. Sistema operativo incluso: watchOS 8", Immagine = "img/1.jpg", Prezzo = 827 };
            Prodotto articolo2 = new Prodotto { Id = 2, NomeProdotto = "Apple Watch 6 40mm", Descrizione = "Smartwatch gps,touchscreen 1.57,microfono speaker,accelerometro,giroscopio,sensore di luce ambientale,cassa product(red) aluminio water resistant fino a 50 m", Immagine = "img/2.jpg", Prezzo = 489 };
            Prodotto articolo3 = new Prodotto { Id = 3, NomeProdotto = "Apple Watch Ultra 49mm ", Descrizione = "Cassa in Titanio color Argento.Cinturino Sport Band Bianco.Taglia Regular.Touch screen.Sistema operativo incluso: watchOS 9", Immagine = "img/13.jpg", Prezzo = 1189 };
            Prodotto articolo4 = new Prodotto { Id = 4, NomeProdotto = "Apple Watch se 2021 44mm", Descrizione = "Con il modello GPS rispondi a chiamate e messaggi dall’orologio\r\nIl display Retina always-on è quasi il 20% più ampio rispetto ai modelli Series 6: tutto è più semplice da vedere e da usare\r\nIl cristallo anteriore più robusto che un Apple Watch abbia mai avuto, resistenza alla polvere di grado IP6X e design a prova di nuotate\r\nMisura l’ossigeno nel sangue con un sensore e un’app all’avanguardia\r\nFai un ECG quando vuoi, dove vuoi\r\nNotifiche in caso di frequenza cardiaca troppo alta o troppo bassa, o di ritmo irregolare\r\nNuovi allenamenti Tai Chi e Pilates, e tantissimi altri fra cui Corsa, Yoga, Nuoto e Ballo\r\nCon Apple Watch misuri ogni giorno quanto ti muovi e controlli i tuoi progressi nell’app Fitness su iPhone\r\nSincronizza musica, podcast e audiolibri\r\nApple Watch Series 7 richiede iPhone 6s o successivo con iOS 15 o successivo", Immagine = "img/14.jpg", Prezzo = 389 };
            Prodotto articolo5 = new Prodotto { Id = 5, NomeProdotto = "Apple Watch 8 45mm", Descrizione = "Smartwatch gps,touchscreen 1.57,microfono speaker,accelerometro,giroscopio,sensore di luce ambientale,cassa product(red) aluminio water resistant fino a 50 m", Immagine = "img/5.jpg", Prezzo = 669 };
            Prodotto articolo6 = new Prodotto { Id = 6, NomeProdotto = "Apple Watch 7 44mm", Descrizione = "Smartwatch Apple Watch Series 7 con cassa in acciaio inossidabile color oro con Loop a maglia milanese - modello GPS + Cellular. Con il modello GPS + Cellular è possibile telefonare, inviare messaggi e trovare indicazioni stradali, il tutto senza telefono (Operatori supportati: Vodafone. Apple Watch e iPhone devono avere lo stesso operatore di telefonia mobile).Ascolta musica in streaming, podcast e audiolibri ovunque ti trovi e lascia il telefono a casa. Il display Retina always-on è quasi il 20% più grande rispetto ai modelli della Serie 6...", Immagine = "img/16.jpg", Prezzo = 649 };
            Prodotto articolo7 = new Prodotto { Id = 7, NomeProdotto = "Apple Watch 6 44mm", Descrizione = "Il futuro della salute è qui. Al tuo polso.\nControlla lossigeno nel sangue con un sensore e unapp rivoluzionari. Fai un ECG in qualsiasi momento, ovunque ti trovi. E tieni docchio tutti i parametri dei tuoi allenamenti su un display Retina always-on ancora più brillante. Con Apple Watch Series 6 una vita più sana, attiva e connessa è a portata di mano.\n\nOssigeno nel sangue Una boccata di pura innovazione.\nIl livello di ossigeno nel sangue è un indicatore basilare del tuo benessere generale. Ti aiuta a capire quanto ossigeno riceve il tuo corpo e se lo assorbe come dovrebbe. Apple Watch Series 6 ha un nuovo sensore e una nuova app che ti permettono di controllare i tuoi livelli di ossigeno nel sangue tutte le volte che vuoi, oltre a effettuare periodicamente delle misurazioni in background, giorno e notte.\n\nNuovo sensore. Nuove informazioni.\nIl nuovo Sensore Livelli O è composto da quattro gruppi di LED e quattro fotodiodi. È integrato nel cristallo posteriore completamente ridisegnato, e funziona insieme allapp Livelli O per determinare la quantità di ossigeno presente nel tuo sangue.\n\nProfondamente illuminante.\nI LED verdi, rossi e a infrarossi proiettano la loro luce sui vasi sanguigni del polso, mentre i fotodiodi misurano la quantità di luce riflessa. Algoritmi evoluti calcolano quindi il colore del sangue, che indica la quantità di ossigeno al suo interno.\n\nECG A portata di mano. Sempre, ovunque.", Immagine = "img/17.jpg", Prezzo = 621 };
            Prodotto articolo8 = new Prodotto { Id = 8, NomeProdotto = "Apple Watch Ultra 49mm", Descrizione = "SMARTWATCH APPLE WATCH ULTRA GPS + CELLULAR CASSA 49mm TITANIO CINTURINO OCEAN BIANCO", Immagine = "img/18.jpg", Prezzo = 1149 };
            Prodotto articolo9 = new Prodotto { Id = 9, NomeProdotto = "Apple Watch 8 45mm", Descrizione = "Cassa in Alluminio color Argento.Cinturino Sport Band Bianco.Taglia Regular.Touch screen.Sistema operativo incluso: watchOS 9", Immagine = "img/19.jpg", Prezzo = 889 };

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