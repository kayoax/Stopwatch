using System.Collections.Generic;

static void Menu(){
  Console.Clear();
  Console.WriteLine("S - Segundos => 13s = 13 segundos");
  Console.WriteLine("M - Minutos => 1m = 1 minuto");
  Console.WriteLine("X - Sair");
  Console.WriteLine("Selecione uma opção: ");
  
  string data = Console.ReadLine()!.ToLower();
  if (data == "x") System.Environment.Exit(0);
  char type = char.Parse(data.Substring(data.Length - 1, 1));
  int time = int.Parse(data.Substring(0, data.Length - 1));
  int multiplier = 1;
  
  if (type == 'm') multiplier = 60;

  Start(time * multiplier);
}

Menu();

static void PreStart(){
  Console.Clear();
  Console.WriteLine("Preparar..");
  Thread.Sleep(1000);
  Console.Clear();
  Console.WriteLine("Apontar..");
  Thread.Sleep(1000);
  Console.Clear();
  Console.WriteLine("Começou!");
  Thread.Sleep(1000);
}

static void Start(int time){
  PreStart();

  while(time > 0){
    Console.Clear();
    Console.WriteLine(time);
    Thread.Sleep(1000);
    time--;
  }

  Console.Clear();
  Console.WriteLine("Stopwatch finalizado!");
  Thread.Sleep(2500);
  Menu();
}