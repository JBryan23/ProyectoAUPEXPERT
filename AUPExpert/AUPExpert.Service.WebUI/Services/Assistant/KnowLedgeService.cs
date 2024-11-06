using AUPExpert.Service.WebUI.ViewModels;

namespace AUPExpert.Service.WebUI.Services.Assistant
{
    internal sealed class KnowLedgeService
    {
        public Dictionary<string, Dictionary<string, List<TaskInfoViewModel>>> Conocimiento { get => _conocimiento; }

        private readonly Dictionary<string, Dictionary<string, List<TaskInfoViewModel>>> _conocimiento = new ()
        {
            {
                "ISO/IEC 12207", new Dictionary<string, List<TaskInfoViewModel>>
                {
                    {
                        "inicio", new List<TaskInfoViewModel>
                        {
                            //Proridad alta 
                            new TaskInfoViewModel("Identificación de los interesados clave", "Alta", "Planificación"),
                            new TaskInfoViewModel("Definición de los objetivos del proyecto", "Alta", "Planificación"),
                            new TaskInfoViewModel("Establecimiento del alcance inicial del proyecto", "Alta", "Planificación"),
                            new TaskInfoViewModel("Revisión de los requisitos del cliente", "Alta", "Análisis"),
                            new TaskInfoViewModel("Análisis de viabilidad", "Alta", "Análisis"),
                            new TaskInfoViewModel("Definición de restricciones del proyecto", "Alta", "Planificación"),
                            new TaskInfoViewModel("Evaluación de riesgos iniciales", "Alta", "Análisis"),
                            new TaskInfoViewModel("Creación de un cronograma preliminar", "Alta", "Planificación"),
                            new TaskInfoViewModel("Asignación de recursos iniciales", "Alta", "Planificación"),
                            new TaskInfoViewModel("Aprobación de la fase de inicio por los stakeholders", "Alta", "Planificación"),
                            // Prioridad Media
                            new TaskInfoViewModel("Análisis de tecnologías viables", "Media", "Análisis"),
                            new TaskInfoViewModel("Revisión y validación de requisitos con usuarios", "Media", "Análisis"),
                            new TaskInfoViewModel("Creación del backlog inicial", "Media", "Planificación"),
                            new TaskInfoViewModel("Establecimiento de criterios de aceptación iniciales", "Media", "Análisis"),
                            new TaskInfoViewModel("Identificación de hitos clave", "Media", "Planificación"),
                            new TaskInfoViewModel("Selección de herramientas de gestión de proyectos", "Media", "Planificación"),
                            new TaskInfoViewModel("Definición de métricas de éxito", "Media", "Análisis"),
                            new TaskInfoViewModel("Evaluación de habilidades del equipo", "Media", "Análisis"),
                            new TaskInfoViewModel("Identificación de dependencias críticas", "Media", "Análisis"),
                            new TaskInfoViewModel("Definición de roles y responsabilidades", "Media", "Planificación"),

                            // Prioridad Baja
                            new TaskInfoViewModel("Documentación del alcance inicial", "Baja", "Documentación"),
                            new TaskInfoViewModel("Definición de un plan de comunicación", "Baja", "Planificación"),
                            new TaskInfoViewModel("Definición de políticas de calidad", "Baja", "Análisis"),
                            new TaskInfoViewModel("Análisis preliminar de costes", "Baja", "Análisis"),
                            new TaskInfoViewModel("Definición del entorno de desarrollo", "Baja", "Desarrollo"),
                            new TaskInfoViewModel("Evaluación de la compatibilidad con otros sistemas", "Baja", "Análisis"),
                            new TaskInfoViewModel("Creación de prototipos iniciales", "Baja", "Diseño"),
                            new TaskInfoViewModel("Planificación de sprints iniciales", "Baja", "Planificación"),
                            new TaskInfoViewModel("Definición de requisitos de soporte técnico", "Baja", "Soporte"),
                            new TaskInfoViewModel("Configuración de control de versiones", "Baja", "Desarrollo"),

                        }
                    },
                    {
                        "elaboracion", new List<TaskInfoViewModel>
                        {
                            // Fase de Elaboración          
                            // Prioridad Alta
                            new TaskInfoViewModel("Refinamiento de requisitos", "Alta", "Análisis"),
                            new TaskInfoViewModel("Validación de casos de uso", "Alta", "Pruebas"),
                            new TaskInfoViewModel("Diseño detallado de la arquitectura", "Alta", "Diseño"),
                            new TaskInfoViewModel("Evaluación de atributos de calidad", "Alta", "Análisis"),
                            new TaskInfoViewModel("Análisis de impacto de requisitos", "Alta", "Análisis"),
                            new TaskInfoViewModel("Desarrollo de prototipo evolutivo", "Alta", "Diseño"),
                            new TaskInfoViewModel("Diseño de módulos críticos", "Alta", "Diseño"),
                            new TaskInfoViewModel("Planificación de pruebas de integración", "Alta", "Pruebas"),
                            new TaskInfoViewModel("Estrategias de seguridad iniciales", "Alta", "Análisis"),
                            new TaskInfoViewModel("Definición de interfaces detalladas", "Alta", "Diseño"),

                            // Prioridad Media
                            new TaskInfoViewModel("Implementación de pruebas de rendimiento", "Media", "Pruebas"),
                            new TaskInfoViewModel("Optimización para escalabilidad", "Media", "Diseño"),
                            new TaskInfoViewModel("Revisión de interoperabilidad", "Media", "Análisis"),
                            new TaskInfoViewModel("Refinamiento de casos complejos", "Media", "Análisis"),
                            new TaskInfoViewModel("Gestión de errores y excepciones", "Media", "Análisis"),
                            new TaskInfoViewModel("Aprobación final de arquitectura", "Media", "Planificación"),
                            new TaskInfoViewModel("Evaluación de mantenibilidad", "Media", "Análisis"),
                            new TaskInfoViewModel("Desarrollo del modelo de datos", "Media", "Diseño"),
                            new TaskInfoViewModel("Estrategias de portabilidad", "Media", "Análisis"),
                            new TaskInfoViewModel("Estrategia de recuperación", "Media", "Planificación"),

                            // Prioridad Baja
                            new TaskInfoViewModel("Pruebas de seguridad iniciales", "Baja", "Pruebas"),
                            new TaskInfoViewModel("Validación del modelo de usabilidad", "Baja", "Pruebas"),
                            new TaskInfoViewModel("Capacidad de integración continua", "Baja", "Desarrollo"),
                            new TaskInfoViewModel("Resiliencia ante fallos", "Baja", "Pruebas"),
                            new TaskInfoViewModel("Sistema de monitoreo inicial", "Baja", "Implementación"),
                            new TaskInfoViewModel("Refinamiento del modelo de datos físico", "Baja", "Diseño"),
                            new TaskInfoViewModel("Gestión de versiones", "Baja", "Desarrollo"),
                            new TaskInfoViewModel("Accesibilidad del sistema", "Baja", "Pruebas"),
                            new TaskInfoViewModel("Validación de diseño de interfaces", "Baja", "Pruebas"),
                            new TaskInfoViewModel("Evaluación de modularidad", "Baja", "Análisis"),

                        }
                    },
                    {
                        "construccion", new List<TaskInfoViewModel>
                        {
                            // Fase de Construcción
                            // Prioridad Alta
                            new TaskInfoViewModel("Implementación de módulos clave", "Alta", "Desarrollo"),
                            new TaskInfoViewModel("Desarrollo de la base de datos", "Alta", "Desarrollo"),
                            new TaskInfoViewModel("Codificación de interfaz de usuario", "Alta", "Desarrollo"),
                            new TaskInfoViewModel("Pruebas unitarias", "Alta", "Pruebas"),
                            new TaskInfoViewModel("Integración continua", "Alta", "Desarrollo"),
                            new TaskInfoViewModel("Optimización de rendimiento", "Alta", "Desarrollo"),
                            new TaskInfoViewModel("Implementación de lógica de negocio", "Alta", "Desarrollo"),
                            new TaskInfoViewModel("Codificación de algoritmos específicos", "Alta", "Desarrollo"),
                            new TaskInfoViewModel("Configuración de entorno de pruebas", "Alta", "Pruebas"),
                            new TaskInfoViewModel("Integración de la base de datos", "Alta", "Desarrollo"),

                            // Prioridad Media
                            new TaskInfoViewModel("Ajuste de interfaz gráfica", "Media", "Desarrollo"),
                            new TaskInfoViewModel("Validaciones de entrada", "Media", "Desarrollo"),
                            new TaskInfoViewModel("Generación de informes de salida", "Media", "Desarrollo"),
                            new TaskInfoViewModel("Documentación de código fuente", "Media", "Documentación"),
                            new TaskInfoViewModel("Automatización de pruebas", "Media", "Pruebas"),
                            new TaskInfoViewModel("Revisión de seguridad", "Media", "Pruebas"),
                            new TaskInfoViewModel("Integración con sistemas externos", "Media", "Desarrollo"),
                            new TaskInfoViewModel("Desarrollo de herramientas de auditoría", "Media", "Desarrollo"),
                            new TaskInfoViewModel("Optimización de almacenamiento", "Media", "Desarrollo"),
                            new TaskInfoViewModel("Gestión de fallos", "Media", "Desarrollo"),

                            // Prioridad Baja
                            new TaskInfoViewModel("Revisión de políticas de seguridad", "Baja", "Documentación"),
                            new TaskInfoViewModel("Pruebas de penetración", "Baja", "Pruebas"),
                            new TaskInfoViewModel("Monitoreo de transacciones", "Baja", "Implementación"),
                            new TaskInfoViewModel("Verificación de resiliencia", "Baja", "Pruebas"),
                            new TaskInfoViewModel("Auditoría de actividades", "Baja", "Soporte"),
                            new TaskInfoViewModel("Capacitación en seguridad", "Baja", "Soporte"),
                            new TaskInfoViewModel("Implementación de backups", "Baja", "Implementación"),
                            new TaskInfoViewModel("Cumplimiento de normativas de seguridad", "Baja", "Documentación"),
                            new TaskInfoViewModel("Documentación técnica", "Baja", "Documentación"),
                            new TaskInfoViewModel("Optimización de acceso a datos", "Baja", "Desarrollo"),
                        }
                    },
                    {
                        "Transicion", new List<TaskInfoViewModel>
                        {
                            // Agregar tareas para la fase de transición
                            // Prioridad Alta
                            new TaskInfoViewModel("Despliegue en producción", "Alta", "Implementación"),
                            new TaskInfoViewModel("Validación en producción", "Alta", "Pruebas"),
                            new TaskInfoViewModel("Capacitación a usuarios", "Alta", "Soporte"),
                            new TaskInfoViewModel("Capacitación a soporte", "Alta", "Soporte"),
                            new TaskInfoViewModel("Pruebas de aceptación", "Alta", "Pruebas"),
                            new TaskInfoViewModel("Documentación de procesos", "Alta", "Documentación"),
                            new TaskInfoViewModel("Aprobación de operaciones", "Alta", "Planificación"),
                            new TaskInfoViewModel("Migración de datos", "Alta", "Implementación"),
                            new TaskInfoViewModel("Soporte inicial", "Alta", "Soporte"),
                            new TaskInfoViewModel("Implementación de respaldo", "Alta", "Implementación"),

                            // Prioridad Media
                            new TaskInfoViewModel("Optimización de rendimiento en producción", "Media", "Implementación"),
                            new TaskInfoViewModel("Configuración de respaldo", "Media", "Implementación"),
                            new TaskInfoViewModel("Plan de contingencia", "Media", "Planificación"),
                            new TaskInfoViewModel("Migración de datos", "Media", "Implementación"),
                            new TaskInfoViewModel("Asistencia en transición", "Media", "Soporte"),
                            new TaskInfoViewModel("Documentación de operaciones", "Media", "Documentación"),
                            new TaskInfoViewModel("Estrategia de continuidad", "Media", "Planificación"),
                            new TaskInfoViewModel("Validación de integridad de datos", "Media", "Pruebas"),
                            new TaskInfoViewModel("Pruebas de carga", "Media", "Pruebas"),
                            new TaskInfoViewModel("Configuración de monitoreo", "Media", "Implementación"),

                            // Prioridad Baja
                            new TaskInfoViewModel("Revisión post-implementación", "Baja", "Análisis"),
                            new TaskInfoViewModel("Ajustes según feedback", "Baja", "Implementación"),
                            new TaskInfoViewModel("Actualización de soporte", "Baja", "Soporte"),
                            new TaskInfoViewModel("Gestión de versiones", "Baja", "Desarrollo"),
                            new TaskInfoViewModel("Monitoreo de SLA", "Baja", "Soporte"),
                            new TaskInfoViewModel("Configuración de mesa de ayuda", "Baja", "Soporte"),
                            new TaskInfoViewModel("Base de conocimiento", "Baja", "Documentación"),
                            new TaskInfoViewModel("Recuperación ante desastres", "Baja", "Soporte"),
                            new TaskInfoViewModel("Plan de mantenimiento", "Baja", "Planificación"),
                            new TaskInfoViewModel("Desactivación de versiones anteriores", "Baja", "Implementación"),

                        }
                    }
                }
            },
            {
                "ISO/IEC 20000", new Dictionary<string, List<TaskInfoViewModel>>
            {
                {
                        "inicio", new List<TaskInfoViewModel>
                        {
                           // Prioridad Alta
                            new TaskInfoViewModel("Identificación de servicios clave", "Alta", "Planificación"),
                            new TaskInfoViewModel("Establecimiento de objetivos de nivel de servicio (SLAs)", "Alta", "Planificación"),
                            new TaskInfoViewModel("Análisis de necesidades del cliente", "Alta", "Análisis"),
                            new TaskInfoViewModel("Definición de alcance de los servicios", "Alta", "Planificación"),
                            new TaskInfoViewModel("Evaluación de riesgos en la provisión de servicios", "Alta", "Análisis"),
                            new TaskInfoViewModel("Asignación de roles de gestión de servicios", "Alta", "Planificación"),
                            new TaskInfoViewModel("Definición de métricas de desempeño de servicios", "Alta", "Planificación"),
                            new TaskInfoViewModel("Creación de un plan de comunicación de servicios", "Alta", "Planificación"),
                            new TaskInfoViewModel("Análisis de viabilidad de SLAs", "Alta", "Análisis"),
                            new TaskInfoViewModel("Documentación de los requisitos de servicio iniciales", "Alta", "Documentación"),

                            // Prioridad Media
                            new TaskInfoViewModel("Identificación de puntos críticos de contacto", "Media", "Análisis"),
                            new TaskInfoViewModel("Definición de procedimientos de solicitud de servicio", "Media", "Planificación"),
                            new TaskInfoViewModel("Evaluación de proveedores de servicio externos", "Media", "Análisis"),
                            new TaskInfoViewModel("Definición de políticas de soporte y asistencia", "Media", "Planificación"),
                            new TaskInfoViewModel("Definición de niveles de prioridad en incidentes", "Media", "Análisis"),
                            new TaskInfoViewModel("Desarrollo de un plan de respaldo de datos", "Media", "Planificación"),
                            new TaskInfoViewModel("Establecimiento de una política de recuperación de desastres", "Media", "Planificación"),
                            new TaskInfoViewModel("Creación de un sistema de gestión de cambios", "Media", "Planificación"),
                            new TaskInfoViewModel("Establecimiento de roles y responsabilidades en servicios", "Media", "Planificación"),
                            new TaskInfoViewModel("Evaluación de compatibilidad de servicios con infraestructura existente", "Media", "Análisis"),

                            // Prioridad Baja
                            new TaskInfoViewModel("Definición de requisitos de formación en servicios", "Baja", "Planificación"),
                            new TaskInfoViewModel("Evaluación de políticas de acceso y seguridad en servicios", "Baja", "Análisis"),
                            new TaskInfoViewModel("Documentación de mejores prácticas en la gestión de servicios", "Baja", "Documentación"),
                            new TaskInfoViewModel("Creación de un sistema de registro de incidentes", "Baja", "Planificación"),
                            new TaskInfoViewModel("Análisis de impacto de los servicios en el usuario final", "Baja", "Análisis"),
                            new TaskInfoViewModel("Identificación de posibles mejoras en servicios", "Baja", "Análisis"),
                            new TaskInfoViewModel("Establecimiento de un plan de capacitación de usuarios", "Baja", "Planificación"),
                            new TaskInfoViewModel("Planificación de auditorías internas de servicios", "Baja", "Planificación"),
                            new TaskInfoViewModel("Evaluación de costos de los servicios", "Baja", "Análisis"),
                            new TaskInfoViewModel("Definición de requisitos de accesibilidad", "Baja", "Análisis"),

                        }
                },

                    {
                        "elaboracion", new List<TaskInfoViewModel>
                        {
                            // Agregar tareas para la fase de elaboración
                            // Prioridad Alta
                            new TaskInfoViewModel("Diseño de la estructura de soporte", "Alta", "Diseño"),
                            new TaskInfoViewModel("Establecimiento de controles de cumplimiento de SLAs", "Alta", "Planificación"),
                            new TaskInfoViewModel("Desarrollo de procedimientos de gestión de incidentes", "Alta", "Diseño"),
                            new TaskInfoViewModel("Planificación de pruebas de servicio", "Alta", "Pruebas"),
                            new TaskInfoViewModel("Diseño de políticas de gestión de problemas", "Alta", "Diseño"),
                            new TaskInfoViewModel("Implementación de criterios de escalabilidad en servicios", "Alta", "Diseño"),
                            new TaskInfoViewModel("Establecimiento de medidas de recuperación de datos", "Alta", "Diseño"),
                            new TaskInfoViewModel("Desarrollo de plan de soporte técnico en línea", "Alta", "Planificación"),
                            new TaskInfoViewModel("Definición de roles de escalamiento en incidentes", "Alta", "Planificación"),
                            new TaskInfoViewModel("Implementación de procesos de control de calidad en servicios", "Alta", "Planificación"),

                            // Prioridad Media
                            new TaskInfoViewModel("Evaluación de capacidad de servicios", "Media", "Análisis"),
                            new TaskInfoViewModel("Definición de métricas de desempeño de servicios", "Media", "Análisis"),
                            new TaskInfoViewModel("Pruebas de recuperación ante fallos", "Media", "Pruebas"),
                            new TaskInfoViewModel("Simulación de incidentes", "Media", "Pruebas"),
                            new TaskInfoViewModel("Planificación de auditorías de calidad de servicio", "Media", "Planificación"),
                            new TaskInfoViewModel("Creación de documentación de soporte técnico", "Media", "Documentación"),
                            new TaskInfoViewModel("Definición de flujos de trabajo en gestión de incidentes", "Media", "Diseño"),
                            new TaskInfoViewModel("Gestión de dependencias en servicios", "Media", "Análisis"),
                            new TaskInfoViewModel("Implementación de pruebas de carga", "Media", "Pruebas"),
                            new TaskInfoViewModel("Optimización de tiempos de respuesta", "Media", "Diseño"),

                            // Prioridad Baja
                            new TaskInfoViewModel("Documentación de políticas de gestión de cambios", "Baja", "Documentación"),
                            new TaskInfoViewModel("Definición de un plan de actualización de servicios", "Baja", "Planificación"),
                            new TaskInfoViewModel("Pruebas de accesibilidad en servicios", "Baja", "Pruebas"),
                            new TaskInfoViewModel("Desarrollo de informes de desempeño de servicios", "Baja", "Documentación"),
                            new TaskInfoViewModel("Revisión de escalabilidad en diseño", "Baja", "Análisis"),
                            new TaskInfoViewModel("Evaluación de la sostenibilidad de los servicios", "Baja", "Análisis"),
                            new TaskInfoViewModel("Establecimiento de métricas de satisfacción del cliente", "Baja", "Planificación"),
                            new TaskInfoViewModel("Revisión de compatibilidad de servicio con otros sistemas", "Baja", "Análisis"),
                            new TaskInfoViewModel("Planificación de actualización de hardware para soporte de servicios", "Baja", "Planificación"),
                            new TaskInfoViewModel("Definición de un plan de entrenamiento para el equipo de soporte", "Baja", "Planificación"),

                        }
                    },
                    {
                        "construccion", new List<TaskInfoViewModel>
                        {
                            // Agregar tareas para la fase de construcción
                            // Prioridad Alta
                            new TaskInfoViewModel("Implementación de la estructura de soporte", "Alta", "Desarrollo"),
                            new TaskInfoViewModel("Desarrollo de la mesa de ayuda", "Alta", "Desarrollo"),
                            new TaskInfoViewModel("Implementación de SLAs en producción", "Alta", "Implementación"),
                            new TaskInfoViewModel("Pruebas de aceptación del servicio", "Alta", "Pruebas"),
                            new TaskInfoViewModel("Implementación de controles de calidad en servicios", "Alta", "Implementación"),
                            new TaskInfoViewModel("Configuración de un sistema de monitoreo de servicios", "Alta", "Implementación"),
                            new TaskInfoViewModel("Automatización de procesos de gestión de incidentes", "Alta", "Desarrollo"),
                            new TaskInfoViewModel("Documentación de soporte técnico", "Alta", "Documentación"),
                            new TaskInfoViewModel("Configuración de medidas de escalamiento en incidentes", "Alta", "Implementación"),
                            new TaskInfoViewModel("Implementación de controles de recuperación de datos", "Alta", "Implementación"),

                            // Prioridad Media
                            new TaskInfoViewModel("Evaluación de rendimiento de soporte", "Media", "Análisis"),
                            new TaskInfoViewModel("Pruebas de continuidad del servicio", "Media", "Pruebas"),
                            new TaskInfoViewModel("Desarrollo de documentación de procesos de soporte", "Media", "Documentación"),
                            new TaskInfoViewModel("Optimización de recursos en soporte", "Media", "Desarrollo"),
                            new TaskInfoViewModel("Simulación de fallos en soporte", "Media", "Pruebas"),
                            new TaskInfoViewModel("Validación de recuperación de datos", "Media", "Pruebas"),
                            new TaskInfoViewModel("Pruebas de capacidad de escalamiento en producción", "Media", "Pruebas"),
                            new TaskInfoViewModel("Documentación de métricas de desempeño de soporte", "Media", "Documentación"),
                            new TaskInfoViewModel("Optimización de tiempo de respuesta en soporte", "Media", "Desarrollo"),
                            new TaskInfoViewModel("Implementación de mejoras en el flujo de trabajo de soporte", "Media", "Desarrollo"),

                            // Prioridad Baja
                            new TaskInfoViewModel("Revisión de políticas de escalamiento en soporte", "Baja", "Documentación"),
                            new TaskInfoViewModel("Implementación de procesos de mantenimiento preventivo", "Baja", "Implementación"),
                            new TaskInfoViewModel("Evaluación de usabilidad del sistema de soporte", "Baja", "Pruebas"),
                            new TaskInfoViewModel("Documentación de acuerdos de nivel de servicio (SLAs)", "Baja", "Documentación"),
                            new TaskInfoViewModel("Revisión de herramientas de soporte técnico", "Baja", "Análisis"),
                            new TaskInfoViewModel("Establecimiento de métricas de eficiencia del soporte", "Baja", "Planificación"),
                            new TaskInfoViewModel("Pruebas de compatibilidad de soporte en diferentes plataformas", "Baja", "Pruebas"),
                            new TaskInfoViewModel("Evaluación de seguridad en la gestión de soporte", "Baja", "Pruebas"),
                            new TaskInfoViewModel("Planificación de actualizaciones en soporte", "Baja", "Planificación"),
                            new TaskInfoViewModel("Gestión de versiones en sistemas de soporte", "Baja", "Desarrollo"),

                        }
                    },
                    {
                        "Transicion", new List<TaskInfoViewModel>
                        {
                            // Agregar tareas para la fase de transición
                            // Prioridad Alta
                            new TaskInfoViewModel("Preparación del entorno de producción", "Alta", "Implementación"),
                            new TaskInfoViewModel("Pruebas de aceptación finales", "Alta", "Pruebas"),
                            new TaskInfoViewModel("Despliegue de servicios en producción", "Alta", "Implementación"),
                            new TaskInfoViewModel("Capacitación en soporte para usuarios finales", "Alta", "Soporte"),
                            new TaskInfoViewModel("Implementación de sistema de soporte continuo", "Alta", "Implementación"),
                            new TaskInfoViewModel("Configuración de monitoreo en producción", "Alta", "Implementación"),
                            new TaskInfoViewModel("Migración de datos al entorno de producción", "Alta", "Implementación"),
                            new TaskInfoViewModel("Configuración de copias de seguridad de producción", "Alta", "Implementación"),
                            new TaskInfoViewModel("Creación de procedimientos de gestión de incidentes en producción", "Alta", "Documentación"),
                            new TaskInfoViewModel("Definición de métricas de satisfacción del cliente", "Alta", "Planificación"),

                            // Prioridad Media
                            new TaskInfoViewModel("Optimización de tiempo de respuesta en producción", "Media", "Implementación"),
                            new TaskInfoViewModel("Establecimiento de planes de contingencia en producción", "Media", "Planificación"),
                            new TaskInfoViewModel("Documentación de procedimientos operativos", "Media", "Documentación"),
                            new TaskInfoViewModel("Pruebas de carga y rendimiento en producción", "Media", "Pruebas"),
                            new TaskInfoViewModel("Validación de accesibilidad en producción", "Media", "Pruebas"),
                            new TaskInfoViewModel("Pruebas de usabilidad para usuarios finales", "Media", "Pruebas"),
                            new TaskInfoViewModel("Gestión de cambio en producción", "Media", "Planificación"),
                            new TaskInfoViewModel("Establecimiento de un canal de feedback", "Media", "Soporte"),
                            new TaskInfoViewModel("Configuración de métricas de servicio en producción", "Media", "Implementación"),
                            new TaskInfoViewModel("Definición de un sistema de resolución de incidencias", "Media", "Planificación"),

                            // Prioridad Baja
                            new TaskInfoViewModel("Evaluación de seguridad post-implementación", "Baja", "Análisis"),
                            new TaskInfoViewModel("Revisión de procesos de soporte en producción", "Baja", "Soporte"),
                            new TaskInfoViewModel("Optimización de uso de recursos en producción", "Baja", "Implementación"),
                            new TaskInfoViewModel("Monitoreo de métricas de satisfacción del cliente", "Baja", "Soporte"),
                            new TaskInfoViewModel("Revisión y actualización de SLAs", "Baja", "Documentación"),
                            new TaskInfoViewModel("Actualización de procedimientos de calidad", "Baja", "Documentación"),
                            new TaskInfoViewModel("Evaluación de planes de mejora continua", "Baja", "Planificación"),
                            new TaskInfoViewModel("Documentación de lecciones aprendidas", "Baja", "Documentación"),
                            new TaskInfoViewModel("Análisis de rendimiento en diferentes entornos", "Baja", "Pruebas"),
                            new TaskInfoViewModel("Planificación de futuras actualizaciones", "Baja", "Planificación"),

                        }
                    }
                }

            },
            {
                "ISO/IEC 25010", new Dictionary<string, List<TaskInfoViewModel>>
            {
                {
                        "inicio", new List<TaskInfoViewModel>
                        {
                            // Prioridad Alta
                            new TaskInfoViewModel("Definición de requisitos de calidad", "Alta", "Análisis"),
                            new TaskInfoViewModel("Identificación de interesados clave", "Alta", "Planificación"),
                            new TaskInfoViewModel("Establecimiento de estándares de calidad", "Alta", "Planificación"),
                            new TaskInfoViewModel("Evaluación de necesidades de calidad del cliente", "Alta", "Análisis"),
                            new TaskInfoViewModel("Priorización de atributos de calidad", "Alta", "Planificación"),
                            new TaskInfoViewModel("Identificación de limitaciones técnicas para la calidad", "Alta", "Análisis"),
                            new TaskInfoViewModel("Análisis de impacto de calidad", "Alta", "Análisis"),
                            new TaskInfoViewModel("Definición de objetivos de usabilidad", "Alta", "Planificación"),
                            new TaskInfoViewModel("Definición de métricas de calidad", "Alta", "Planificación"),
                            new TaskInfoViewModel("Documentación de requisitos de calidad", "Alta", "Documentación"),

                            // Prioridad Media
                            new TaskInfoViewModel("Revisión de estándares de calidad existentes", "Media", "Documentación"),
                            new TaskInfoViewModel("Definición de criterios de aceptación de calidad", "Media", "Análisis"),
                            new TaskInfoViewModel("Definición de roles y responsabilidades para la calidad", "Media", "Planificación"),
                            new TaskInfoViewModel("Análisis de compatibilidad de calidad", "Media", "Análisis"),
                            new TaskInfoViewModel("Creación de un prototipo inicial centrado en la calidad", "Media", "Diseño"),
                            new TaskInfoViewModel("Evaluación de herramientas de medición de calidad", "Media", "Análisis"),
                            new TaskInfoViewModel("Establecimiento de un plan de validación de calidad", "Media", "Planificación"),
                            new TaskInfoViewModel("Definición de características de accesibilidad", "Media", "Análisis"),
                            new TaskInfoViewModel("Definición de políticas de control de calidad", "Media", "Planificación"),
                            new TaskInfoViewModel("Establecimiento de mecanismos de feedback del usuario", "Media", "Planificación"),

                            // Prioridad Baja
                            new TaskInfoViewModel("Documentación de mejores prácticas de calidad", "Baja", "Documentación"),
                            new TaskInfoViewModel("Análisis de seguridad inicial", "Baja", "Análisis"),
                            new TaskInfoViewModel("Evaluación de impacto de la calidad en el tiempo de desarrollo", "Baja", "Análisis"),
                            new TaskInfoViewModel("Evaluación de la facilidad de mantenimiento", "Baja", "Análisis"),
                            new TaskInfoViewModel("Revisión de requisitos no funcionales", "Baja", "Documentación"),
                            new TaskInfoViewModel("Evaluación de riesgos de calidad", "Baja", "Análisis"),
                            new TaskInfoViewModel("Establecimiento de un sistema de control de cambios", "Baja", "Planificación"),
                            new TaskInfoViewModel("Estudio de la reusabilidad de componentes", "Baja", "Análisis"),
                            new TaskInfoViewModel("Análisis de eficiencia de recursos", "Baja", "Análisis"),
                            new TaskInfoViewModel("Establecimiento de un plan de recuperación ante fallos de calidad", "Baja", "Planificación"),


                        }
                },

                    {
                        "elaboracion", new List<TaskInfoViewModel>
                        {
                            // Agregar tareas para la fase de elaboración
                            // Prioridad Alta
                            new TaskInfoViewModel("Definición de arquitectura", "Alta", "Diseño"),
                            new TaskInfoViewModel("Identificación de atributos críticos de calidad", "Alta", "Análisis"),
                            new TaskInfoViewModel("Validación de requisitos funcionales", "Alta", "Pruebas"),
                            new TaskInfoViewModel("Escenarios de calidad críticos", "Alta", "Pruebas"),
                            new TaskInfoViewModel("Análisis de requisitos no funcionales", "Alta", "Análisis"),
                            new TaskInfoViewModel("Implementación de prototipos", "Alta", "Diseño"),
                            new TaskInfoViewModel("Diseño modular y reusabilidad", "Alta", "Diseño"),
                            new TaskInfoViewModel("Pruebas de integración tempranas", "Alta", "Pruebas"),
                            new TaskInfoViewModel("Estrategia de seguridad", "Alta", "Análisis"),
                            new TaskInfoViewModel("Interfaces centradas en accesibilidad", "Alta", "Diseño"),

                            // Prioridad Media
                            new TaskInfoViewModel("Pruebas de rendimiento", "Media", "Pruebas"),
                            new TaskInfoViewModel("Escalabilidad de la arquitectura", "Media", "Análisis"),
                            new TaskInfoViewModel("Interoperabilidad", "Media", "Análisis"),
                            new TaskInfoViewModel("Refinamiento de casos complejos", "Media", "Análisis"),
                            new TaskInfoViewModel("Plan de gestión de errores", "Media", "Análisis"),
                            new TaskInfoViewModel("Aprobación final de arquitectura", "Media", "Planificación"),
                            new TaskInfoViewModel("Facilidad de mantenimiento", "Media", "Análisis"),
                            new TaskInfoViewModel("Modelo lógico de datos", "Media", "Diseño"),
                            new TaskInfoViewModel("Estrategia de portabilidad", "Media", "Análisis"),
                            new TaskInfoViewModel("Estrategia de recuperación", "Media", "Planificación"),

                            // Prioridad Baja
                            new TaskInfoViewModel("Pruebas iniciales de resiliencia", "Baja", "Pruebas"),
                            new TaskInfoViewModel("Validación de calidad en prototipos alternativos", "Baja", "Pruebas"),
                            new TaskInfoViewModel("Revisión de modularidad en diseño", "Baja", "Análisis"),
                            new TaskInfoViewModel("Documentación de prácticas de diseño para calidad", "Baja", "Documentación"),
                            new TaskInfoViewModel("Pruebas de compatibilidad de calidad en plataformas diversas", "Baja", "Pruebas"),
                            new TaskInfoViewModel("Evaluación de usabilidad con muestras de usuarios", "Baja", "Pruebas"),
                            new TaskInfoViewModel("Simulación de escenarios de carga", "Baja", "Pruebas"),
                            new TaskInfoViewModel("Validación de requisitos no funcionales secundarios", "Baja", "Pruebas"),
                            new TaskInfoViewModel("Evaluación de facilidad de mantenimiento", "Baja", "Análisis"),
                            new TaskInfoViewModel("Revisión de estándares de seguridad en diseño", "Baja", "Análisis"),

                        }
                    },
                    {
                        "construccion", new List<TaskInfoViewModel>
                        {
                            // Agregar tareas para la fase de construcción
                            // Prioridad Alta
                            new TaskInfoViewModel("Implementación de requisitos de calidad en módulos críticos", "Alta", "Desarrollo"),
                            new TaskInfoViewModel("Pruebas de calidad en componentes individuales", "Alta", "Pruebas"),
                            new TaskInfoViewModel("Integración de criterios de usabilidad en la interfaz de usuario", "Alta", "Desarrollo"),
                            new TaskInfoViewModel("Validación de rendimiento", "Alta", "Pruebas"),
                            new TaskInfoViewModel("Pruebas de funcionalidad y eficiencia en módulos principales", "Alta", "Pruebas"),
                            new TaskInfoViewModel("Implementación de accesibilidad en la interfaz de usuario", "Alta", "Desarrollo"),
                            new TaskInfoViewModel("Documentación de calidad de código", "Alta", "Documentación"),
                            new TaskInfoViewModel("Automatización de pruebas de calidad", "Alta", "Pruebas"),
                            new TaskInfoViewModel("Optimización del uso de recursos", "Alta", "Desarrollo"),
                            new TaskInfoViewModel("Pruebas de escalabilidad del sistema", "Alta", "Pruebas"),

                            // Prioridad Media
                            new TaskInfoViewModel("Pruebas de seguridad en el sistema", "Media", "Pruebas"),
                            new TaskInfoViewModel("Implementación de modularidad", "Media", "Desarrollo"),
                            new TaskInfoViewModel("Optimización de tiempo de respuesta", "Media", "Desarrollo"),
                            new TaskInfoViewModel("Configuración de herramientas de monitoreo de calidad", "Media", "Implementación"),
                            new TaskInfoViewModel("Validación de consistencia de datos", "Media", "Pruebas"),
                            new TaskInfoViewModel("Creación de informes de calidad", "Media", "Documentación"),
                            new TaskInfoViewModel("Documentación técnica detallada de los módulos", "Media", "Documentación"),
                            new TaskInfoViewModel("Validación de portabilidad", "Media", "Pruebas"),
                            new TaskInfoViewModel("Optimización de recursos de almacenamiento", "Media", "Desarrollo"),
                            new TaskInfoViewModel("Implementación de medidas de recuperación ante fallos", "Media", "Desarrollo"),

                            // Prioridad Baja
                            new TaskInfoViewModel("Pruebas de compatibilidad en diferentes plataformas", "Baja", "Pruebas"),
                            new TaskInfoViewModel("Validación de interfaces de usuario alternativas", "Baja", "Pruebas"),
                            new TaskInfoViewModel("Gestión de la reusabilidad de código", "Baja", "Desarrollo"),
                            new TaskInfoViewModel("Monitoreo del uso de recursos durante la ejecución", "Baja", "Implementación"),
                            new TaskInfoViewModel("Revisión de métricas de calidad de software", "Baja", "Análisis"),
                            new TaskInfoViewModel("Documentación de procesos de desarrollo de calidad", "Baja", "Documentación"),
                            new TaskInfoViewModel("Pruebas de calidad de imagen y sonido", "Baja", "Pruebas"),
                            new TaskInfoViewModel("Optimización del rendimiento en dispositivos móviles", "Baja", "Desarrollo"),
                            new TaskInfoViewModel("Validación de opciones de configuración de calidad", "Baja", "Pruebas"),
                            new TaskInfoViewModel("Pruebas de mantenimiento y actualizaciones", "Baja", "Pruebas"),

                        }
                    },
                    {
                        "Transicion", new List<TaskInfoViewModel>
                        {
                            // Agregar tareas para la fase de transición
                            // Prioridad Alta
                            new TaskInfoViewModel("Validación de calidad en producción", "Alta", "Pruebas"),
                            new TaskInfoViewModel("Implementación de monitoreo de calidad en tiempo real", "Alta", "Implementación"),
                            new TaskInfoViewModel("Capacitación a usuarios en prácticas de calidad", "Alta", "Soporte"),
                            new TaskInfoViewModel("Pruebas de aceptación enfocadas en la calidad", "Alta", "Pruebas"),
                            new TaskInfoViewModel("Implementación de medidas de recuperación en producción", "Alta", "Implementación"),
                            new TaskInfoViewModel("Documentación de calidad de operaciones", "Alta", "Documentación"),
                            new TaskInfoViewModel("Establecimiento de acuerdos de calidad con clientes (SLAs)", "Alta", "Planificación"),
                            new TaskInfoViewModel("Validación de integridad de datos en producción", "Alta", "Pruebas"),
                            new TaskInfoViewModel("Implementación de monitoreo de rendimiento en producción", "Alta", "Implementación"),
                            new TaskInfoViewModel("Ajustes de configuración para optimización de calidad", "Alta", "Implementación"),

                            // Prioridad Media
                            new TaskInfoViewModel("Documentación de métricas de rendimiento", "Media", "Documentación"),
                            new TaskInfoViewModel("Evaluación de la escalabilidad en producción", "Media", "Análisis"),
                            new TaskInfoViewModel("Soporte inicial para resolución de problemas de calidad", "Media", "Soporte"),
                            new TaskInfoViewModel("Validación de la accesibilidad en producción", "Media", "Pruebas"),
                            new TaskInfoViewModel("Evaluación de usabilidad en producción", "Media", "Pruebas"),
                            new TaskInfoViewModel("Implementación de auditorías de calidad periódicas", "Media", "Planificación"),
                            new TaskInfoViewModel("Monitoreo de SLA de calidad", "Media", "Soporte"),
                            new TaskInfoViewModel("Optimización de tiempos de respuesta en producción", "Media", "Implementación"),
                            new TaskInfoViewModel("Validación de modularidad en producción", "Media", "Pruebas"),
                            new TaskInfoViewModel("Documentación de recomendaciones de mejora de calidad", "Media", "Documentación"),

                            // Prioridad Baja
                            new TaskInfoViewModel("Revisión post-implementación de calidad", "Baja", "Análisis"),
                            new TaskInfoViewModel("Actualización de procedimientos de calidad en producción", "Baja", "Documentación"),
                            new TaskInfoViewModel("Gestión de versiones de calidad en producción", "Baja", "Desarrollo"),
                            new TaskInfoViewModel("Optimización de recursos en producción", "Baja", "Implementación"),
                            new TaskInfoViewModel("Planificación de mejoras continuas de calidad", "Baja", "Planificación"),
                            new TaskInfoViewModel("Capacitación en mantenimiento de calidad para el equipo de soporte", "Baja", "Soporte"),
                            new TaskInfoViewModel("Monitoreo de métricas de satisfacción del usuario", "Baja", "Implementación"),
                            new TaskInfoViewModel("Evaluación de actualizaciones de calidad", "Baja", "Análisis"),
                            new TaskInfoViewModel("Desactivación de configuraciones antiguas de baja calidad", "Baja", "Implementación"),
                            new TaskInfoViewModel("Generación de reportes de impacto de calidad", "Baja", "Documentación"),

                        }
                    }
                }
            },
            {
                "ISO/IEC 27001", new Dictionary<string, List<TaskInfoViewModel>>
                {
                    {
                        "inicio", new List<TaskInfoViewModel>
                        {
                            // Prioridad Alta
                            new TaskInfoViewModel("Identificación de riesgos de seguridad", "Alta", "Análisis"),
                            new TaskInfoViewModel("Definición de objetivos de seguridad", "Alta", "Planificación"),
                            new TaskInfoViewModel("Establecimiento de políticas de seguridad", "Alta", "Planificación"),
                            new TaskInfoViewModel("Asignación de roles de seguridad", "Alta", "Planificación"),
                            new TaskInfoViewModel("Análisis de viabilidad de controles de seguridad", "Alta", "Análisis"),
                            new TaskInfoViewModel("Evaluación de cumplimiento normativo", "Alta", "Análisis"),
                            new TaskInfoViewModel("Definición de requisitos de autenticación", "Alta", "Análisis"),
                            new TaskInfoViewModel("Identificación de activos críticos", "Alta", "Análisis"),
                            new TaskInfoViewModel("Establecimiento de un plan de respuesta a incidentes", "Alta", "Planificación"),
                            new TaskInfoViewModel("Evaluación inicial de amenazas y vulnerabilidades", "Alta", "Análisis"),

                            // Prioridad Media
                            new TaskInfoViewModel("Plan de comunicación de seguridad", "Media", "Planificación"),
                            new TaskInfoViewModel("Capacitación en seguridad básica", "Media", "Soporte"),
                            new TaskInfoViewModel("Evaluación de proveedores de seguridad", "Media", "Análisis"),
                            new TaskInfoViewModel("Definición de criterios de acceso a la información", "Media", "Análisis"),
                            new TaskInfoViewModel("Creación de políticas de control de acceso", "Media", "Planificación"),
                            new TaskInfoViewModel("Identificación de datos confidenciales", "Media", "Análisis"),
                            new TaskInfoViewModel("Definición de métricas de seguridad", "Media", "Planificación"),
                            new TaskInfoViewModel("Planificación de controles de acceso", "Media", "Planificación"),
                            new TaskInfoViewModel("Establecimiento de control de versiones en seguridad", "Media", "Desarrollo"),
                            new TaskInfoViewModel("Documentación de políticas de seguridad", "Media", "Documentación"),

                            // Prioridad Baja
                            new TaskInfoViewModel("Revisión de políticas de seguridad del cliente", "Baja", "Documentación"),
                            new TaskInfoViewModel("Evaluación de requisitos de auditoría de seguridad", "Baja", "Análisis"),
                            new TaskInfoViewModel("Planificación de auditorías internas", "Baja", "Planificación"),
                            new TaskInfoViewModel("Plan de eliminación de datos", "Baja", "Planificación"),
                            new TaskInfoViewModel("Análisis de impacto de amenazas", "Baja", "Análisis"),
                            new TaskInfoViewModel("Documentación de controles de seguridad iniciales", "Baja", "Documentación"),
                            new TaskInfoViewModel("Análisis de riesgos relacionados con terceros", "Baja", "Análisis"),
                            new TaskInfoViewModel("Establecimiento de un plan de copias de seguridad", "Baja", "Planificación"),
                            new TaskInfoViewModel("Definición de acceso remoto seguro", "Baja", "Planificación"),
                            new TaskInfoViewModel("Identificación de puntos de acceso críticos", "Baja", "Análisis"),
                        }
                    },
                {
                        "elaboracion", new List<TaskInfoViewModel>
                        {
                            // Prioridad Alta
                            new TaskInfoViewModel("Diseño de arquitectura segura", "Alta", "Diseño"),
                            new TaskInfoViewModel("Evaluación de riesgos de seguridad", "Alta", "Análisis"),
                            new TaskInfoViewModel("Definición de controles de acceso", "Alta", "Diseño"),
                            new TaskInfoViewModel("Desarrollo de planes de mitigación de amenazas", "Alta", "Planificación"),
                            new TaskInfoViewModel("Diseño de sistemas de autenticación", "Alta", "Diseño"),
                            new TaskInfoViewModel("Validación de requisitos de seguridad", "Alta", "Pruebas"),
                            new TaskInfoViewModel("Establecimiento de medidas de protección de datos", "Alta", "Diseño"),
                            new TaskInfoViewModel("Gestión de riesgos de vulnerabilidad", "Alta", "Análisis"),
                            new TaskInfoViewModel("Planificación de auditoría de seguridad", "Alta", "Planificación"),
                            new TaskInfoViewModel("Implementación de cifrado de datos", "Alta", "Desarrollo"),

                            // Prioridad Media
                            new TaskInfoViewModel("Simulación de amenazas", "Media", "Pruebas"),
                            new TaskInfoViewModel("Verificación de escalabilidad en seguridad", "Media", "Análisis"),
                            new TaskInfoViewModel("Implementación de controles de auditoría", "Media", "Desarrollo"),
                            new TaskInfoViewModel("Gestión de incidentes de seguridad", "Media", "Soporte"),
                            new TaskInfoViewModel("Validación de acceso seguro", "Media", "Pruebas"),
                            new TaskInfoViewModel("Planificación de pruebas de penetración", "Media", "Planificación"),
                            new TaskInfoViewModel("Definición de métricas de integridad de datos", "Media", "Análisis"),
                            new TaskInfoViewModel("Implementación de controles de rastreo de actividad", "Media", "Desarrollo"),
                            new TaskInfoViewModel("Documentación de arquitectura de seguridad", "Media", "Documentación"),
                            new TaskInfoViewModel("Evaluación de usabilidad en sistemas seguros", "Media", "Análisis"),

                            // Prioridad Baja
                            new TaskInfoViewModel("Simulación de escenarios de desastre", "Baja", "Pruebas"),
                            new TaskInfoViewModel("Validación de registros de auditoría", "Baja", "Pruebas"),
                            new TaskInfoViewModel("Planificación de gestión de parches de seguridad", "Baja", "Planificación"),
                            new TaskInfoViewModel("Revisión de políticas de acceso físico", "Baja", "Análisis"),
                            new TaskInfoViewModel("Desarrollo de informes de seguridad", "Baja", "Documentación"),
                            new TaskInfoViewModel("Gestión de contraseñas seguras", "Baja", "Soporte"),
                            new TaskInfoViewModel("Revisión de acceso de terceros", "Baja", "Análisis"),
                            new TaskInfoViewModel("Pruebas de acceso a datos críticos", "Baja", "Pruebas"),
                            new TaskInfoViewModel("Configuración de autenticación multifactor", "Baja", "Desarrollo"),
                            new TaskInfoViewModel("Evaluación de políticas de recuperación de datos", "Baja", "Análisis"),
                        }
                    },
                    {
                        "construccion", new List<TaskInfoViewModel>
                        {
                            // Prioridad Alta
                            new TaskInfoViewModel("Desarrollo de módulos críticos", "Alta", "Desarrollo"),
                            new TaskInfoViewModel("Controles de seguridad", "Alta", "Desarrollo"),
                            new TaskInfoViewModel("Codificación segura", "Alta", "Desarrollo"),
                            new TaskInfoViewModel("Verificación de privacidad y protección de datos", "Alta", "Pruebas"),
                            new TaskInfoViewModel("Pruebas de seguridad en componentes", "Alta", "Pruebas"),
                            new TaskInfoViewModel("Gestión de accesos", "Alta", "Desarrollo"),
                            new TaskInfoViewModel("Mecanismos de autenticación", "Alta", "Desarrollo"),
                            new TaskInfoViewModel("Interfaces de usuario final", "Alta", "Desarrollo"),
                            new TaskInfoViewModel("Pruebas de integración continua", "Alta", "Pruebas"),
                            new TaskInfoViewModel("Control de versiones", "Alta", "Desarrollo"),

                            // Prioridad Media
                            new TaskInfoViewModel("Seguridad en bases de datos", "Media", "Desarrollo"),
                            new TaskInfoViewModel("Análisis de vulnerabilidades", "Media", "Pruebas"),
                            new TaskInfoViewModel("Funcionalidades de auditoría", "Media", "Desarrollo"),
                            new TaskInfoViewModel("Pruebas funcionales clave", "Media", "Pruebas"),
                            new TaskInfoViewModel("Configuración de gestión de incidentes", "Media", "Soporte"),
                            new TaskInfoViewModel("Documentación técnica", "Media", "Documentación"),
                            new TaskInfoViewModel("Recuperación de fallos", "Media", "Soporte"),
                            new TaskInfoViewModel("Consistencia de datos", "Media", "Pruebas"),
                            new TaskInfoViewModel("Validación de rendimiento", "Media", "Pruebas"),
                            new TaskInfoViewModel("Cifrado de comunicaciones", "Media", "Desarrollo"),

                            // Prioridad Baja
                            new TaskInfoViewModel("Políticas de seguridad en desarrollo", "Baja", "Documentación"),
                            new TaskInfoViewModel("Pruebas de penetración", "Baja", "Pruebas"),
                            new TaskInfoViewModel("Monitoreo de actividades", "Baja", "Implementación"),
                            new TaskInfoViewModel("Verificación de resiliencia", "Baja", "Pruebas"),
                            new TaskInfoViewModel("Capacidades de auditoría", "Baja", "Soporte"),
                            new TaskInfoViewModel("Capacitación en seguridad", "Baja", "Soporte"),
                            new TaskInfoViewModel("Mecanismos de respaldo", "Baja", "Implementación"),
                            new TaskInfoViewModel("Interfaz de usuario segura", "Baja", "Pruebas"),
                            new TaskInfoViewModel("Escalabilidad del sistema", "Baja", "Análisis"),
                            new TaskInfoViewModel("Cumplimiento de normativas", "Baja", "Documentación"),
                        }
                    },
                    {
                        "transicion", new List<TaskInfoViewModel>
                        {
                            // Prioridad Alta
                            new TaskInfoViewModel("Implementación en producción", "Alta", "Implementación"),
                            new TaskInfoViewModel("Verificación de controles de seguridad", "Alta", "Pruebas"),
                            new TaskInfoViewModel("Validación de acceso a datos", "Alta", "Pruebas"),
                            new TaskInfoViewModel("Capacitación del personal", "Alta", "Soporte"),
                            new TaskInfoViewModel("Gestión de cambios", "Alta", "Soporte"),
                            new TaskInfoViewModel("Implementación de monitorización de seguridad", "Alta", "Implementación"),
                            new TaskInfoViewModel("Configuración de alertas de seguridad", "Alta", "Implementación"),
                            new TaskInfoViewModel("Verificación de recuperación ante desastres", "Alta", "Pruebas"),
                            new TaskInfoViewModel("Comunicación de cambios a partes interesadas", "Alta", "Soporte"),
                            new TaskInfoViewModel("Documentación de proceso de transición", "Alta", "Documentación"),

                            // Prioridad Media
                            new TaskInfoViewModel("Revisión de auditorías de seguridad", "Media", "Soporte"),
                            new TaskInfoViewModel("Verificación de conformidad", "Media", "Pruebas"),
                            new TaskInfoViewModel("Implementación de feedback de usuarios", "Media", "Soporte"),
                            new TaskInfoViewModel("Plan de mejora continua", "Media", "Soporte"),
                            new TaskInfoViewModel("Auditoría post-implementación", "Media", "Soporte"),
                            new TaskInfoViewModel("Documentación de lecciones aprendidas", "Media", "Documentación"),
                            new TaskInfoViewModel("Revisión de procesos de seguridad", "Media", "Soporte"),
                            new TaskInfoViewModel("Evaluación de satisfacción del usuario", "Media", "Soporte"),
                            new TaskInfoViewModel("Plan de soporte post-lanzamiento", "Media", "Soporte"),
                            new TaskInfoViewModel("Configuración de soporte técnico", "Media", "Soporte"),

                            // Prioridad Baja
                            new TaskInfoViewModel("Revisión de procesos", "Baja", "Documentación"),
                            new TaskInfoViewModel("Documentación de cambios realizados", "Baja", "Documentación"),
                            new TaskInfoViewModel("Análisis de rendimiento post-implementación", "Baja", "Soporte"),
                            new TaskInfoViewModel("Feedback de stakeholders", "Baja", "Soporte"),
                            new TaskInfoViewModel("Evaluación de necesidades futuras", "Baja", "Análisis"),
                            new TaskInfoViewModel("Plan de gestión de incidentes", "Baja", "Soporte"),
                            new TaskInfoViewModel("Documentación de infraestructura", "Baja", "Documentación"),
                            new TaskInfoViewModel("Auditoría de seguridad final", "Baja", "Pruebas"),
                            new TaskInfoViewModel("Revisión de comunicaciones de seguridad", "Baja", "Documentación"),
                            new TaskInfoViewModel("Cierre de proyecto", "Baja", "Documentación"),
                        }
                    }
                }
            },
            {
                "ISO/IEC 29110", new Dictionary<string, List<TaskInfoViewModel>>
                {
                    {
                        "inicio", new List<TaskInfoViewModel>
                        {
                            // Alta Prioridad
                            new TaskInfoViewModel("Identificación de stakeholders clave", "Alta", "Planificación"),
                            new TaskInfoViewModel("Definición de alcance y objetivos del proyecto", "Alta", "Planificación"),
                            new TaskInfoViewModel("Recopilación de requisitos iniciales", "Alta", "Análisis"),
                            new TaskInfoViewModel("Análisis de riesgos iniciales", "Alta", "Análisis"),
                            new TaskInfoViewModel("Definición del entorno de desarrollo", "Alta", "Desarrollo"),
                            new TaskInfoViewModel("Evaluación de capacidades del equipo", "Alta", "Análisis"),
                            new TaskInfoViewModel("Priorización de requisitos", "Alta", "Análisis"),
                            new TaskInfoViewModel("Planificación de iteraciones", "Alta", "Planificación"),
                            new TaskInfoViewModel("Aprobación del alcance inicial", "Alta", "Planificación"),
                            new TaskInfoViewModel("Evaluación de costos preliminares", "Alta", "Análisis"),

                            // Media Prioridad
                            new TaskInfoViewModel("Establecimiento de criterios de aceptación", "Media", "Análisis"),
                            new TaskInfoViewModel("Definición de roles y responsabilidades del equipo", "Media", "Planificación"),
                            new TaskInfoViewModel("Definición de casos de uso principales", "Media", "Análisis"),
                            new TaskInfoViewModel("Desarrollo de un prototipo inicial", "Media", "Diseño"),
                            new TaskInfoViewModel("Planificación de comunicación con stakeholders", "Media", "Planificación"),
                            new TaskInfoViewModel("Estrategia de pruebas iniciales", "Media", "Pruebas"),
                            new TaskInfoViewModel("Identificación de dependencias", "Media", "Análisis"),
                            new TaskInfoViewModel("Definición de módulos clave", "Media", "Diseño"),
                            new TaskInfoViewModel("Configuración del sistema de control de versiones", "Media", "Desarrollo"),
                            new TaskInfoViewModel("Revisión de normativas aplicables", "Media", "Documentación"),

                            // Baja Prioridad
                            new TaskInfoViewModel("Elaboración del documento de visión", "Baja", "Documentación"),
                            new TaskInfoViewModel("Definición de métricas de éxito del proyecto", "Baja", "Análisis"),
                            new TaskInfoViewModel("Creación de plan de capacitación", "Baja", "Soporte"),
                            new TaskInfoViewModel("Evaluación de herramientas y frameworks", "Baja", "Análisis"),
                            new TaskInfoViewModel("Documentación de requisitos no funcionales", "Baja", "Documentación"),
                            new TaskInfoViewModel("Definición inicial de interfaces de usuario", "Baja", "Diseño"),
                            new TaskInfoViewModel("Planificación de gestión de configuración", "Baja", "Planificación"),
                            new TaskInfoViewModel("Estudio de escalabilidad", "Baja", "Análisis"),
                            new TaskInfoViewModel("Análisis de cumplimiento legal", "Baja", "Análisis"),
                            new TaskInfoViewModel("Definición de plan de gestión del conocimiento", "Baja", "Documentación"),
                        }
                    },
                    {
                        "elaboracion", new List<TaskInfoViewModel>
                        {
                            // Alta Prioridad
                            new TaskInfoViewModel("Refinamiento de requisitos", "Alta", "Análisis"),
                            new TaskInfoViewModel("Validación de casos de uso", "Alta", "Pruebas"),
                            new TaskInfoViewModel("Diseño arquitectónico preliminar", "Alta", "Diseño"),
                            new TaskInfoViewModel("Identificación de atributos de calidad", "Alta", "Análisis"),
                            new TaskInfoViewModel("Diseño de prototipo", "Alta", "Diseño"),
                            new TaskInfoViewModel("Gestión de dependencias críticas", "Alta", "Planificación"),
                            new TaskInfoViewModel("Evaluación de impacto de requisitos", "Alta", "Análisis"),
                            new TaskInfoViewModel("Planificación de pruebas de integración", "Alta", "Pruebas"),
                            new TaskInfoViewModel("Definición de módulos clave", "Alta", "Diseño"),
                            new TaskInfoViewModel("Definición de interfaces detalladas", "Alta", "Diseño"),

                            // Media Prioridad
                            new TaskInfoViewModel("Pruebas de rendimiento preliminares", "Media", "Pruebas"),
                            new TaskInfoViewModel("Optimización para escalabilidad", "Media", "Diseño"),
                            new TaskInfoViewModel("Evaluación de la interoperabilidad", "Media", "Análisis"),
                            new TaskInfoViewModel("Revisión de casos de uso complejos", "Media", "Análisis"),
                            new TaskInfoViewModel("Gestión de errores y excepciones", "Media", "Análisis"),
                            new TaskInfoViewModel("Revisión de arquitectura final", "Media", "Planificación"),
                            new TaskInfoViewModel("Evaluación de la mantenibilidad", "Media", "Análisis"),
                            new TaskInfoViewModel("Desarrollo del modelo lógico de datos", "Media", "Diseño"),
                            new TaskInfoViewModel("Evaluación de portabilidad", "Media", "Análisis"),
                            new TaskInfoViewModel("Definición de plan de recuperación", "Media", "Planificación"),

                            // Baja Prioridad
                            new TaskInfoViewModel("Pruebas iniciales de seguridad", "Baja", "Pruebas"),
                            new TaskInfoViewModel("Validación de la usabilidad", "Baja", "Pruebas"),
                            new TaskInfoViewModel("Implementación de integración continua", "Baja", "Desarrollo"),
                            new TaskInfoViewModel("Evaluación de la resiliencia ante fallos", "Baja", "Pruebas"),
                            new TaskInfoViewModel("Desarrollo de herramientas de monitoreo", "Baja", "Implementación"),
                            new TaskInfoViewModel("Refinamiento del modelo de datos físico", "Baja", "Diseño"),
                            new TaskInfoViewModel("Gestión de versiones", "Baja", "Desarrollo"),
                            new TaskInfoViewModel("Revisión de accesibilidad", "Baja", "Pruebas"),
                            new TaskInfoViewModel("Validación del diseño de interfaces", "Baja", "Pruebas"),
                            new TaskInfoViewModel("Evaluación de la modularidad", "Baja", "Análisis"),
                        }
                    },
                    {
                        "construccion", new List<TaskInfoViewModel>
                        {
                            // Alta Prioridad
                            new TaskInfoViewModel("Desarrollo de módulos clave", "Alta", "Desarrollo"),
                            new TaskInfoViewModel("Implementación de la base de datos", "Alta", "Desarrollo"),
                            new TaskInfoViewModel("Desarrollo de la interfaz de usuario", "Alta", "Desarrollo"),
                            new TaskInfoViewModel("Pruebas unitarias", "Alta", "Pruebas"),
                            new TaskInfoViewModel("Integración de componentes", "Alta", "Desarrollo"),
                            new TaskInfoViewModel("Optimización de rendimiento", "Alta", "Desarrollo"),
                            new TaskInfoViewModel("Implementación de la lógica de negocio", "Alta", "Desarrollo"),
                            new TaskInfoViewModel("Configuración de entornos de prueba", "Alta", "Pruebas"),
                            new TaskInfoViewModel("Integración de la base de datos", "Alta", "Desarrollo"),
                            new TaskInfoViewModel("Automatización de procesos", "Alta", "Desarrollo"),

                            // Media Prioridad
                            new TaskInfoViewModel("Ajustes de interfaz basados en feedback", "Media", "Desarrollo"),
                            new TaskInfoViewModel("Validaciones de seguridad de datos", "Media", "Desarrollo"),
                            new TaskInfoViewModel("Generación de informes y reportes", "Media", "Desarrollo"),
                            new TaskInfoViewModel("Documentación técnica del código", "Media", "Documentación"),
                            new TaskInfoViewModel("Automatización de pruebas unitarias", "Media", "Pruebas"),
                            new TaskInfoViewModel("Revisión de seguridad del sistema", "Media", "Pruebas"),
                            new TaskInfoViewModel("Validación de integración con sistemas externos", "Media", "Desarrollo"),
                            new TaskInfoViewModel("Desarrollo de herramientas de auditoría", "Media", "Desarrollo"),
                            new TaskInfoViewModel("Optimización de almacenamiento de datos", "Media", "Desarrollo"),
                            new TaskInfoViewModel("Implementación de gestión de fallos", "Media", "Desarrollo"),

                            // Baja Prioridad
                            new TaskInfoViewModel("Implementación de políticas de seguridad", "Baja", "Documentación"),
                            new TaskInfoViewModel("Pruebas de seguridad avanzadas", "Baja", "Pruebas"),
                            new TaskInfoViewModel("Monitoreo de actividad del sistema", "Baja", "Implementación"),
                            new TaskInfoViewModel("Verificación de resiliencia", "Baja", "Pruebas"),
                            new TaskInfoViewModel("Capacitación en prácticas de seguridad", "Baja", "Soporte"),
                            new TaskInfoViewModel("Configuración de backups automáticos", "Baja", "Implementación"),
                            new TaskInfoViewModel("Cumplimiento de normativas de seguridad", "Baja", "Documentación"),
                            new TaskInfoViewModel("Revisión técnica de la documentación", "Baja", "Documentación"),
                            new TaskInfoViewModel("Optimización de acceso a datos", "Baja", "Desarrollo"),
                            new TaskInfoViewModel("Revisión de cumplimiento normativo", "Baja", "Análisis"),
                        }
                    },
                    {
                        "transicion", new List<TaskInfoViewModel>
                        { 
                            // Alta Prioridad
                            new TaskInfoViewModel("Preparación para el despliegue en producción", "Alta", "Implementación"),
                            new TaskInfoViewModel("Pruebas de aceptación finales", "Alta", "Pruebas"),
                            new TaskInfoViewModel("Capacitación a usuarios finales", "Alta", "Soporte"),
                            new TaskInfoViewModel("Entrenamiento del equipo de soporte", "Alta", "Soporte"),
                            new TaskInfoViewModel("Documentación de usuario final", "Alta", "Documentación"),
                            new TaskInfoViewModel("Planificación del lanzamiento", "Alta", "Planificación"),
                            new TaskInfoViewModel("Verificación de cumplimiento normativo", "Alta", "Análisis"),
                            new TaskInfoViewModel("Despliegue en el entorno de producción", "Alta", "Implementación"),
                            new TaskInfoViewModel("Configuración del entorno de producción", "Alta", "Implementación"),
                            new TaskInfoViewModel("Evaluación de la satisfacción del cliente", "Alta", "Soporte"),

                            // Media Prioridad
                            new TaskInfoViewModel("Monitoreo post-despliegue", "Media", "Implementación"),
                            new TaskInfoViewModel("Análisis de feedback de usuarios", "Media", "Soporte"),
                            new TaskInfoViewModel("Implementación de mejoras sugeridas", "Media", "Desarrollo"),
                            new TaskInfoViewModel("Documentación de lecciones aprendidas", "Media", "Documentación"),
                            new TaskInfoViewModel("Revisión de la efectividad del soporte", "Media", "Soporte"),
                            new TaskInfoViewModel("Ajustes en la documentación técnica", "Media", "Documentación"),
                            new TaskInfoViewModel("Planificación de soporte a largo plazo", "Media", "Soporte"),
                            new TaskInfoViewModel("Evaluación de requisitos de mantenimiento", "Media", "Análisis"),
                            new TaskInfoViewModel("Revisión de cumplimiento de objetivos del proyecto", "Media", "Análisis"),
                            new TaskInfoViewModel("Optimización de procesos de entrega", "Media", "Implementación"),

                            // Baja Prioridad
                            new TaskInfoViewModel("Análisis de la experiencia del usuario", "Baja", "Soporte"),
                            new TaskInfoViewModel("Actualización de la formación del equipo", "Baja", "Soporte"),
                            new TaskInfoViewModel("Revisión de la documentación de soporte", "Baja", "Documentación"),
                            new TaskInfoViewModel("Implementación de mejoras en la capacitación", "Baja", "Soporte"),
                            new TaskInfoViewModel("Planificación de actualizaciones futuras", "Baja", "Planificación"),
                            new TaskInfoViewModel("Evaluación de la infraestructura de TI", "Baja", "Análisis"),
                            new TaskInfoViewModel("Creación de un plan de continuidad del negocio", "Baja", "Planificación"),
                            new TaskInfoViewModel("Revisión de estrategias de recuperación ante desastres", "Baja", "Planificación"),
                            new TaskInfoViewModel("Auditoría de cumplimiento post-despliegue", "Baja", "Análisis"),
                            new TaskInfoViewModel("Documentación de procesos de mantenimiento", "Baja", "Documentación"),
                        }
                    },
                }
            }
        };
    }
}
