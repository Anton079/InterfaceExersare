using InterfaceExersare;
using InterfaceExersare.repository;
using InterfaceExersare.services;

public class Program
{
    private static void Main(string[] args)
    {
        MasinaRepository repository = new MasinaRepository();

        //MasinaQueryService masinaQueryService = new MasinaQueryService(repository);

        //View view = new View(masinaQueryService);


        repository.SaveData();







    }
}