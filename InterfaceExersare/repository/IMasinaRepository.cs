using InterfaceExersare.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExersare.repository
{
    public interface IMasinaRepository
    {
        void Load();

        void Add(Masina masina);

        string GetFilePath();

        void SaveData();

        string ToSaveAll();

        List<Masina> getAll();


    }
}
