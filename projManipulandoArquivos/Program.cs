using projManipulandoArquivos;

string file;


Person person1 = CreatePerson();
Person person2 = CreatePerson();


Person CreatePerson()
{
    Console.WriteLine("Informe o nome da pessoa: ");
    var name = Console.ReadLine();
    Console.WriteLine("Informe o genero da pessoa: ");
    var gender = char.Parse(Console.ReadLine());

    return new Person(name, gender);
}

WriteFile(person1);
WriteFile(person2);
Console.Clear();

Console.WriteLine("Informe o nome do arquivo a ser aberto: ");
file = Console.ReadLine();
Console.WriteLine(ReadFile(file));

string ReadFile(string file)
{
    StreamReader sr = new StreamReader(file);
    string text = "";

    try
    {
        text = sr.ReadToEnd();
    }
    catch (Exception)
    {
        throw;
    }
    finally
    {
        sr.Close();
    }
    return text;
}

void WriteFile(Person person)
{
    try
    {
        if (File.Exists("backup.txt"))
        {
            var temp = ReadFile("backup.txt");
            StreamWriter sw = new("backup.txt");
            sw.WriteLine(temp + person.ToString());
            sw.Close();
        }
        else
        {
            StreamWriter sw = new StreamWriter("backup.txt");
            sw.WriteLine(person.ToString());
            sw.Close ();
        }

    }
    catch (Exception e)
    {
        throw;
    }
    finally
    {
        Console.WriteLine("Registro gravado com sucesso");
        Thread.Sleep(1000);
    }
}

