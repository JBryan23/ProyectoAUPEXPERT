using AUPExpert.Service.WebUI.ViewModels;

namespace AUPExpert.Service.WebUI.Services.Assistant
{
    internal sealed class InferenceIngineService
    {
        private readonly KnowLedgeService _knowLedgeService;
        private IList<KeyValuePair<string, int>> ISORecomendadas {  get; set; }
        private IList<TaskInfoViewModel> TareasRecomendadas {  get; set; }
        public InferenceIngineService(KnowLedgeService knowLedgeService)
        {
            _knowLedgeService = knowLedgeService ?? throw new ArgumentNullException(nameof(knowLedgeService));
        }

        internal string RealizarInferencia(Dictionary<string, int> puntajesISO)
        {
            string recomendacion = string.Empty;
            // Encontrar la ISO recomendada
            ISORecomendadas = puntajesISO.Where(x=>x.Value > 2).OrderByDescending(x => x.Value).ToList();

            foreach (var iso in ISORecomendadas)
            {
                //var metaData = (iso.Value > 2) ? $"[{ISORecomendadas.IndexOf(iso) + 1}][100%]": $"[{ISORecomendadas.IndexOf(iso) + 1}][66.66%]";
                recomendacion += $" '{iso.Key}'";
            }
            recomendacion += ".";
            return recomendacion;
        }

        public string? FiltrarTareas(string fase)
        {
            string? error = null;
            IList<TaskInfoViewModel> tareasSeleccionadas = [];
            foreach (var iso in ISORecomendadas)
            {
                if (_knowLedgeService.Conocimiento.TryGetValue(iso.Key, out Dictionary<string, List<TaskInfoViewModel>> fasesTareas))
                {
                    if (fasesTareas.TryGetValue(fase, out List<TaskInfoViewModel> tareas))
                    {
                        foreach (var tarea in tareas)
                        {
                            tareasSeleccionadas.Add(tarea);
                        }
                        TareasRecomendadas = tareasSeleccionadas;
                    }
                    else
                    {
                        error += $"No se encontraron tareasSeleccionadas para la fase de {fase} en {iso}. ";
                    }
                }
                else
                {
                    error += "No se encontraron tareasSeleccionadas para esta ISO.";
                }
            }
            return error;
        }

        internal TaskInfoViewModel? ObtenerTarea()
        {
            TaskInfoViewModel? tarea = TareasRecomendadas.FirstOrDefault();
            if (tarea is not null)
            {
                TareasRecomendadas.Remove(tarea);
            }
            return tarea;
        }
    }
}
