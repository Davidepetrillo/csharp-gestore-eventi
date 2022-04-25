using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class Evento
    {
        internal string titoloEvento;
        internal DateTime dataDellEvento;
        internal int capienzaMassimaEvento;
        internal int numeroPostiPrenotati;

        // costruttore

        public Evento(string titoloEvento, DateTime dataDellEvento, int capienzaMassimaEvento)
        {
            if (dataDellEvento < DateTime.Now)
            {
                throw new InvalidDataException("La data dell'evento è precedente alla data di oggi.");
            }
            this.dataDellEvento = dataDellEvento;

            if (titoloEvento == null)
            {
                throw new ArgumentNullException("Mi dispiace ma non hai inserito un titolo all'evento");
            }
            this.titoloEvento = titoloEvento;

            if(capienzaMassimaEvento < 0)
            {
                throw new Exception("Mi dispiace ma la capienza dei posti per l'evento non può essere negativa");
            }
            this.capienzaMassimaEvento = capienzaMassimaEvento;

            this.numeroPostiPrenotati = 0;
        }

        // Getter e setter titoloEvento
        public string GetTitoloEvento(string nuovoTitoloEvento)
        {
            return nuovoTitoloEvento;
        }
        public string SetTitoloEvento(string nuovoTitoloEvento)
        {
            return nuovoTitoloEvento;
        }

        // Getter e setter dataDellEvento
        public string GetDataDellEvento(string nuovaDataDellEvento)
        {
            return nuovaDataDellEvento;
        }
        public string SetDataDellEvento(string nuovaDataDellEvento)
        {
            return nuovaDataDellEvento;
        }

        // Getter capienzaMassimaEvento
        public int GetCapienzaMassimaEvento(int nuovaCapienzaMassimaEvento)
        {
            return nuovaCapienzaMassimaEvento;
        }

        // Getter numeroPostiPrenotati
        public int GetNumeroPostiPrenotati (int nuovoNumeroPostiPrenotati)
        {
            return nuovoNumeroPostiPrenotati;
        }

        public void PrenotaPosti(int numeroPostiPrenotatiDallUtente)
        {
            numeroPostiPrenotati = numeroPostiPrenotati + numeroPostiPrenotatiDallUtente;
            Console.WriteLine($"Numero di posti prenotati: {numeroPostiPrenotati}");
            Console.WriteLine($"Numero di posti disponibili: {capienzaMassimaEvento - numeroPostiPrenotati}");
        }

        public void DisdiciPosti(int numeroPostiDisdettiDallUtente)
        {
            numeroPostiPrenotati = numeroPostiPrenotati - numeroPostiDisdettiDallUtente;
            Console.WriteLine($"Numero di posti prenotati: {numeroPostiPrenotati}");
            Console.WriteLine($"Numero di posti disponibili: {capienzaMassimaEvento - numeroPostiPrenotati}");
        }


        public virtual void ToString()
        {
            Console.WriteLine();
            Console.WriteLine("--- Evento ---");
            Console.WriteLine();
            Console.WriteLine($"{dataDellEvento} - {titoloEvento}");
            Console.WriteLine();
        }
    }
}
