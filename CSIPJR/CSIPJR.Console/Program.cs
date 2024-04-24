using CSIPJR.Domain;
using CSIPJR.Domain.Class;
using System.Globalization;


// En la pantalla de profesores
IExportData<Profesor> exportData = new ExportData<Profesor>();

InstructorSearch instructorSearch = new InstructorSearch();

var datos = instructorSearch.SearchByArea("Matematica");

exportData.ExportTo(CSIPJR.Domain.Enums.ExportType.Csv,datos);


// En la pantalla de estudiantes
IExportData<Estudiante> exportEstudiante = new ExportData<Estudiante>();

StudentSearch studentSearch = new StudentSearch();

var datosEstudiantes = studentSearch.SearchByCourse("SQL");

exportEstudiante.ExportTo(CSIPJR.Domain.Enums.ExportType.Pdf, datosEstudiantes);

Persona estudiante = new Estudiante();

Persona profesor = new Profesor();