public class Program
{
  public static void Main(string[] args)
  {
    bool isRunning = true;
    List<Station> stations = new List<Station>();
    List<Monitor> monitors = new List<Monitor>();

    while (isRunning)
    {
      Console.Clear(); // Limpa o console a cada loop
      Console.WriteLine("Escolha uma das opções:");
      Console.WriteLine("0 - Sair");
      Console.WriteLine("1 - Criar Nova Estação");
      Console.WriteLine("2 - Atualizar Estação");
      Console.WriteLine("3 - Remover Estação");
      Console.WriteLine("4 - Criar Monitor");
      Console.WriteLine("5 - Editar Monitor");

      string input = Console.ReadLine();

      switch (input)
      {
        case "0":
              Console.WriteLine("Saindo...");
              isRunning = false; // Sair do loop
              break;

        case "1":
              Console.WriteLine("UF da nova Estação:");]
              string uf = Console.ReadLine();
              Station s = new Station(uf);
              stations.Add(s);
              break;

        case "2":
              Console.WriteLine("Qual Estação deseja atualizar: ");
              ShowStations(stations);
              int stationIndex = int.Parse(Console.ReadLine());

              Console.WriteLine("Qual a nova temperatura: ");
              float newTemperature = float.Parse(Console.ReadLine());
              stations[stationIndex].setTemperature(newTemperature);     
              break;

        case "3":
              Console.WriteLine("Qual Estação deseja remover: ");
              ShowStations(stations);
              int stationsIndex = int.Parse(Console.ReadLine());

              stations.RemoveAt(stationsIndex);
              break;

        case "4":
              Console.WriteLine("Criando novo monitor...");
              Monitor m = new Monitor();
              monitors.Add(m);
        
              break;

        case "5":
              Console.WriteLine("Qual Monitor) deseja editar: ");
              ShowMonitors(monitors);
              int monitorIndex = int.Parse(Console.ReadLine());

              Console.WriteLine("De qual das Estações: ");
              ShowStations(stations);
              int stationIndex = int.Parse(Console.ReadLine());
        
              if(stations[stationIndex].ContainsObserver(monitors[monitorIndex]){
                stations[stationIndex].RemoveObserver(monitors[monitorIndex]);
              } else{
                stations[stationIndex].AddObserver(monitors[monitorIndex]);
              }
        
              break;
      
          default:
              Console.WriteLine("Opção inválida, tente novamente.");
              break;
      }

      if (isRunning)
      {
          Console.WriteLine("\nPressione qualquer tecla para continuar...");
          Console.ReadKey();
      }
    }
  }

  function ShowStations(List<Station> stations){
    int i = 0;
    foreach (Station station in stations){
      Console.WriteLine($"{i} - {station.UF}");
      i++
    }
  
    function ShowMonitors(List<Monitor> monitors){
      int i = 0;
      foreach (Monitor monitor in monitors){
        Console.WriteLine($"{i} - {monitor.GetHashCode()}");
        i++
      }
    }
}


