using SistemaExpertoAup.Controllers;

Console.WriteLine("Bienvenido al sistema experto de recomendaciones de ISO basado en la metodología ágil AUP.");
Console.Write("Por favor, ingrese la fase del proyecto (Inicio, Elaboración, Construcción, Transición): ");
string fase = Console.ReadLine();

BaseConocimiento baseConocimiento = new BaseConocimiento();
baseConocimiento.RecomendarISOInteractivo(fase);