using InterfaceExersare.models;
using InterfaceExersare.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExersare
{
    public class View
    {
        private IMasinaQueryService _masinaQueryService;

        public View(IMasinaQueryService masinaQueryService)
        {
            _masinaQueryService = masinaQueryService; 
        }

        public void Meniu()
        {
            Console.WriteLine("Apasa tasta 1 pentru a vedea toate masinile");
        }

        public void play()
        {
            bool running = true;
            while (running)
            {
                Meniu();
                string alegere = Console.ReadLine();

                switch(alegere)
                {
                    case "1":
                        AfisareMasini();
                        break;


                }
            }
        }

        public void AfisareMasini()
        {

            if (this._masinaQueryService.getAll() == null)
            {
                Console.WriteLine("Nu avem masini");
            }
            else
            {

                foreach(Masina m in this._masinaQueryService.getAll())
                {
                    Console.WriteLine(m);
                }
            }
        }
    }
}
