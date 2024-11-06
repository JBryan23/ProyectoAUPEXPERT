namespace AUPExpert.Service.WebUI.ViewModels
{
    public sealed class QuestionISOViewModel
    {
        public string Pregunta { get; }
        public string RespuestaEsperada { get; }
        public string RecomendacionISO { get; }

        public QuestionISOViewModel(string pregunta, string respuestaEsperada, string recomendacionISO)
        {
            Pregunta = pregunta;
            RespuestaEsperada = respuestaEsperada;
            RecomendacionISO = recomendacionISO;
        }
    }
}
