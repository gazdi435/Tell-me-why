using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kutyák
{
    internal class Kutyak
    {
        int id;
        string kutyaFajtaja;
        string kutyaNeve;
        int kutyaEletkora;
        string vizsgalatIdeje;

        public Kutyak(int id, string kutyaFajtaja, string kutyaNeve, int kutyaEletkora, string vizsgalatIdeje)
        {
            id = this.id;
            kutyaFajtaja = this.kutyaFajtaja;
            kutyaNeve = this.kutyaNeve;
            kutyaEletkora = this.kutyaEletkora;
            vizsgalatIdeje = this.vizsgalatIdeje;
        }

        static public void listabaRak(List<Kutyak> lista) 
        {
            Dictionary<int, string> nevek = new Dictionary<int, string>();
            Dictionary<int, string> fajtak = new Dictionary<int, string>();
            List<List<string>> kutyak = new List<List<string>>();

            /*
            OpenFileDialog ODnevekMentes = new OpenFileDialog();
            ODnevekMentes.ShowDialog();
            //File.ReadAllLines(nev).ToList().ForEach(x => lista.Add(new Kutyak(Convert.ToInt32(x.Split(';')[0]), x.Split(';')[1], x.Split(';')[2], Convert.ToInt32(x.Split(';')[3]), x.Split(';')[4])));
            File.ReadAllLines(ODnevekMentes.FileName).ToList().ForEach(x => nevek.Add(Convert.ToInt32(x.Split(';')[0]), x.Split(';')[1]));
           
            
            OpenFileDialog ODfajtakMentes = new OpenFileDialog();
            ODfajtakMentes.ShowDialog();
            File.ReadAllLines(ODfajtakMentes.FileName).ToList().ForEach(x => fajtak.Add(Convert.ToInt32(x.Split(';')[0]), x.Split(';')[1]));

            OpenFileDialog ODKutyak = new OpenFileDialog();
            ODKutyak.ShowDialog();
            File.ReadAllLines(ODKutyak.FileName).ToList().ForEach(x => x.Split(';').ToList().ForEach(y => kutyak.Add(y))); */

            File.ReadAllLines("C:\\Users\\gazdag.zsolt\\Downloads\\KutyaNevek.csv").Skip(1).ToList().ForEach(x => nevek.Add(Convert.ToInt32(x.Split(';')[0]), x.Split(';')[1]));
            File.ReadAllLines("C:\\Users\\gazdag.zsolt\\Downloads\\KutyaFajtak.csv").Skip(1).ToList().ForEach(x => fajtak.Add(Convert.ToInt32(x.Split(';')[0]), x.Split(';')[1]));
            File.ReadAllLines("C:\\Users\\gazdag.zsolt\\Downloads\\Kutyak.csv").Skip(1).ToList().ForEach(x => kutyak.Add(x.Split(';').ToList()));


            foreach (var kutya in kutyak)
            {
                lista.Add(new Kutyak(Convert.ToInt32(kutya[0]), fajtak[Convert.ToInt32(kutya[1])], nevek[Convert.ToInt32(kutya[2])], Convert.ToInt32(kutya[3]), kutya[4]));
            }



        }

        public int Id { get => id; set => id = value; }
        public string KutyaFajtaja { get => kutyaFajtaja; set => kutyaFajtaja = value; }
        public string KutyaNeve { get => kutyaNeve; set => kutyaNeve = value; }
        public int KutyaEletkora { get => kutyaEletkora; set => kutyaEletkora = value; }
        public string VizsgalatIdeje { get => vizsgalatIdeje; set => vizsgalatIdeje = value; }
    }
}
