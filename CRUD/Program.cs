using CRUD.Entities;
using CRUD.Services;

BaseCrudService<Person> baseCrud = new BaseCrudService<Person>();
bool salir = false;

Console.WriteLine("Hola, World!");

while (!salir)
{

    Console.WriteLine("1. Crear");
    Console.WriteLine("2. Ver");
    Console.WriteLine("3. Editar");
    Console.WriteLine("4 Eliminar");
    Console.WriteLine("5. Salir");
    Console.WriteLine("Elige una de las opciones");
    int opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.Clear();
            Creacion();
            break;
        case 2:
            Console.Clear();
            Console.WriteLine("Lista: ");
            Mostrar();
            break;

        case 3:
            Console.Clear();
            Console.WriteLine("Actualizar ");
            Actualizar();
            break;
        case 4:
            Console.Clear();
            Console.WriteLine("Eliminar");
            Delete();
            Mostrar();
            break;
        case 5:
            Console.WriteLine("Has elegido salir de la aplicación");
            salir = true;
            break;
        default:
            Console.WriteLine("Elige una opcion entre 1 y 5");
            break;
    }
}

void Creacion()
{
    Person NewPerson = new Person();
    Console.WriteLine("Creacion...");
    Console.WriteLine("Por favor inserte la informacion");
    var FirstName1 = Console.ReadLine();
    var LastName1 = Console.ReadLine();
    Console.WriteLine("Ingrese 1 para Masculino y 2 para femenino");
    var Sex1 = Console.ReadLine();
    if (Sex1 == "1")
    {
        NewPerson.Sex = Sex.Male;
    }
    else
    {
        NewPerson.Sex = Sex.Female;
    }

    var birth = DateTime.Now;

    NewPerson.FirstName = FirstName1;
    NewPerson.LastName = LastName1;
    NewPerson.BirthDate = birth;

    baseCrud.Create(NewPerson);

    Console.WriteLine("Persona agregada correctamente");

}

void Mostrar()
{
    foreach (var item in baseCrud.Get())
    {
        Console.WriteLine("///////////");
        Console.WriteLine("PERSONA " + item.Id);
        Console.WriteLine("ID:" + item.Id);
        Console.WriteLine("Nombre:" + item.FirstName);
        Console.WriteLine("Apellido " + item.LastName);
        Console.WriteLine("Sexo: " + item.Sex);
        Console.WriteLine("Birthday: " + item.BirthDate);
        Console.WriteLine("///////////");
    }
}

void Actualizar()
{
    Person NewPerson = new Person();
    Console.WriteLine("Ingrese el id para poder editar");
    var input = Console.ReadLine();
    var id = int.Parse(input);
    
    var name = Console.ReadLine();
    var lastname = Console.ReadLine();

     Console.WriteLine("Ingrese 1 para Masculino y 2 para femenino");
    var Sex2 = Console.ReadLine();
    if (Sex2 == "1")
    {
        NewPerson.Sex = Sex.Male;
    }
    else
    {
        NewPerson.Sex = Sex.Female;
    }
    NewPerson.Id = id;
    NewPerson.FirstName = name;
    NewPerson.LastName = lastname;
    NewPerson.BirthDate = DateTime.Now;

    var person = baseCrud.Update(NewPerson);
    Console.WriteLine($"{person.Id} |{person.FirstName} | {person.LastName} | {person.Sex}");
}

void Delete()
{
    Console.WriteLine("Ingrese el id para poder eliminar");
    var input = Console.ReadLine();
    var id = int.Parse(input);
    baseCrud.Delete(id);
}



