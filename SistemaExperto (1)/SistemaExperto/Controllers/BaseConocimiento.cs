using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaExpertoAup.Controllers
{
    public class BaseConocimiento
    {
        private Dictionary<string, List<QuestionISO>> _fasePreguntas = new Dictionary<string, List<QuestionISO>>()
        {
            { "inicio", new List<QuestionISO>
                {
                    new QuestionISO("¿El proyecto necesita un marco estructurado para definir procesos? (si/no)", "sí", "ISO/IEC 12207"),
                    new QuestionISO("¿Se requiere una guía clara para definir roles y responsabilidades (si/no)?", "sí", "ISO/IEC 12207"),
                    new QuestionISO("¿Se desea mejorar la calidad del ciclo de vida desde el inicio? (si/no)", "sí", "ISO/IEC 12207"),

                    new QuestionISO("¿El proyecto está enfocado en mejorar la gestión de servicios? (si/no)", "sí", "ISO/IEC 20000"),
                    new QuestionISO("¿Es necesario un sistema para gestionar solicitudes y problemas de servicio? (si/no)", "sí", "ISO/IEC 20000"),
                    new QuestionISO("¿Se requiere seguimiento de incidentes desde la fase inicial? (si/no)", "sí", "ISO/IEC 20000"),

                    new QuestionISO("¿La seguridad de la información es crítica en esta fase? (si/no)", "sí", "ISO/IEC 27001"),
                    new QuestionISO("¿Se necesita proteger datos confidenciales desde el inicio? (si/no)", "sí", "ISO/IEC 27001"),
                    new QuestionISO("¿Es importante implementar controles de acceso en esta etapa (si/no)?", "sí", "ISO/IEC 27001"),

                    new QuestionISO("¿Es fundamental asegurar la calidad del software? (si/no)", "sí", "ISO/IEC 25010"),
                    new QuestionISO("¿Se debe validar la usabilidad y eficiencia del software? (si/no)", "sí", "ISO/IEC 25010"),
                    new QuestionISO("¿Es crucial la confiabilidad del sistema? (si/no)", "sí", "ISO/IEC 25010"),

                    new QuestionISO("¿El proyecto involucra pequeñas empresas o equipos de desarrollo (si/no)?", "sí", "ISO/IEC 29110"),
                    new QuestionISO("¿Se requiere un marco simplificado para equipos pequeños? (si/no)", "sí", "ISO/IEC 29110"),
                    new QuestionISO("¿Es relevante optimizar recursos para empresas con bajo presupuesto (si/no)? (si/no)", "sí", "ISO/IEC 29110")
                }
            },
            { "elaboracion", new List<QuestionISO>
                {
                    new QuestionISO("¿Es importante definir detalladamente los procesos de desarrollo? (si/no)", "sí", "ISO/IEC 12207"),
                    new QuestionISO("¿Se necesita una estructura clara para la planificación? (si/no)", "sí", "ISO/IEC 12207"),
                    new QuestionISO("¿El proyecto involucra múltiples etapas y documentación? (si/no)", "sí", "ISO/IEC 12207"),

                    new QuestionISO("¿La fase requiere un enfoque en la gestión de servicios? (si/no)", "sí", "ISO/IEC 20000"),
                    new QuestionISO("¿Es importante la continuidad del servicio en esta fase? (si/no)", "sí", "ISO/IEC 20000"),
                    new QuestionISO("¿Se necesita un marco para gestionar acuerdos de nivel de servicio? (si/no)", "sí", "ISO/IEC 20000"),

                    new QuestionISO("¿Se debe implementar una política de seguridad formal? (si/no)", "sí", "ISO/IEC 27001"),
                    new QuestionISO("¿La protección de activos es una prioridad? (si/no)", "sí", "ISO/IEC 27001"),
                    new QuestionISO("¿Es necesario garantizar la confidencialidad y la integridad? (si/no)", "sí", "ISO/IEC 27001"),

                    new QuestionISO("¿Es importante asegurar la funcionalidad del software? (si/no)", "sí", "ISO/IEC 25010"),
                    new QuestionISO("¿El rendimiento y eficiencia son cruciales? (si/no)", "sí", "ISO/IEC 25010"),
                    new QuestionISO("¿La mantenibilidad y compatibilidad son relevantes? (si/no)", "sí", "ISO/IEC 25010"),

                    new QuestionISO("¿Se deben seguir estándares específicos para proyectos pequeños? (si/no)", "sí", "ISO/IEC 29110"),
                    new QuestionISO("¿Se requiere un enfoque ágil y simplificado? (si/no)", "sí", "ISO/IEC 29110"),
                    new QuestionISO("¿La fase incluye necesidades específicas de pequeñas empresas? (si/no)", "sí", "ISO/IEC 29110")
                }
            },
            { "construccion", new List<QuestionISO>
                {
                    new QuestionISO("¿Se necesita un marco para el proceso de desarrollo? (si/no)", "sí", "ISO/IEC 12207"),
                    new QuestionISO("¿El proyecto incluye varias fases de integración? (si/no)", "sí", "ISO/IEC 12207"),
                    new QuestionISO("¿Se requiere un proceso claro para el despliegue del software? (si/no)", "sí", "ISO/IEC 12207"),

                    new QuestionISO("¿Es necesario un sistema de gestión de cambios? (si/no)", "sí", "ISO/IEC 20000"),
                    new QuestionISO("¿Se requiere control sobre la gestión de la infraestructura? (si/no)", "sí", "ISO/IEC 20000"),
                    new QuestionISO("¿Es importante garantizar la disponibilidad continua del servicio? (si/no)", "sí", "ISO/IEC 20000"),

                    new QuestionISO("¿La seguridad de la información debe estar controlada? (si/no)", "sí", "ISO/IEC 27001"),
                    new QuestionISO("¿Es fundamental proteger datos sensibles? (si/no)", "sí", "ISO/IEC 27001"),
                    new QuestionISO("¿Se deben implementar medidas de recuperación ante incidentes? (si/no)", "sí", "ISO/IEC 27001"),

                    new QuestionISO("¿Es relevante garantizar la robustez del software? (si/no)", "sí", "ISO/IEC 25010"),
                    new QuestionISO("¿Se debe evaluar el rendimiento y eficiencia en esta fase? (si/no)", "sí", "ISO/IEC 25010"),
                    new QuestionISO("¿Es fundamental la compatibilidad del software? (si/no)", "sí", "ISO/IEC 25010"),

                    new QuestionISO("¿Aplica mejor un enfoque simplificado para el equipo? (si/no)", "sí", "ISO/IEC 29110"),
                    new QuestionISO("¿Se necesita optimizar recursos en la construcción? (si/no)", "sí", "ISO/IEC 29110"),
                    new QuestionISO("¿El proyecto es para una pequeña empresa? (si/no)", "sí", "ISO/IEC 29110")
                }
            },
            { "transicion", new List<QuestionISO>
                {
                    new QuestionISO("¿Es importante gestionar el cambio de software? (si/no)", "sí", "ISO/IEC 12207"),
                    new QuestionISO("¿Se requiere soporte para el despliegue del producto? (si/no)", "sí", "ISO/IEC 12207"),
                    new QuestionISO("¿Es relevante la documentación para el mantenimiento futuro? (si/no)", "sí", "ISO/IEC 12207"),

                    new QuestionISO("¿Es necesario asegurar la entrega continua de servicios? (si/no)", "sí", "ISO/IEC 20000"),
                    new QuestionISO("¿Se necesita apoyo para el cambio de servicios? (si/no)", "sí", "ISO/IEC 20000"),
                    new QuestionISO("¿Es crucial gestionar solicitudes y problemas en la transición? (si/no)", "sí", "ISO/IEC 20000"),

                    new QuestionISO("¿La seguridad sigue siendo una prioridad? (si/no)", "sí", "ISO/IEC 27001"),
                    new QuestionISO("¿Es necesario un control de acceso para los usuarios? (si/no)", "sí", "ISO/IEC 27001"),
                    new QuestionISO("¿Se debe proteger la integridad de los datos en la transición? (si/no)", "sí", "ISO/IEC 27001"),

                    new QuestionISO("¿La calidad del producto es esencial en la entrega? (si/no)", "sí", "ISO/IEC 25010"),
                    new QuestionISO("¿Se requiere verificación final de rendimiento? (si/no)", "sí", "ISO/IEC 25010"),
                    new QuestionISO("¿La mantenibilidad y soporte son relevantes? (si/no)", "sí", "ISO/IEC 25010"),

                    new QuestionISO("¿El marco debe estar adaptado para una pequeña empresa? (si/no)", "sí", "ISO/IEC 29110"),
                    new QuestionISO("¿Es importante un enfoque simplificado en esta fase? (si/no)", "sí", "ISO/IEC 29110"),
                    new QuestionISO("¿Se deben optimizar recursos para la transición? (si/no)", "sí", "ISO/IEC 29110")
                }
            }
        };

        private Dictionary<string, Dictionary<string, List<TaskInfo>>> _isoTareas = new Dictionary<string, Dictionary<string, List<TaskInfo>>>
        {
            {
                "ISO/IEC 12207", new Dictionary<string, List<TaskInfo>>
                {
                    {
                        "inicio", new List<TaskInfo>
                        {
                            //Proridad alta 
                            new TaskInfo("Identificación de los interesados clave", "Alta", "Planificación"),
                            new TaskInfo("Definición de los objetivos del proyecto", "Alta", "Planificación"),
                            new TaskInfo("Establecimiento del alcance inicial del proyecto", "Alta", "Planificación"),
                            new TaskInfo("Revisión de los requisitos del cliente", "Alta", "Análisis"),
                            new TaskInfo("Análisis de viabilidad", "Alta", "Análisis"),
                            new TaskInfo("Definición de restricciones del proyecto", "Alta", "Planificación"),
                            new TaskInfo("Evaluación de riesgos iniciales", "Alta", "Análisis"),
                            new TaskInfo("Creación de un cronograma preliminar", "Alta", "Planificación"),
                            new TaskInfo("Asignación de recursos iniciales", "Alta", "Planificación"),
                            new TaskInfo("Aprobación de la fase de inicio por los stakeholders", "Alta", "Planificación"),
                            // Prioridad Media
                            new TaskInfo("Análisis de tecnologías viables", "Media", "Análisis"),
                            new TaskInfo("Revisión y validación de requisitos con usuarios", "Media", "Análisis"),
                            new TaskInfo("Creación del backlog inicial", "Media", "Planificación"),
                            new TaskInfo("Establecimiento de criterios de aceptación iniciales", "Media", "Análisis"),
                            new TaskInfo("Identificación de hitos clave", "Media", "Planificación"),
                            new TaskInfo("Selección de herramientas de gestión de proyectos", "Media", "Planificación"),
                            new TaskInfo("Definición de métricas de éxito", "Media", "Análisis"),
                            new TaskInfo("Evaluación de habilidades del equipo", "Media", "Análisis"),
                            new TaskInfo("Identificación de dependencias críticas", "Media", "Análisis"),
                            new TaskInfo("Definición de roles y responsabilidades", "Media", "Planificación"),

                            // Prioridad Baja
                            new TaskInfo("Documentación del alcance inicial", "Baja", "Documentación"),
                            new TaskInfo("Definición de un plan de comunicación", "Baja", "Planificación"),
                            new TaskInfo("Definición de políticas de calidad", "Baja", "Análisis"),
                            new TaskInfo("Análisis preliminar de costes", "Baja", "Análisis"),
                            new TaskInfo("Definición del entorno de desarrollo", "Baja", "Desarrollo"),
                            new TaskInfo("Evaluación de la compatibilidad con otros sistemas", "Baja", "Análisis"),
                            new TaskInfo("Creación de prototipos iniciales", "Baja", "Diseño"),
                            new TaskInfo("Planificación de sprints iniciales", "Baja", "Planificación"),
                            new TaskInfo("Definición de requisitos de soporte técnico", "Baja", "Soporte"),
                            new TaskInfo("Configuración de control de versiones", "Baja", "Desarrollo"),

                        }
                    },
                    {
                        "elaboracion", new List<TaskInfo>
                        {
                            // Fase de Elaboración          
                            // Prioridad Alta
                            new TaskInfo("Refinamiento de requisitos", "Alta", "Análisis"),
                            new TaskInfo("Validación de casos de uso", "Alta", "Pruebas"),
                            new TaskInfo("Diseño detallado de la arquitectura", "Alta", "Diseño"),
                            new TaskInfo("Evaluación de atributos de calidad", "Alta", "Análisis"),
                            new TaskInfo("Análisis de impacto de requisitos", "Alta", "Análisis"),
                            new TaskInfo("Desarrollo de prototipo evolutivo", "Alta", "Diseño"),
                            new TaskInfo("Diseño de módulos críticos", "Alta", "Diseño"),
                            new TaskInfo("Planificación de pruebas de integración", "Alta", "Pruebas"),
                            new TaskInfo("Estrategias de seguridad iniciales", "Alta", "Análisis"),
                            new TaskInfo("Definición de interfaces detalladas", "Alta", "Diseño"),

                            // Prioridad Media
                            new TaskInfo("Implementación de pruebas de rendimiento", "Media", "Pruebas"),
                            new TaskInfo("Optimización para escalabilidad", "Media", "Diseño"),
                            new TaskInfo("Revisión de interoperabilidad", "Media", "Análisis"),
                            new TaskInfo("Refinamiento de casos complejos", "Media", "Análisis"),
                            new TaskInfo("Gestión de errores y excepciones", "Media", "Análisis"),
                            new TaskInfo("Aprobación final de arquitectura", "Media", "Planificación"),
                            new TaskInfo("Evaluación de mantenibilidad", "Media", "Análisis"),
                            new TaskInfo("Desarrollo del modelo de datos", "Media", "Diseño"),
                            new TaskInfo("Estrategias de portabilidad", "Media", "Análisis"),
                            new TaskInfo("Estrategia de recuperación", "Media", "Planificación"),

                            // Prioridad Baja
                            new TaskInfo("Pruebas de seguridad iniciales", "Baja", "Pruebas"),
                            new TaskInfo("Validación del modelo de usabilidad", "Baja", "Pruebas"),
                            new TaskInfo("Capacidad de integración continua", "Baja", "Desarrollo"),
                            new TaskInfo("Resiliencia ante fallos", "Baja", "Pruebas"),
                            new TaskInfo("Sistema de monitoreo inicial", "Baja", "Implementación"),
                            new TaskInfo("Refinamiento del modelo de datos físico", "Baja", "Diseño"),
                            new TaskInfo("Gestión de versiones", "Baja", "Desarrollo"),
                            new TaskInfo("Accesibilidad del sistema", "Baja", "Pruebas"),
                            new TaskInfo("Validación de diseño de interfaces", "Baja", "Pruebas"),
                            new TaskInfo("Evaluación de modularidad", "Baja", "Análisis"),

                        }
                    },
                    {
                        "construccion", new List<TaskInfo>
                        {
                            // Fase de Construcción
                            // Prioridad Alta
                            new TaskInfo("Implementación de módulos clave", "Alta", "Desarrollo"),
                            new TaskInfo("Desarrollo de la base de datos", "Alta", "Desarrollo"),
                            new TaskInfo("Codificación de interfaz de usuario", "Alta", "Desarrollo"),
                            new TaskInfo("Pruebas unitarias", "Alta", "Pruebas"),
                            new TaskInfo("Integración continua", "Alta", "Desarrollo"),
                            new TaskInfo("Optimización de rendimiento", "Alta", "Desarrollo"),
                            new TaskInfo("Implementación de lógica de negocio", "Alta", "Desarrollo"),
                            new TaskInfo("Codificación de algoritmos específicos", "Alta", "Desarrollo"),
                            new TaskInfo("Configuración de entorno de pruebas", "Alta", "Pruebas"),
                            new TaskInfo("Integración de la base de datos", "Alta", "Desarrollo"),

                            // Prioridad Media
                            new TaskInfo("Ajuste de interfaz gráfica", "Media", "Desarrollo"),
                            new TaskInfo("Validaciones de entrada", "Media", "Desarrollo"),
                            new TaskInfo("Generación de informes de salida", "Media", "Desarrollo"),
                            new TaskInfo("Documentación de código fuente", "Media", "Documentación"),
                            new TaskInfo("Automatización de pruebas", "Media", "Pruebas"),
                            new TaskInfo("Revisión de seguridad", "Media", "Pruebas"),
                            new TaskInfo("Integración con sistemas externos", "Media", "Desarrollo"),
                            new TaskInfo("Desarrollo de herramientas de auditoría", "Media", "Desarrollo"),
                            new TaskInfo("Optimización de almacenamiento", "Media", "Desarrollo"),
                            new TaskInfo("Gestión de fallos", "Media", "Desarrollo"),

                            // Prioridad Baja
                            new TaskInfo("Revisión de políticas de seguridad", "Baja", "Documentación"),
                            new TaskInfo("Pruebas de penetración", "Baja", "Pruebas"),
                            new TaskInfo("Monitoreo de transacciones", "Baja", "Implementación"),
                            new TaskInfo("Verificación de resiliencia", "Baja", "Pruebas"),
                            new TaskInfo("Auditoría de actividades", "Baja", "Soporte"),
                            new TaskInfo("Capacitación en seguridad", "Baja", "Soporte"),
                            new TaskInfo("Implementación de backups", "Baja", "Implementación"),
                            new TaskInfo("Cumplimiento de normativas de seguridad", "Baja", "Documentación"),
                            new TaskInfo("Documentación técnica", "Baja", "Documentación"),
                            new TaskInfo("Optimización de acceso a datos", "Baja", "Desarrollo"),
                        }
                    },
                    {
                        "Transicion", new List<TaskInfo>
                        {
                            // Agregar tareas para la fase de transición
                            // Prioridad Alta
                            new TaskInfo("Despliegue en producción", "Alta", "Implementación"),
                            new TaskInfo("Validación en producción", "Alta", "Pruebas"),
                            new TaskInfo("Capacitación a usuarios", "Alta", "Soporte"),
                            new TaskInfo("Capacitación a soporte", "Alta", "Soporte"),
                            new TaskInfo("Pruebas de aceptación", "Alta", "Pruebas"),
                            new TaskInfo("Documentación de procesos", "Alta", "Documentación"),
                            new TaskInfo("Aprobación de operaciones", "Alta", "Planificación"),
                            new TaskInfo("Migración de datos", "Alta", "Implementación"),
                            new TaskInfo("Soporte inicial", "Alta", "Soporte"),
                            new TaskInfo("Implementación de respaldo", "Alta", "Implementación"),

                            // Prioridad Media
                            new TaskInfo("Optimización de rendimiento en producción", "Media", "Implementación"),
                            new TaskInfo("Configuración de respaldo", "Media", "Implementación"),
                            new TaskInfo("Plan de contingencia", "Media", "Planificación"),
                            new TaskInfo("Migración de datos", "Media", "Implementación"),
                            new TaskInfo("Asistencia en transición", "Media", "Soporte"),
                            new TaskInfo("Documentación de operaciones", "Media", "Documentación"),
                            new TaskInfo("Estrategia de continuidad", "Media", "Planificación"),
                            new TaskInfo("Validación de integridad de datos", "Media", "Pruebas"),
                            new TaskInfo("Pruebas de carga", "Media", "Pruebas"),
                            new TaskInfo("Configuración de monitoreo", "Media", "Implementación"),

                            // Prioridad Baja
                            new TaskInfo("Revisión post-implementación", "Baja", "Análisis"),
                            new TaskInfo("Ajustes según feedback", "Baja", "Implementación"),
                            new TaskInfo("Actualización de soporte", "Baja", "Soporte"),
                            new TaskInfo("Gestión de versiones", "Baja", "Desarrollo"),
                            new TaskInfo("Monitoreo de SLA", "Baja", "Soporte"),
                            new TaskInfo("Configuración de mesa de ayuda", "Baja", "Soporte"),
                            new TaskInfo("Base de conocimiento", "Baja", "Documentación"),
                            new TaskInfo("Recuperación ante desastres", "Baja", "Soporte"),
                            new TaskInfo("Plan de mantenimiento", "Baja", "Planificación"),
                            new TaskInfo("Desactivación de versiones anteriores", "Baja", "Implementación"),

                        }
                    }
                }
            },
            {
                "ISO/IEC 20000", new Dictionary<string, List<TaskInfo>>
            {
                {
                        "inicio", new List<TaskInfo>
                        {
                           // Prioridad Alta
                            new TaskInfo("Identificación de servicios clave", "Alta", "Planificación"),
                            new TaskInfo("Establecimiento de objetivos de nivel de servicio (SLAs)", "Alta", "Planificación"),
                            new TaskInfo("Análisis de necesidades del cliente", "Alta", "Análisis"),
                            new TaskInfo("Definición de alcance de los servicios", "Alta", "Planificación"),
                            new TaskInfo("Evaluación de riesgos en la provisión de servicios", "Alta", "Análisis"),
                            new TaskInfo("Asignación de roles de gestión de servicios", "Alta", "Planificación"),
                            new TaskInfo("Definición de métricas de desempeño de servicios", "Alta", "Planificación"),
                            new TaskInfo("Creación de un plan de comunicación de servicios", "Alta", "Planificación"),
                            new TaskInfo("Análisis de viabilidad de SLAs", "Alta", "Análisis"),
                            new TaskInfo("Documentación de los requisitos de servicio iniciales", "Alta", "Documentación"),

                            // Prioridad Media
                            new TaskInfo("Identificación de puntos críticos de contacto", "Media", "Análisis"),
                            new TaskInfo("Definición de procedimientos de solicitud de servicio", "Media", "Planificación"),
                            new TaskInfo("Evaluación de proveedores de servicio externos", "Media", "Análisis"),
                            new TaskInfo("Definición de políticas de soporte y asistencia", "Media", "Planificación"),
                            new TaskInfo("Definición de niveles de prioridad en incidentes", "Media", "Análisis"),
                            new TaskInfo("Desarrollo de un plan de respaldo de datos", "Media", "Planificación"),
                            new TaskInfo("Establecimiento de una política de recuperación de desastres", "Media", "Planificación"),
                            new TaskInfo("Creación de un sistema de gestión de cambios", "Media", "Planificación"),
                            new TaskInfo("Establecimiento de roles y responsabilidades en servicios", "Media", "Planificación"),
                            new TaskInfo("Evaluación de compatibilidad de servicios con infraestructura existente", "Media", "Análisis"),

                            // Prioridad Baja
                            new TaskInfo("Definición de requisitos de formación en servicios", "Baja", "Planificación"),
                            new TaskInfo("Evaluación de políticas de acceso y seguridad en servicios", "Baja", "Análisis"),
                            new TaskInfo("Documentación de mejores prácticas en la gestión de servicios", "Baja", "Documentación"),
                            new TaskInfo("Creación de un sistema de registro de incidentes", "Baja", "Planificación"),
                            new TaskInfo("Análisis de impacto de los servicios en el usuario final", "Baja", "Análisis"),
                            new TaskInfo("Identificación de posibles mejoras en servicios", "Baja", "Análisis"),
                            new TaskInfo("Establecimiento de un plan de capacitación de usuarios", "Baja", "Planificación"),
                            new TaskInfo("Planificación de auditorías internas de servicios", "Baja", "Planificación"),
                            new TaskInfo("Evaluación de costos de los servicios", "Baja", "Análisis"),
                            new TaskInfo("Definición de requisitos de accesibilidad", "Baja", "Análisis"),

                        }
                },

                    {
                        "elaboracion", new List<TaskInfo>
                        {
                            // Agregar tareas para la fase de elaboración
                            // Prioridad Alta
                            new TaskInfo("Diseño de la estructura de soporte", "Alta", "Diseño"),
                            new TaskInfo("Establecimiento de controles de cumplimiento de SLAs", "Alta", "Planificación"),
                            new TaskInfo("Desarrollo de procedimientos de gestión de incidentes", "Alta", "Diseño"),
                            new TaskInfo("Planificación de pruebas de servicio", "Alta", "Pruebas"),
                            new TaskInfo("Diseño de políticas de gestión de problemas", "Alta", "Diseño"),
                            new TaskInfo("Implementación de criterios de escalabilidad en servicios", "Alta", "Diseño"),
                            new TaskInfo("Establecimiento de medidas de recuperación de datos", "Alta", "Diseño"),
                            new TaskInfo("Desarrollo de plan de soporte técnico en línea", "Alta", "Planificación"),
                            new TaskInfo("Definición de roles de escalamiento en incidentes", "Alta", "Planificación"),
                            new TaskInfo("Implementación de procesos de control de calidad en servicios", "Alta", "Planificación"),

                            // Prioridad Media
                            new TaskInfo("Evaluación de capacidad de servicios", "Media", "Análisis"),
                            new TaskInfo("Definición de métricas de desempeño de servicios", "Media", "Análisis"),
                            new TaskInfo("Pruebas de recuperación ante fallos", "Media", "Pruebas"),
                            new TaskInfo("Simulación de incidentes", "Media", "Pruebas"),
                            new TaskInfo("Planificación de auditorías de calidad de servicio", "Media", "Planificación"),
                            new TaskInfo("Creación de documentación de soporte técnico", "Media", "Documentación"),
                            new TaskInfo("Definición de flujos de trabajo en gestión de incidentes", "Media", "Diseño"),
                            new TaskInfo("Gestión de dependencias en servicios", "Media", "Análisis"),
                            new TaskInfo("Implementación de pruebas de carga", "Media", "Pruebas"),
                            new TaskInfo("Optimización de tiempos de respuesta", "Media", "Diseño"),

                            // Prioridad Baja
                            new TaskInfo("Documentación de políticas de gestión de cambios", "Baja", "Documentación"),
                            new TaskInfo("Definición de un plan de actualización de servicios", "Baja", "Planificación"),
                            new TaskInfo("Pruebas de accesibilidad en servicios", "Baja", "Pruebas"),
                            new TaskInfo("Desarrollo de informes de desempeño de servicios", "Baja", "Documentación"),
                            new TaskInfo("Revisión de escalabilidad en diseño", "Baja", "Análisis"),
                            new TaskInfo("Evaluación de la sostenibilidad de los servicios", "Baja", "Análisis"),
                            new TaskInfo("Establecimiento de métricas de satisfacción del cliente", "Baja", "Planificación"),
                            new TaskInfo("Revisión de compatibilidad de servicio con otros sistemas", "Baja", "Análisis"),
                            new TaskInfo("Planificación de actualización de hardware para soporte de servicios", "Baja", "Planificación"),
                            new TaskInfo("Definición de un plan de entrenamiento para el equipo de soporte", "Baja", "Planificación"),

                        }
                    },
                    {
                        "construccion", new List<TaskInfo>
                        {
                            // Agregar tareas para la fase de construcción
                            // Prioridad Alta
                            new TaskInfo("Implementación de la estructura de soporte", "Alta", "Desarrollo"),
                            new TaskInfo("Desarrollo de la mesa de ayuda", "Alta", "Desarrollo"),
                            new TaskInfo("Implementación de SLAs en producción", "Alta", "Implementación"),
                            new TaskInfo("Pruebas de aceptación del servicio", "Alta", "Pruebas"),
                            new TaskInfo("Implementación de controles de calidad en servicios", "Alta", "Implementación"),
                            new TaskInfo("Configuración de un sistema de monitoreo de servicios", "Alta", "Implementación"),
                            new TaskInfo("Automatización de procesos de gestión de incidentes", "Alta", "Desarrollo"),
                            new TaskInfo("Documentación de soporte técnico", "Alta", "Documentación"),
                            new TaskInfo("Configuración de medidas de escalamiento en incidentes", "Alta", "Implementación"),
                            new TaskInfo("Implementación de controles de recuperación de datos", "Alta", "Implementación"),

                            // Prioridad Media
                            new TaskInfo("Evaluación de rendimiento de soporte", "Media", "Análisis"),
                            new TaskInfo("Pruebas de continuidad del servicio", "Media", "Pruebas"),
                            new TaskInfo("Desarrollo de documentación de procesos de soporte", "Media", "Documentación"),
                            new TaskInfo("Optimización de recursos en soporte", "Media", "Desarrollo"),
                            new TaskInfo("Simulación de fallos en soporte", "Media", "Pruebas"),
                            new TaskInfo("Validación de recuperación de datos", "Media", "Pruebas"),
                            new TaskInfo("Pruebas de capacidad de escalamiento en producción", "Media", "Pruebas"),
                            new TaskInfo("Documentación de métricas de desempeño de soporte", "Media", "Documentación"),
                            new TaskInfo("Optimización de tiempo de respuesta en soporte", "Media", "Desarrollo"),
                            new TaskInfo("Implementación de mejoras en el flujo de trabajo de soporte", "Media", "Desarrollo"),

                            // Prioridad Baja
                            new TaskInfo("Revisión de políticas de escalamiento en soporte", "Baja", "Documentación"),
                            new TaskInfo("Implementación de procesos de mantenimiento preventivo", "Baja", "Implementación"),
                            new TaskInfo("Evaluación de usabilidad del sistema de soporte", "Baja", "Pruebas"),
                            new TaskInfo("Documentación de acuerdos de nivel de servicio (SLAs)", "Baja", "Documentación"),
                            new TaskInfo("Revisión de herramientas de soporte técnico", "Baja", "Análisis"),
                            new TaskInfo("Establecimiento de métricas de eficiencia del soporte", "Baja", "Planificación"),
                            new TaskInfo("Pruebas de compatibilidad de soporte en diferentes plataformas", "Baja", "Pruebas"),
                            new TaskInfo("Evaluación de seguridad en la gestión de soporte", "Baja", "Pruebas"),
                            new TaskInfo("Planificación de actualizaciones en soporte", "Baja", "Planificación"),
                            new TaskInfo("Gestión de versiones en sistemas de soporte", "Baja", "Desarrollo"),

                        }
                    },
                    {
                        "Transicion", new List<TaskInfo>
                        {
                            // Agregar tareas para la fase de transición
                            // Prioridad Alta
                            new TaskInfo("Preparación del entorno de producción", "Alta", "Implementación"),
                            new TaskInfo("Pruebas de aceptación finales", "Alta", "Pruebas"),
                            new TaskInfo("Despliegue de servicios en producción", "Alta", "Implementación"),
                            new TaskInfo("Capacitación en soporte para usuarios finales", "Alta", "Soporte"),
                            new TaskInfo("Implementación de sistema de soporte continuo", "Alta", "Implementación"),
                            new TaskInfo("Configuración de monitoreo en producción", "Alta", "Implementación"),
                            new TaskInfo("Migración de datos al entorno de producción", "Alta", "Implementación"),
                            new TaskInfo("Configuración de copias de seguridad de producción", "Alta", "Implementación"),
                            new TaskInfo("Creación de procedimientos de gestión de incidentes en producción", "Alta", "Documentación"),
                            new TaskInfo("Definición de métricas de satisfacción del cliente", "Alta", "Planificación"),

                            // Prioridad Media
                            new TaskInfo("Optimización de tiempo de respuesta en producción", "Media", "Implementación"),
                            new TaskInfo("Establecimiento de planes de contingencia en producción", "Media", "Planificación"),
                            new TaskInfo("Documentación de procedimientos operativos", "Media", "Documentación"),
                            new TaskInfo("Pruebas de carga y rendimiento en producción", "Media", "Pruebas"),
                            new TaskInfo("Validación de accesibilidad en producción", "Media", "Pruebas"),
                            new TaskInfo("Pruebas de usabilidad para usuarios finales", "Media", "Pruebas"),
                            new TaskInfo("Gestión de cambio en producción", "Media", "Planificación"),
                            new TaskInfo("Establecimiento de un canal de feedback", "Media", "Soporte"),
                            new TaskInfo("Configuración de métricas de servicio en producción", "Media", "Implementación"),
                            new TaskInfo("Definición de un sistema de resolución de incidencias", "Media", "Planificación"),

                            // Prioridad Baja
                            new TaskInfo("Evaluación de seguridad post-implementación", "Baja", "Análisis"),
                            new TaskInfo("Revisión de procesos de soporte en producción", "Baja", "Soporte"),
                            new TaskInfo("Optimización de uso de recursos en producción", "Baja", "Implementación"),
                            new TaskInfo("Monitoreo de métricas de satisfacción del cliente", "Baja", "Soporte"),
                            new TaskInfo("Revisión y actualización de SLAs", "Baja", "Documentación"),
                            new TaskInfo("Actualización de procedimientos de calidad", "Baja", "Documentación"),
                            new TaskInfo("Evaluación de planes de mejora continua", "Baja", "Planificación"),
                            new TaskInfo("Documentación de lecciones aprendidas", "Baja", "Documentación"),
                            new TaskInfo("Análisis de rendimiento en diferentes entornos", "Baja", "Pruebas"),
                            new TaskInfo("Planificación de futuras actualizaciones", "Baja", "Planificación"),

                        }
                    }
                }

            },
            {
                "ISO/IEC 25010", new Dictionary<string, List<TaskInfo>>
            {
                {
                        "inicio", new List<TaskInfo>
                        {
                            // Prioridad Alta
                            new TaskInfo("Definición de requisitos de calidad", "Alta", "Análisis"),
                            new TaskInfo("Identificación de interesados clave", "Alta", "Planificación"),
                            new TaskInfo("Establecimiento de estándares de calidad", "Alta", "Planificación"),
                            new TaskInfo("Evaluación de necesidades de calidad del cliente", "Alta", "Análisis"),
                            new TaskInfo("Priorización de atributos de calidad", "Alta", "Planificación"),
                            new TaskInfo("Identificación de limitaciones técnicas para la calidad", "Alta", "Análisis"),
                            new TaskInfo("Análisis de impacto de calidad", "Alta", "Análisis"),
                            new TaskInfo("Definición de objetivos de usabilidad", "Alta", "Planificación"),
                            new TaskInfo("Definición de métricas de calidad", "Alta", "Planificación"),
                            new TaskInfo("Documentación de requisitos de calidad", "Alta", "Documentación"),

                            // Prioridad Media
                            new TaskInfo("Revisión de estándares de calidad existentes", "Media", "Documentación"),
                            new TaskInfo("Definición de criterios de aceptación de calidad", "Media", "Análisis"),
                            new TaskInfo("Definición de roles y responsabilidades para la calidad", "Media", "Planificación"),
                            new TaskInfo("Análisis de compatibilidad de calidad", "Media", "Análisis"),
                            new TaskInfo("Creación de un prototipo inicial centrado en la calidad", "Media", "Diseño"),
                            new TaskInfo("Evaluación de herramientas de medición de calidad", "Media", "Análisis"),
                            new TaskInfo("Establecimiento de un plan de validación de calidad", "Media", "Planificación"),
                            new TaskInfo("Definición de características de accesibilidad", "Media", "Análisis"),
                            new TaskInfo("Definición de políticas de control de calidad", "Media", "Planificación"),
                            new TaskInfo("Establecimiento de mecanismos de feedback del usuario", "Media", "Planificación"),

                            // Prioridad Baja
                            new TaskInfo("Documentación de mejores prácticas de calidad", "Baja", "Documentación"),
                            new TaskInfo("Análisis de seguridad inicial", "Baja", "Análisis"),
                            new TaskInfo("Evaluación de impacto de la calidad en el tiempo de desarrollo", "Baja", "Análisis"),
                            new TaskInfo("Evaluación de la facilidad de mantenimiento", "Baja", "Análisis"),
                            new TaskInfo("Revisión de requisitos no funcionales", "Baja", "Documentación"),
                            new TaskInfo("Evaluación de riesgos de calidad", "Baja", "Análisis"),
                            new TaskInfo("Establecimiento de un sistema de control de cambios", "Baja", "Planificación"),
                            new TaskInfo("Estudio de la reusabilidad de componentes", "Baja", "Análisis"),
                            new TaskInfo("Análisis de eficiencia de recursos", "Baja", "Análisis"),
                            new TaskInfo("Establecimiento de un plan de recuperación ante fallos de calidad", "Baja", "Planificación"),


                        }
                },

                    {
                        "elaboracion", new List<TaskInfo>
                        {
                            // Agregar tareas para la fase de elaboración
                            // Prioridad Alta
                            new TaskInfo("Definición de arquitectura", "Alta", "Diseño"),
                            new TaskInfo("Identificación de atributos críticos de calidad", "Alta", "Análisis"),
                            new TaskInfo("Validación de requisitos funcionales", "Alta", "Pruebas"),
                            new TaskInfo("Escenarios de calidad críticos", "Alta", "Pruebas"),
                            new TaskInfo("Análisis de requisitos no funcionales", "Alta", "Análisis"),
                            new TaskInfo("Implementación de prototipos", "Alta", "Diseño"),
                            new TaskInfo("Diseño modular y reusabilidad", "Alta", "Diseño"),
                            new TaskInfo("Pruebas de integración tempranas", "Alta", "Pruebas"),
                            new TaskInfo("Estrategia de seguridad", "Alta", "Análisis"),
                            new TaskInfo("Interfaces centradas en accesibilidad", "Alta", "Diseño"),

                            // Prioridad Media
                            new TaskInfo("Pruebas de rendimiento", "Media", "Pruebas"),
                            new TaskInfo("Escalabilidad de la arquitectura", "Media", "Análisis"),
                            new TaskInfo("Interoperabilidad", "Media", "Análisis"),
                            new TaskInfo("Refinamiento de casos complejos", "Media", "Análisis"),
                            new TaskInfo("Plan de gestión de errores", "Media", "Análisis"),
                            new TaskInfo("Aprobación final de arquitectura", "Media", "Planificación"),
                            new TaskInfo("Facilidad de mantenimiento", "Media", "Análisis"),
                            new TaskInfo("Modelo lógico de datos", "Media", "Diseño"),
                            new TaskInfo("Estrategia de portabilidad", "Media", "Análisis"),
                            new TaskInfo("Estrategia de recuperación", "Media", "Planificación"),

                            // Prioridad Baja
                            new TaskInfo("Pruebas iniciales de resiliencia", "Baja", "Pruebas"),
                            new TaskInfo("Validación de calidad en prototipos alternativos", "Baja", "Pruebas"),
                            new TaskInfo("Revisión de modularidad en diseño", "Baja", "Análisis"),
                            new TaskInfo("Documentación de prácticas de diseño para calidad", "Baja", "Documentación"),
                            new TaskInfo("Pruebas de compatibilidad de calidad en plataformas diversas", "Baja", "Pruebas"),
                            new TaskInfo("Evaluación de usabilidad con muestras de usuarios", "Baja", "Pruebas"),
                            new TaskInfo("Simulación de escenarios de carga", "Baja", "Pruebas"),
                            new TaskInfo("Validación de requisitos no funcionales secundarios", "Baja", "Pruebas"),
                            new TaskInfo("Evaluación de facilidad de mantenimiento", "Baja", "Análisis"),
                            new TaskInfo("Revisión de estándares de seguridad en diseño", "Baja", "Análisis"),

                        }
                    },
                    {
                        "construccion", new List<TaskInfo>
                        {
                            // Agregar tareas para la fase de construcción
                            // Prioridad Alta
                            new TaskInfo("Implementación de requisitos de calidad en módulos críticos", "Alta", "Desarrollo"),
                            new TaskInfo("Pruebas de calidad en componentes individuales", "Alta", "Pruebas"),
                            new TaskInfo("Integración de criterios de usabilidad en la interfaz de usuario", "Alta", "Desarrollo"),
                            new TaskInfo("Validación de rendimiento", "Alta", "Pruebas"),
                            new TaskInfo("Pruebas de funcionalidad y eficiencia en módulos principales", "Alta", "Pruebas"),
                            new TaskInfo("Implementación de accesibilidad en la interfaz de usuario", "Alta", "Desarrollo"),
                            new TaskInfo("Documentación de calidad de código", "Alta", "Documentación"),
                            new TaskInfo("Automatización de pruebas de calidad", "Alta", "Pruebas"),
                            new TaskInfo("Optimización del uso de recursos", "Alta", "Desarrollo"),
                            new TaskInfo("Pruebas de escalabilidad del sistema", "Alta", "Pruebas"),

                            // Prioridad Media
                            new TaskInfo("Pruebas de seguridad en el sistema", "Media", "Pruebas"),
                            new TaskInfo("Implementación de modularidad", "Media", "Desarrollo"),
                            new TaskInfo("Optimización de tiempo de respuesta", "Media", "Desarrollo"),
                            new TaskInfo("Configuración de herramientas de monitoreo de calidad", "Media", "Implementación"),
                            new TaskInfo("Validación de consistencia de datos", "Media", "Pruebas"),
                            new TaskInfo("Creación de informes de calidad", "Media", "Documentación"),
                            new TaskInfo("Documentación técnica detallada de los módulos", "Media", "Documentación"),
                            new TaskInfo("Validación de portabilidad", "Media", "Pruebas"),
                            new TaskInfo("Optimización de recursos de almacenamiento", "Media", "Desarrollo"),
                            new TaskInfo("Implementación de medidas de recuperación ante fallos", "Media", "Desarrollo"),

                            // Prioridad Baja
                            new TaskInfo("Pruebas de compatibilidad en diferentes plataformas", "Baja", "Pruebas"),
                            new TaskInfo("Validación de interfaces de usuario alternativas", "Baja", "Pruebas"),
                            new TaskInfo("Gestión de la reusabilidad de código", "Baja", "Desarrollo"),
                            new TaskInfo("Monitoreo del uso de recursos durante la ejecución", "Baja", "Implementación"),
                            new TaskInfo("Revisión de métricas de calidad de software", "Baja", "Análisis"),
                            new TaskInfo("Documentación de procesos de desarrollo de calidad", "Baja", "Documentación"),
                            new TaskInfo("Pruebas de calidad de imagen y sonido", "Baja", "Pruebas"),
                            new TaskInfo("Optimización del rendimiento en dispositivos móviles", "Baja", "Desarrollo"),
                            new TaskInfo("Validación de opciones de configuración de calidad", "Baja", "Pruebas"),
                            new TaskInfo("Pruebas de mantenimiento y actualizaciones", "Baja", "Pruebas"),

                        }
                    },
                    {
                        "Transicion", new List<TaskInfo>
                        {
                            // Agregar tareas para la fase de transición
                            // Prioridad Alta
                            new TaskInfo("Validación de calidad en producción", "Alta", "Pruebas"),
                            new TaskInfo("Implementación de monitoreo de calidad en tiempo real", "Alta", "Implementación"),
                            new TaskInfo("Capacitación a usuarios en prácticas de calidad", "Alta", "Soporte"),
                            new TaskInfo("Pruebas de aceptación enfocadas en la calidad", "Alta", "Pruebas"),
                            new TaskInfo("Implementación de medidas de recuperación en producción", "Alta", "Implementación"),
                            new TaskInfo("Documentación de calidad de operaciones", "Alta", "Documentación"),
                            new TaskInfo("Establecimiento de acuerdos de calidad con clientes (SLAs)", "Alta", "Planificación"),
                            new TaskInfo("Validación de integridad de datos en producción", "Alta", "Pruebas"),
                            new TaskInfo("Implementación de monitoreo de rendimiento en producción", "Alta", "Implementación"),
                            new TaskInfo("Ajustes de configuración para optimización de calidad", "Alta", "Implementación"),

                            // Prioridad Media
                            new TaskInfo("Documentación de métricas de rendimiento", "Media", "Documentación"),
                            new TaskInfo("Evaluación de la escalabilidad en producción", "Media", "Análisis"),
                            new TaskInfo("Soporte inicial para resolución de problemas de calidad", "Media", "Soporte"),
                            new TaskInfo("Validación de la accesibilidad en producción", "Media", "Pruebas"),
                            new TaskInfo("Evaluación de usabilidad en producción", "Media", "Pruebas"),
                            new TaskInfo("Implementación de auditorías de calidad periódicas", "Media", "Planificación"),
                            new TaskInfo("Monitoreo de SLA de calidad", "Media", "Soporte"),
                            new TaskInfo("Optimización de tiempos de respuesta en producción", "Media", "Implementación"),
                            new TaskInfo("Validación de modularidad en producción", "Media", "Pruebas"),
                            new TaskInfo("Documentación de recomendaciones de mejora de calidad", "Media", "Documentación"),

                            // Prioridad Baja
                            new TaskInfo("Revisión post-implementación de calidad", "Baja", "Análisis"),
                            new TaskInfo("Actualización de procedimientos de calidad en producción", "Baja", "Documentación"),
                            new TaskInfo("Gestión de versiones de calidad en producción", "Baja", "Desarrollo"),
                            new TaskInfo("Optimización de recursos en producción", "Baja", "Implementación"),
                            new TaskInfo("Planificación de mejoras continuas de calidad", "Baja", "Planificación"),
                            new TaskInfo("Capacitación en mantenimiento de calidad para el equipo de soporte", "Baja", "Soporte"),
                            new TaskInfo("Monitoreo de métricas de satisfacción del usuario", "Baja", "Implementación"),
                            new TaskInfo("Evaluación de actualizaciones de calidad", "Baja", "Análisis"),
                            new TaskInfo("Desactivación de configuraciones antiguas de baja calidad", "Baja", "Implementación"),
                            new TaskInfo("Generación de reportes de impacto de calidad", "Baja", "Documentación"),

                        }
                    }
                }
            },
            {
                "ISO/IEC 27001", new Dictionary<string, List<TaskInfo>>
                {
                    {
                        "inicio", new List<TaskInfo>
                        {
                            // Prioridad Alta
                            new TaskInfo("Identificación de riesgos de seguridad", "Alta", "Análisis"),
                            new TaskInfo("Definición de objetivos de seguridad", "Alta", "Planificación"),
                            new TaskInfo("Establecimiento de políticas de seguridad", "Alta", "Planificación"),
                            new TaskInfo("Asignación de roles de seguridad", "Alta", "Planificación"),
                            new TaskInfo("Análisis de viabilidad de controles de seguridad", "Alta", "Análisis"),
                            new TaskInfo("Evaluación de cumplimiento normativo", "Alta", "Análisis"),
                            new TaskInfo("Definición de requisitos de autenticación", "Alta", "Análisis"),
                            new TaskInfo("Identificación de activos críticos", "Alta", "Análisis"),
                            new TaskInfo("Establecimiento de un plan de respuesta a incidentes", "Alta", "Planificación"),
                            new TaskInfo("Evaluación inicial de amenazas y vulnerabilidades", "Alta", "Análisis"),

                            // Prioridad Media
                            new TaskInfo("Plan de comunicación de seguridad", "Media", "Planificación"),
                            new TaskInfo("Capacitación en seguridad básica", "Media", "Soporte"),
                            new TaskInfo("Evaluación de proveedores de seguridad", "Media", "Análisis"),
                            new TaskInfo("Definición de criterios de acceso a la información", "Media", "Análisis"),
                            new TaskInfo("Creación de políticas de control de acceso", "Media", "Planificación"),
                            new TaskInfo("Identificación de datos confidenciales", "Media", "Análisis"),
                            new TaskInfo("Definición de métricas de seguridad", "Media", "Planificación"),
                            new TaskInfo("Planificación de controles de acceso", "Media", "Planificación"),
                            new TaskInfo("Establecimiento de control de versiones en seguridad", "Media", "Desarrollo"),
                            new TaskInfo("Documentación de políticas de seguridad", "Media", "Documentación"),

                            // Prioridad Baja
                            new TaskInfo("Revisión de políticas de seguridad del cliente", "Baja", "Documentación"),
                            new TaskInfo("Evaluación de requisitos de auditoría de seguridad", "Baja", "Análisis"),
                            new TaskInfo("Planificación de auditorías internas", "Baja", "Planificación"),
                            new TaskInfo("Plan de eliminación de datos", "Baja", "Planificación"),
                            new TaskInfo("Análisis de impacto de amenazas", "Baja", "Análisis"),
                            new TaskInfo("Documentación de controles de seguridad iniciales", "Baja", "Documentación"),
                            new TaskInfo("Análisis de riesgos relacionados con terceros", "Baja", "Análisis"),
                            new TaskInfo("Establecimiento de un plan de copias de seguridad", "Baja", "Planificación"),
                            new TaskInfo("Definición de acceso remoto seguro", "Baja", "Planificación"),
                            new TaskInfo("Identificación de puntos de acceso críticos", "Baja", "Análisis"),
                        }
                    },
                {
                        "elaboracion", new List<TaskInfo>
                        {
                            // Prioridad Alta
                            new TaskInfo("Diseño de arquitectura segura", "Alta", "Diseño"),
                            new TaskInfo("Evaluación de riesgos de seguridad", "Alta", "Análisis"),
                            new TaskInfo("Definición de controles de acceso", "Alta", "Diseño"),
                            new TaskInfo("Desarrollo de planes de mitigación de amenazas", "Alta", "Planificación"),
                            new TaskInfo("Diseño de sistemas de autenticación", "Alta", "Diseño"),
                            new TaskInfo("Validación de requisitos de seguridad", "Alta", "Pruebas"),
                            new TaskInfo("Establecimiento de medidas de protección de datos", "Alta", "Diseño"),
                            new TaskInfo("Gestión de riesgos de vulnerabilidad", "Alta", "Análisis"),
                            new TaskInfo("Planificación de auditoría de seguridad", "Alta", "Planificación"),
                            new TaskInfo("Implementación de cifrado de datos", "Alta", "Desarrollo"),

                            // Prioridad Media
                            new TaskInfo("Simulación de amenazas", "Media", "Pruebas"),
                            new TaskInfo("Verificación de escalabilidad en seguridad", "Media", "Análisis"),
                            new TaskInfo("Implementación de controles de auditoría", "Media", "Desarrollo"),
                            new TaskInfo("Gestión de incidentes de seguridad", "Media", "Soporte"),
                            new TaskInfo("Validación de acceso seguro", "Media", "Pruebas"),
                            new TaskInfo("Planificación de pruebas de penetración", "Media", "Planificación"),
                            new TaskInfo("Definición de métricas de integridad de datos", "Media", "Análisis"),
                            new TaskInfo("Implementación de controles de rastreo de actividad", "Media", "Desarrollo"),
                            new TaskInfo("Documentación de arquitectura de seguridad", "Media", "Documentación"),
                            new TaskInfo("Evaluación de usabilidad en sistemas seguros", "Media", "Análisis"),

                            // Prioridad Baja
                            new TaskInfo("Simulación de escenarios de desastre", "Baja", "Pruebas"),
                            new TaskInfo("Validación de registros de auditoría", "Baja", "Pruebas"),
                            new TaskInfo("Planificación de gestión de parches de seguridad", "Baja", "Planificación"),
                            new TaskInfo("Revisión de políticas de acceso físico", "Baja", "Análisis"),
                            new TaskInfo("Desarrollo de informes de seguridad", "Baja", "Documentación"),
                            new TaskInfo("Gestión de contraseñas seguras", "Baja", "Soporte"),
                            new TaskInfo("Revisión de acceso de terceros", "Baja", "Análisis"),
                            new TaskInfo("Pruebas de acceso a datos críticos", "Baja", "Pruebas"),
                            new TaskInfo("Configuración de autenticación multifactor", "Baja", "Desarrollo"),
                            new TaskInfo("Evaluación de políticas de recuperación de datos", "Baja", "Análisis"),
                        }
                    },
                    {
                        "construccion", new List<TaskInfo>
                        {
                            // Prioridad Alta
                            new TaskInfo("Desarrollo de módulos críticos", "Alta", "Desarrollo"),
                            new TaskInfo("Controles de seguridad", "Alta", "Desarrollo"),
                            new TaskInfo("Codificación segura", "Alta", "Desarrollo"),
                            new TaskInfo("Verificación de privacidad y protección de datos", "Alta", "Pruebas"),
                            new TaskInfo("Pruebas de seguridad en componentes", "Alta", "Pruebas"),
                            new TaskInfo("Gestión de accesos", "Alta", "Desarrollo"),
                            new TaskInfo("Mecanismos de autenticación", "Alta", "Desarrollo"),
                            new TaskInfo("Interfaces de usuario final", "Alta", "Desarrollo"),
                            new TaskInfo("Pruebas de integración continua", "Alta", "Pruebas"),
                            new TaskInfo("Control de versiones", "Alta", "Desarrollo"),

                            // Prioridad Media
                            new TaskInfo("Seguridad en bases de datos", "Media", "Desarrollo"),
                            new TaskInfo("Análisis de vulnerabilidades", "Media", "Pruebas"),
                            new TaskInfo("Funcionalidades de auditoría", "Media", "Desarrollo"),
                            new TaskInfo("Pruebas funcionales clave", "Media", "Pruebas"),
                            new TaskInfo("Configuración de gestión de incidentes", "Media", "Soporte"),
                            new TaskInfo("Documentación técnica", "Media", "Documentación"),
                            new TaskInfo("Recuperación de fallos", "Media", "Soporte"),
                            new TaskInfo("Consistencia de datos", "Media", "Pruebas"),
                            new TaskInfo("Validación de rendimiento", "Media", "Pruebas"),
                            new TaskInfo("Cifrado de comunicaciones", "Media", "Desarrollo"),

                            // Prioridad Baja
                            new TaskInfo("Políticas de seguridad en desarrollo", "Baja", "Documentación"),
                            new TaskInfo("Pruebas de penetración", "Baja", "Pruebas"),
                            new TaskInfo("Monitoreo de actividades", "Baja", "Implementación"),
                            new TaskInfo("Verificación de resiliencia", "Baja", "Pruebas"),
                            new TaskInfo("Capacidades de auditoría", "Baja", "Soporte"),
                            new TaskInfo("Capacitación en seguridad", "Baja", "Soporte"),
                            new TaskInfo("Mecanismos de respaldo", "Baja", "Implementación"),
                            new TaskInfo("Interfaz de usuario segura", "Baja", "Pruebas"),
                            new TaskInfo("Escalabilidad del sistema", "Baja", "Análisis"),
                            new TaskInfo("Cumplimiento de normativas", "Baja", "Documentación"),
                        }
                    },
                    {
                        "transicion", new List<TaskInfo>
                        {
                            // Prioridad Alta
                            new TaskInfo("Implementación en producción", "Alta", "Implementación"),
                            new TaskInfo("Verificación de controles de seguridad", "Alta", "Pruebas"),
                            new TaskInfo("Validación de acceso a datos", "Alta", "Pruebas"),
                            new TaskInfo("Capacitación del personal", "Alta", "Soporte"),
                            new TaskInfo("Gestión de cambios", "Alta", "Soporte"),
                            new TaskInfo("Implementación de monitorización de seguridad", "Alta", "Implementación"),
                            new TaskInfo("Configuración de alertas de seguridad", "Alta", "Implementación"),
                            new TaskInfo("Verificación de recuperación ante desastres", "Alta", "Pruebas"),
                            new TaskInfo("Comunicación de cambios a partes interesadas", "Alta", "Soporte"),
                            new TaskInfo("Documentación de proceso de transición", "Alta", "Documentación"),

                            // Prioridad Media
                            new TaskInfo("Revisión de auditorías de seguridad", "Media", "Soporte"),
                            new TaskInfo("Verificación de conformidad", "Media", "Pruebas"),
                            new TaskInfo("Implementación de feedback de usuarios", "Media", "Soporte"),
                            new TaskInfo("Plan de mejora continua", "Media", "Soporte"),
                            new TaskInfo("Auditoría post-implementación", "Media", "Soporte"),
                            new TaskInfo("Documentación de lecciones aprendidas", "Media", "Documentación"),
                            new TaskInfo("Revisión de procesos de seguridad", "Media", "Soporte"),
                            new TaskInfo("Evaluación de satisfacción del usuario", "Media", "Soporte"),
                            new TaskInfo("Plan de soporte post-lanzamiento", "Media", "Soporte"),
                            new TaskInfo("Configuración de soporte técnico", "Media", "Soporte"),

                            // Prioridad Baja
                            new TaskInfo("Revisión de procesos", "Baja", "Documentación"),
                            new TaskInfo("Documentación de cambios realizados", "Baja", "Documentación"),
                            new TaskInfo("Análisis de rendimiento post-implementación", "Baja", "Soporte"),
                            new TaskInfo("Feedback de stakeholders", "Baja", "Soporte"),
                            new TaskInfo("Evaluación de necesidades futuras", "Baja", "Análisis"),
                            new TaskInfo("Plan de gestión de incidentes", "Baja", "Soporte"),
                            new TaskInfo("Documentación de infraestructura", "Baja", "Documentación"),
                            new TaskInfo("Auditoría de seguridad final", "Baja", "Pruebas"),
                            new TaskInfo("Revisión de comunicaciones de seguridad", "Baja", "Documentación"),
                            new TaskInfo("Cierre de proyecto", "Baja", "Documentación"),
                        }
                    }
                }
            },
            {
                "ISO/IEC 29110", new Dictionary<string, List<TaskInfo>>
                {
                    {
                        "inicio", new List<TaskInfo>
                        {
                            // Alta Prioridad
                            new TaskInfo("Identificación de stakeholders clave", "Alta", "Planificación"),
                            new TaskInfo("Definición de alcance y objetivos del proyecto", "Alta", "Planificación"),
                            new TaskInfo("Recopilación de requisitos iniciales", "Alta", "Análisis"),
                            new TaskInfo("Análisis de riesgos iniciales", "Alta", "Análisis"),
                            new TaskInfo("Definición del entorno de desarrollo", "Alta", "Desarrollo"),
                            new TaskInfo("Evaluación de capacidades del equipo", "Alta", "Análisis"),
                            new TaskInfo("Priorización de requisitos", "Alta", "Análisis"),
                            new TaskInfo("Planificación de iteraciones", "Alta", "Planificación"),
                            new TaskInfo("Aprobación del alcance inicial", "Alta", "Planificación"),
                            new TaskInfo("Evaluación de costos preliminares", "Alta", "Análisis"),

                            // Media Prioridad
                            new TaskInfo("Establecimiento de criterios de aceptación", "Media", "Análisis"),
                            new TaskInfo("Definición de roles y responsabilidades del equipo", "Media", "Planificación"),
                            new TaskInfo("Definición de casos de uso principales", "Media", "Análisis"),
                            new TaskInfo("Desarrollo de un prototipo inicial", "Media", "Diseño"),
                            new TaskInfo("Planificación de comunicación con stakeholders", "Media", "Planificación"),
                            new TaskInfo("Estrategia de pruebas iniciales", "Media", "Pruebas"),
                            new TaskInfo("Identificación de dependencias", "Media", "Análisis"),
                            new TaskInfo("Definición de módulos clave", "Media", "Diseño"),
                            new TaskInfo("Configuración del sistema de control de versiones", "Media", "Desarrollo"),
                            new TaskInfo("Revisión de normativas aplicables", "Media", "Documentación"),

                            // Baja Prioridad
                            new TaskInfo("Elaboración del documento de visión", "Baja", "Documentación"),
                            new TaskInfo("Definición de métricas de éxito del proyecto", "Baja", "Análisis"),
                            new TaskInfo("Creación de plan de capacitación", "Baja", "Soporte"),
                            new TaskInfo("Evaluación de herramientas y frameworks", "Baja", "Análisis"),
                            new TaskInfo("Documentación de requisitos no funcionales", "Baja", "Documentación"),
                            new TaskInfo("Definición inicial de interfaces de usuario", "Baja", "Diseño"),
                            new TaskInfo("Planificación de gestión de configuración", "Baja", "Planificación"),
                            new TaskInfo("Estudio de escalabilidad", "Baja", "Análisis"),
                            new TaskInfo("Análisis de cumplimiento legal", "Baja", "Análisis"),
                            new TaskInfo("Definición de plan de gestión del conocimiento", "Baja", "Documentación"),
                        }
                    },
                    {
                        "elaboracion", new List<TaskInfo>
                        {
                            // Alta Prioridad
                            new TaskInfo("Refinamiento de requisitos", "Alta", "Análisis"),
                            new TaskInfo("Validación de casos de uso", "Alta", "Pruebas"),
                            new TaskInfo("Diseño arquitectónico preliminar", "Alta", "Diseño"),
                            new TaskInfo("Identificación de atributos de calidad", "Alta", "Análisis"),
                            new TaskInfo("Diseño de prototipo", "Alta", "Diseño"),
                            new TaskInfo("Gestión de dependencias críticas", "Alta", "Planificación"),
                            new TaskInfo("Evaluación de impacto de requisitos", "Alta", "Análisis"),
                            new TaskInfo("Planificación de pruebas de integración", "Alta", "Pruebas"),
                            new TaskInfo("Definición de módulos clave", "Alta", "Diseño"),
                            new TaskInfo("Definición de interfaces detalladas", "Alta", "Diseño"),

                            // Media Prioridad
                            new TaskInfo("Pruebas de rendimiento preliminares", "Media", "Pruebas"),
                            new TaskInfo("Optimización para escalabilidad", "Media", "Diseño"),
                            new TaskInfo("Evaluación de la interoperabilidad", "Media", "Análisis"),
                            new TaskInfo("Revisión de casos de uso complejos", "Media", "Análisis"),
                            new TaskInfo("Gestión de errores y excepciones", "Media", "Análisis"),
                            new TaskInfo("Revisión de arquitectura final", "Media", "Planificación"),
                            new TaskInfo("Evaluación de la mantenibilidad", "Media", "Análisis"),
                            new TaskInfo("Desarrollo del modelo lógico de datos", "Media", "Diseño"),
                            new TaskInfo("Evaluación de portabilidad", "Media", "Análisis"),
                            new TaskInfo("Definición de plan de recuperación", "Media", "Planificación"),

                            // Baja Prioridad
                            new TaskInfo("Pruebas iniciales de seguridad", "Baja", "Pruebas"),
                            new TaskInfo("Validación de la usabilidad", "Baja", "Pruebas"),
                            new TaskInfo("Implementación de integración continua", "Baja", "Desarrollo"),
                            new TaskInfo("Evaluación de la resiliencia ante fallos", "Baja", "Pruebas"),
                            new TaskInfo("Desarrollo de herramientas de monitoreo", "Baja", "Implementación"),
                            new TaskInfo("Refinamiento del modelo de datos físico", "Baja", "Diseño"),
                            new TaskInfo("Gestión de versiones", "Baja", "Desarrollo"),
                            new TaskInfo("Revisión de accesibilidad", "Baja", "Pruebas"),
                            new TaskInfo("Validación del diseño de interfaces", "Baja", "Pruebas"),
                            new TaskInfo("Evaluación de la modularidad", "Baja", "Análisis"),
                        }
                    },
                    {
                        "construccion", new List<TaskInfo>
                        {
                            // Alta Prioridad
                            new TaskInfo("Desarrollo de módulos clave", "Alta", "Desarrollo"),
                            new TaskInfo("Implementación de la base de datos", "Alta", "Desarrollo"),
                            new TaskInfo("Desarrollo de la interfaz de usuario", "Alta", "Desarrollo"),
                            new TaskInfo("Pruebas unitarias", "Alta", "Pruebas"),
                            new TaskInfo("Integración de componentes", "Alta", "Desarrollo"),
                            new TaskInfo("Optimización de rendimiento", "Alta", "Desarrollo"),
                            new TaskInfo("Implementación de la lógica de negocio", "Alta", "Desarrollo"),
                            new TaskInfo("Configuración de entornos de prueba", "Alta", "Pruebas"),
                            new TaskInfo("Integración de la base de datos", "Alta", "Desarrollo"),
                            new TaskInfo("Automatización de procesos", "Alta", "Desarrollo"),

                            // Media Prioridad
                            new TaskInfo("Ajustes de interfaz basados en feedback", "Media", "Desarrollo"),
                            new TaskInfo("Validaciones de seguridad de datos", "Media", "Desarrollo"),
                            new TaskInfo("Generación de informes y reportes", "Media", "Desarrollo"),
                            new TaskInfo("Documentación técnica del código", "Media", "Documentación"),
                            new TaskInfo("Automatización de pruebas unitarias", "Media", "Pruebas"),
                            new TaskInfo("Revisión de seguridad del sistema", "Media", "Pruebas"),
                            new TaskInfo("Validación de integración con sistemas externos", "Media", "Desarrollo"),
                            new TaskInfo("Desarrollo de herramientas de auditoría", "Media", "Desarrollo"),
                            new TaskInfo("Optimización de almacenamiento de datos", "Media", "Desarrollo"),
                            new TaskInfo("Implementación de gestión de fallos", "Media", "Desarrollo"),

                            // Baja Prioridad
                            new TaskInfo("Implementación de políticas de seguridad", "Baja", "Documentación"),
                            new TaskInfo("Pruebas de seguridad avanzadas", "Baja", "Pruebas"),
                            new TaskInfo("Monitoreo de actividad del sistema", "Baja", "Implementación"),
                            new TaskInfo("Verificación de resiliencia", "Baja", "Pruebas"),
                            new TaskInfo("Capacitación en prácticas de seguridad", "Baja", "Soporte"),
                            new TaskInfo("Configuración de backups automáticos", "Baja", "Implementación"),
                            new TaskInfo("Cumplimiento de normativas de seguridad", "Baja", "Documentación"),
                            new TaskInfo("Revisión técnica de la documentación", "Baja", "Documentación"),
                            new TaskInfo("Optimización de acceso a datos", "Baja", "Desarrollo"),
                            new TaskInfo("Revisión de cumplimiento normativo", "Baja", "Análisis"),
                        }
                    },
                    {
                        "transicion", new List<TaskInfo>
                        { 
                            // Alta Prioridad
                            new TaskInfo("Preparación para el despliegue en producción", "Alta", "Implementación"),
                            new TaskInfo("Pruebas de aceptación finales", "Alta", "Pruebas"),
                            new TaskInfo("Capacitación a usuarios finales", "Alta", "Soporte"),
                            new TaskInfo("Entrenamiento del equipo de soporte", "Alta", "Soporte"),
                            new TaskInfo("Documentación de usuario final", "Alta", "Documentación"),
                            new TaskInfo("Planificación del lanzamiento", "Alta", "Planificación"),
                            new TaskInfo("Verificación de cumplimiento normativo", "Alta", "Análisis"),
                            new TaskInfo("Despliegue en el entorno de producción", "Alta", "Implementación"),
                            new TaskInfo("Configuración del entorno de producción", "Alta", "Implementación"),
                            new TaskInfo("Evaluación de la satisfacción del cliente", "Alta", "Soporte"),

                            // Media Prioridad
                            new TaskInfo("Monitoreo post-despliegue", "Media", "Implementación"),
                            new TaskInfo("Análisis de feedback de usuarios", "Media", "Soporte"),
                            new TaskInfo("Implementación de mejoras sugeridas", "Media", "Desarrollo"),
                            new TaskInfo("Documentación de lecciones aprendidas", "Media", "Documentación"),
                            new TaskInfo("Revisión de la efectividad del soporte", "Media", "Soporte"),
                            new TaskInfo("Ajustes en la documentación técnica", "Media", "Documentación"),
                            new TaskInfo("Planificación de soporte a largo plazo", "Media", "Soporte"),
                            new TaskInfo("Evaluación de requisitos de mantenimiento", "Media", "Análisis"),
                            new TaskInfo("Revisión de cumplimiento de objetivos del proyecto", "Media", "Análisis"),
                            new TaskInfo("Optimización de procesos de entrega", "Media", "Implementación"),

                            // Baja Prioridad
                            new TaskInfo("Análisis de la experiencia del usuario", "Baja", "Soporte"),
                            new TaskInfo("Actualización de la formación del equipo", "Baja", "Soporte"),
                            new TaskInfo("Revisión de la documentación de soporte", "Baja", "Documentación"),
                            new TaskInfo("Implementación de mejoras en la capacitación", "Baja", "Soporte"),
                            new TaskInfo("Planificación de actualizaciones futuras", "Baja", "Planificación"),
                            new TaskInfo("Evaluación de la infraestructura de TI", "Baja", "Análisis"),
                            new TaskInfo("Creación de un plan de continuidad del negocio", "Baja", "Planificación"),
                            new TaskInfo("Revisión de estrategias de recuperación ante desastres", "Baja", "Planificación"),
                            new TaskInfo("Auditoría de cumplimiento post-despliegue", "Baja", "Análisis"),
                            new TaskInfo("Documentación de procesos de mantenimiento", "Baja", "Documentación"),
                        }
                    },
                }
            }
        };


        public void RecomendarISOInteractivo(string fase)
        {
            if (_fasePreguntas.TryGetValue(fase.ToLower(), out List<QuestionISO> preguntas))
            {
                Dictionary<string, int> isoScores = new Dictionary<string, int>
                {
                    { "ISO/IEC 12207", 0 },
                    { "ISO/IEC 20000", 0 },
                    { "ISO/IEC 25010", 0 },
                    { "ISO/IEC 27001", 0 },
                    { "ISO/IEC 29110", 0 }
                };

                Console.WriteLine(
    "Indicaciones: A continuación, se te presentarán una serie de preguntas diseñadas para identificar tus necesidades y recomendarte la norma ISO que mejor se adapta a tus objetivos. " +
    "Estas preguntas cubren aspectos clave, como el propósito de tu sistema o proceso, el sector en el que operas, y los principales desafíos o prioridades que deseas abordar. " +
    "Con base en tus respuestas, recibirás una recomendación de la norma ISO más adecuada para ayudarte a alcanzar tus metas de manera eficiente y cumplir con los estándares internacionales de calidad, seguridad, y gestión.\n" +
    $"\nFase del proyecto que has seleccionado: {fase}\n"
);


                foreach (var pregunta in preguntas)
                {
                    Console.WriteLine(pregunta.Pregunta);
                    string respuesta = Console.ReadLine()?.ToLower();

                    if (respuesta == "si")
                    {
                        isoScores[pregunta.RecomendacionISO]++;
                    }
                }

                // Encontrar la ISO recomendada
                var isoRecomendada = isoScores.OrderByDescending(x => x.Value).FirstOrDefault();

                Console.WriteLine($"La ISO recomendada es: {isoRecomendada.Key} con una puntuación de {isoRecomendada.Value}.");

                // Permitir al usuario elegir otra ISO
                Console.WriteLine("¿Desea trabajar con esta ISO recomendada o seleccionar otra? (recomendada/otra)");
                string seleccion = Console.ReadLine()?.ToLower();

                string isoSeleccionada = seleccion == "otra" ? ElegirOtraISO(isoScores) : isoRecomendada.Key;

                if (!string.IsNullOrEmpty(isoSeleccionada))
                {
                    MostrarTareas(isoSeleccionada, fase);
                }
            }
            else
            {
                Console.WriteLine("Fase no válida.");
            }
        }

        private string ElegirOtraISO(Dictionary<string, int> isoScores)
        {
            Console.WriteLine("Ingrese el nombre de la ISO que desea utilizar:");
            string otraISO = Console.ReadLine();

            if (isoScores.ContainsKey(otraISO))
            {
                Console.WriteLine($"Ha seleccionado trabajar con {otraISO}.");
                return otraISO;
            }
            else
            {
                Console.WriteLine("ISO no válida. Trabajando con la recomendada.");
                return null;
            }
        }

        private void MostrarTareas(string iso, string fase)
        {
            if (_isoTareas.TryGetValue(iso, out Dictionary<string, List<TaskInfo>> fasesTareas))
            {
                if (fasesTareas.TryGetValue(fase, out List<TaskInfo> tareas))
                {
                    Console.WriteLine($"Tareas recomendadas para {iso} en la fase de {fase}:");
                    foreach (var tarea in tareas)
                    {
                        Console.WriteLine($"- {tarea.Nombre} (Prioridad: {tarea.Prioridad}, Flujo de Trabajo: {tarea.FlujoTrabajo})");
                    }

                    Console.WriteLine("¿Desea seleccionar tareas para implementar? (sino)");
                    string seleccionarTareasRespuesta = Console.ReadLine()?.ToLower();
                    if (seleccionarTareasRespuesta == "si")
                    {
                        SeleccionarTareas(tareas);
                    }
                }
                else
                {
                    Console.WriteLine($"No se encontraron tareas para la fase de {fase} en {iso}.");
                }
            }
            else
            {
                Console.WriteLine("No se encontraron tareas para esta ISO.");
            }
        }

        private void SeleccionarTareas(List<TaskInfo> tareas)
        {
            List<string> tareasSeleccionadas = new List<string>();
            foreach (var tarea in tareas)
            {
                Console.WriteLine($"¿Desea implementar la tarea: {tarea.Nombre}? (sí/no)");
                string respuesta = Console.ReadLine()?.ToLower();
                if (respuesta == "si")
                {
                    tareasSeleccionadas.Add(tarea.Nombre);
                }
            }

            if (tareasSeleccionadas.Count > 0)
            {
                Console.WriteLine("Tareas seleccionadas para implementar:");
                foreach (var tarea in tareasSeleccionadas)
                {
                    Console.WriteLine($"- {tarea}");
                }
            }
            else
            {
                Console.WriteLine("No se seleccionaron tareas para implementar.");
            }
        }
    }

    public class QuestionISO
    {
        public string Pregunta { get; }
        public string RespuestaEsperada { get; }
        public string RecomendacionISO { get; }

        public QuestionISO(string pregunta, string respuestaEsperada, string recomendacionISO)
        {
            Pregunta = pregunta;
            RespuestaEsperada = respuestaEsperada;
            RecomendacionISO = recomendacionISO;
        }
    }

    public class TaskInfo
    {
        public string Nombre { get; }
        public string Prioridad { get; }
        public string FlujoTrabajo { get; }

        public TaskInfo(string nombre, string prioridad, string flujoTrabajo)
        {
            Nombre = nombre;
            Prioridad = prioridad;
            FlujoTrabajo = flujoTrabajo;
        }
    }
}