using Practica;

Console.WriteLine("Hello, World!");
Console.WriteLine("SUBCONSULTAS LINQ");
SubConsultas();

static void SubConsultas()
{
    int Tiempo = 18000;
    List<Curso> cursos = new List<Curso>()
{
    new Curso
    {
        Id = "CW - PROGRAMACION WEB",
        Titulo = "PROGRAMACION WEB BASICO",
        Descripcion = "CURSO BASICO DE PROGRAMACION WEB",
        Duracion = 20800,
        Nivel = 1,
    },

     new Curso
    {
        Id = "C# - PROGRAMACION C#",
        Titulo = "PROGRAMACION BASICA EN C#",
        Descripcion = "CURSO BASICO DE PROGRAMACION BASICA EN C#",
        Duracion = 18000,
        Nivel = 1,
    },

      new Curso
    {
        Id = "C2 - PROGRAMACION WEB NIVEL INTERMEDIO",
        Titulo = "PROGRAMACION WEB INTEREDIO",
        Descripcion = "CURSO INTERMEDIO DE PROGRAMACION WEB",
        Duracion = 18500,
        Nivel = 3,
    },
        new Curso
    {
        Id = "C#2 - PROGRAMACION C# NIVEL INTERMEDIO",
        Titulo = "PROGRAMACION C# INTEREDIO",
        Descripcion = "CURSO INTERMEDIO DE PROGRAMACION C#",
        Duracion = 18600,
        Nivel = 1,
    },
        new Curso
    {
        Id = "C# - PROGRAMACION AVANZADO C#",
        Titulo = "PROGRAMACION AVANZADO EN C#",
        Descripcion = "CURSO BASICO DE PROGRAMACION AVANZADO EN C#",
        Duracion = 1800,
        Nivel = 1,
    },
};

    //FILTRAR CURSOS
    var CursoFiltrado = cursos.Where(c => c.Duracion <= Tiempo && c.Titulo.Contains("C#"))
        .OrderBy(c => c.Nivel)
        .Select(c => new
        {
            titulo = c.Titulo,
            nivel = c.Nivel,
            duracion = c.Duracion
        });

    CursoFiltrado.ToList()
        .ForEach(c => Console.WriteLine("Titutlo {0}\n Nivel {1}\n Duracion {2}\n",
         c.titulo, c.nivel, c.duracion));

    //FILTRAR CURSO POR MAS CORTO

    var CursoCorto = cursos.OrderBy(c => c.Duracion).FirstOrDefault();

    Console.WriteLine("El curso mas corto es {0} tiene una duracion de {1} ms",
        CursoCorto.Titulo, CursoCorto.Duracion);

    //FILTRAR GRUPOS POR NIVELES
    var CursosGrupoNivel = cursos.Where(c => c.Id.Contains("C"))
        .Select(c => new
        {
            c.Id,
            c.Titulo,
            grupoNivel = c.Nivel
        }).GroupBy(c => c.grupoNivel);

    Console.Read();
}
