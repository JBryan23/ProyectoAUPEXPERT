namespace AUPExpert.Service.WebUI.ViewModels
{
    internal sealed class TaskInfoViewModel
    {
        public string Nombre { get; }
        public string Prioridad { get; }
        public string FlujoTrabajo { get; }

        public TaskInfoViewModel(string nombre, string prioridad, string flujoTrabajo)
        {
            Nombre = nombre;
            Prioridad = prioridad;
            FlujoTrabajo = flujoTrabajo;
        }
    }
}
