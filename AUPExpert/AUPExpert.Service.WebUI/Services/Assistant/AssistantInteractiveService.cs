using AUPExpert.Service.WebUI.ViewModels;

namespace AUPExpert.Service.WebUI.Services.Assistant
{
    internal sealed class AssistantInteractiveService
    {
        public List<QuestionISOViewModel> PreguntasParaFase { get; set; } = [];
        public QuestionISOViewModel PreguntaActual { get; set; }

        public Dictionary<string, int> PuntajesISO { get => _formatoPuntajesISO; }

        private Dictionary<string, int> _formatoPuntajesISO { get; set; }

        private readonly Dictionary<string, List<QuestionISOViewModel>> _preguntasInteractivas = new ()
        {
            { "inicio", new List<QuestionISOViewModel>
                {
                    new QuestionISOViewModel("¿El proyecto necesita un marco estructurado para definir procesos? (si/no)", "sí", "ISO/IEC 12207"),
                    new QuestionISOViewModel("¿Se requiere una guía clara para definir roles y responsabilidades (si/no)?", "sí", "ISO/IEC 12207"),
                    new QuestionISOViewModel("¿Se desea mejorar la calidad del ciclo de vida desde el inicio? (si/no)", "sí", "ISO/IEC 12207"),

                    new QuestionISOViewModel("¿El proyecto está enfocado en mejorar la gestión de servicios? (si/no)", "sí", "ISO/IEC 20000"),
                    new QuestionISOViewModel("¿Es necesario un sistema para gestionar solicitudes y problemas de servicio? (si/no)", "sí", "ISO/IEC 20000"),
                    new QuestionISOViewModel("¿Se requiere seguimiento de incidentes desde la fase inicial? (si/no)", "sí", "ISO/IEC 20000"),

                    new QuestionISOViewModel("¿La seguridad de la información es crítica en esta fase? (si/no)", "sí", "ISO/IEC 27001"),
                    new QuestionISOViewModel("¿Se necesita proteger datos confidenciales desde el inicio? (si/no)", "sí", "ISO/IEC 27001"),
                    new QuestionISOViewModel("¿Es importante implementar controles de acceso en esta etapa (si/no)?", "sí", "ISO/IEC 27001"),

                    new QuestionISOViewModel("¿Es fundamental asegurar la calidad del software? (si/no)", "sí", "ISO/IEC 25010"),
                    new QuestionISOViewModel("¿Se debe validar la usabilidad y eficiencia del software? (si/no)", "sí", "ISO/IEC 25010"),
                    new QuestionISOViewModel("¿Es crucial la confiabilidad del sistema? (si/no)", "sí", "ISO/IEC 25010"),

                    new QuestionISOViewModel("¿El proyecto involucra pequeñas empresas o equipos de desarrollo? (si/no)", "sí", "ISO/IEC 29110"),
                    new QuestionISOViewModel("¿Se requiere un marco simplificado para equipos pequeños? (si/no)", "sí", "ISO/IEC 29110"),
                    new QuestionISOViewModel("¿Es relevante optimizar recursos para empresas con bajo presupuesto? (si/no)", "sí", "ISO/IEC 29110")
                }
            },
            { "elaboracion", new List<QuestionISOViewModel>
                {
                    new QuestionISOViewModel("¿Es importante definir detalladamente los procesos de desarrollo? (si/no)", "sí", "ISO/IEC 12207"),
                    new QuestionISOViewModel("¿Se necesita una estructura clara para la planificación? (si/no)", "sí", "ISO/IEC 12207"),
                    new QuestionISOViewModel("¿El proyecto involucra múltiples etapas y documentación? (si/no)", "sí", "ISO/IEC 12207"),

                    new QuestionISOViewModel("¿La fase requiere un enfoque en la gestión de servicios? (si/no)", "sí", "ISO/IEC 20000"),
                    new QuestionISOViewModel("¿Es importante la continuidad del servicio en esta fase? (si/no)", "sí", "ISO/IEC 20000"),
                    new QuestionISOViewModel("¿Se necesita un marco para gestionar acuerdos de nivel de servicio? (si/no)", "sí", "ISO/IEC 20000"),

                    new QuestionISOViewModel("¿Se debe implementar una política de seguridad formal? (si/no)", "sí", "ISO/IEC 27001"),
                    new QuestionISOViewModel("¿La protección de activos es una prioridad? (si/no)", "sí", "ISO/IEC 27001"),
                    new QuestionISOViewModel("¿Es necesario garantizar la confidencialidad y la integridad? (si/no)", "sí", "ISO/IEC 27001"),

                    new QuestionISOViewModel("¿Es importante asegurar la funcionalidad del software? (si/no)", "sí", "ISO/IEC 25010"),
                    new QuestionISOViewModel("¿El rendimiento y eficiencia son cruciales? (si/no)", "sí", "ISO/IEC 25010"),
                    new QuestionISOViewModel("¿La mantenibilidad y compatibilidad son relevantes? (si/no)", "sí", "ISO/IEC 25010"),

                    new QuestionISOViewModel("¿Se deben seguir estándares específicos para proyectos pequeños? (si/no)", "sí", "ISO/IEC 29110"),
                    new QuestionISOViewModel("¿Se requiere un enfoque ágil y simplificado? (si/no)", "sí", "ISO/IEC 29110"),
                    new QuestionISOViewModel("¿La fase incluye necesidades específicas de pequeñas empresas? (si/no)", "sí", "ISO/IEC 29110")
                }
            },
            { "construccion", new List<QuestionISOViewModel>
                {
                    new QuestionISOViewModel("¿Se necesita un marco para el proceso de desarrollo? (si/no)", "sí", "ISO/IEC 12207"),
                    new QuestionISOViewModel("¿El proyecto incluye varias fases de integración? (si/no)", "sí", "ISO/IEC 12207"),
                    new QuestionISOViewModel("¿Se requiere un proceso claro para el despliegue del software? (si/no)", "sí", "ISO/IEC 12207"),

                    new QuestionISOViewModel("¿Es necesario un sistema de gestión de cambios? (si/no)", "sí", "ISO/IEC 20000"),
                    new QuestionISOViewModel("¿Se requiere control sobre la gestión de la infraestructura? (si/no)", "sí", "ISO/IEC 20000"),
                    new QuestionISOViewModel("¿Es importante garantizar la disponibilidad continua del servicio? (si/no)", "sí", "ISO/IEC 20000"),

                    new QuestionISOViewModel("¿La seguridad de la información debe estar controlada? (si/no)", "sí", "ISO/IEC 27001"),
                    new QuestionISOViewModel("¿Es fundamental proteger datos sensibles? (si/no)", "sí", "ISO/IEC 27001"),
                    new QuestionISOViewModel("¿Se deben implementar medidas de recuperación ante incidentes? (si/no)", "sí", "ISO/IEC 27001"),

                    new QuestionISOViewModel("¿Es relevante garantizar la robustez del software? (si/no)", "sí", "ISO/IEC 25010"),
                    new QuestionISOViewModel("¿Se debe evaluar el rendimiento y eficiencia en esta fase? (si/no)", "sí", "ISO/IEC 25010"),
                    new QuestionISOViewModel("¿Es fundamental la compatibilidad del software? (si/no)", "sí", "ISO/IEC 25010"),

                    new QuestionISOViewModel("¿Aplica mejor un enfoque simplificado para el equipo? (si/no)", "sí", "ISO/IEC 29110"),
                    new QuestionISOViewModel("¿Se necesita optimizar recursos en la construcción? (si/no)", "sí", "ISO/IEC 29110"),
                    new QuestionISOViewModel("¿El proyecto es para una pequeña empresa? (si/no)", "sí", "ISO/IEC 29110")
                }
            },
            { "transicion", new List<QuestionISOViewModel>
                {
                    new QuestionISOViewModel("¿Es importante gestionar el cambio de software? (si/no)", "sí", "ISO/IEC 12207"),
                    new QuestionISOViewModel("¿Se requiere soporte para el despliegue del producto? (si/no)", "sí", "ISO/IEC 12207"),
                    new QuestionISOViewModel("¿Es relevante la documentación para el mantenimiento futuro? (si/no)", "sí", "ISO/IEC 12207"),

                    new QuestionISOViewModel("¿Es necesario asegurar la entrega continua de servicios? (si/no)", "sí", "ISO/IEC 20000"),
                    new QuestionISOViewModel("¿Se necesita apoyo para el cambio de servicios? (si/no)", "sí", "ISO/IEC 20000"),
                    new QuestionISOViewModel("¿Es crucial gestionar solicitudes y problemas en la transición? (si/no)", "sí", "ISO/IEC 20000"),

                    new QuestionISOViewModel("¿La seguridad sigue siendo una prioridad? (si/no)", "sí", "ISO/IEC 27001"),
                    new QuestionISOViewModel("¿Es necesario un control de acceso para los usuarios? (si/no)", "sí", "ISO/IEC 27001"),
                    new QuestionISOViewModel("¿Se debe proteger la integridad de los datos en la transición? (si/no)", "sí", "ISO/IEC 27001"),

                    new QuestionISOViewModel("¿La calidad del producto es esencial en la entrega? (si/no)", "sí", "ISO/IEC 25010"),
                    new QuestionISOViewModel("¿Se requiere verificación final de rendimiento? (si/no)", "sí", "ISO/IEC 25010"),
                    new QuestionISOViewModel("¿La mantenibilidad y soporte son relevantes? (si/no)", "sí", "ISO/IEC 25010"),

                    new QuestionISOViewModel("¿El marco debe estar adaptado para una pequeña empresa? (si/no)", "sí", "ISO/IEC 29110"),
                    new QuestionISOViewModel("¿Es importante un enfoque simplificado en esta fase? (si/no)", "sí", "ISO/IEC 29110"),
                    new QuestionISOViewModel("¿Se deben optimizar recursos para la transición? (si/no)", "sí", "ISO/IEC 29110")
                }
            }
        };

        public void FiltrarPreguntasInteractivasSegunFase(string fase)
        {
            fase = fase.Replace("ó", "o");
            if (_preguntasInteractivas.TryGetValue(fase.ToLower(), out List<QuestionISOViewModel> preguntas))
            {
                PreguntasParaFase = preguntas.ToList();
                _formatoPuntajesISO = new()
                {
                    { "ISO/IEC 12207", 0 },
                    { "ISO/IEC 20000", 0 },
                    { "ISO/IEC 25010", 0 },
                    { "ISO/IEC 27001", 0 },
                    { "ISO/IEC 29110", 0 }
                };
            }
        }

        public string? ObtenerPregunta()
        {
            QuestionISOViewModel? pregunta = PreguntasParaFase.FirstOrDefault();
            if (pregunta is not null)
            {
                PreguntaActual = pregunta;
                PreguntasParaFase.Remove(pregunta);
                return pregunta.Pregunta;
            }
            return pregunta?.Pregunta;
        }

        public void AnalizarRespuesta(string respuesta)
        {
            if (respuesta.Equals(PreguntaActual.RespuestaEsperada) || respuesta.Equals("si"))
            {
                _formatoPuntajesISO[PreguntaActual.RecomendacionISO] ++;
            }
        }
    }
}
