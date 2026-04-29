using System; 

abstract class Escritor
{
    public abstract void Planear();
    public abstract void Escribir();
    public void Editar()
    {
        Console.WriteLine ("------Editar------");
        Console.WriteLine("Lee el borrador");
        Console.WriteLine("Hace anotaciones y correcciones");
        Console.WriteLine("Hace segundo borrador a base de las anotaciones");
        Console.WriteLine("Termina el libro");
    }
}

class Escritor_Fantasia
{
    public override void Planear()
    {
        Console.WriteLine ("------Planear------");
        Console.WriteLine("Escritor hace diseño de mundo");
        Console.WriteLine("Escritor inventa poderes y personajes");
    }

    public override void Escribir() 
    {
        Console.WriteLine ("------Escribir------");
        Console.WriteLine("Escribe por capítulos");
        Console.WriteLine("Describe el mundo de fantasía");
        Console.WriteLine("Termina el primer borrador");
    }
}

class Escritor_Ficcion_Historica
{
    public override void Planear()
    {
        Console.WriteLine ("------Planear------");
        Console.WriteLine("Escritor hace investigación de la época");
        Console.WriteLine("Escritor relaciona los eventos con puntos de su historia");
    }

    public override void Escribir() 
    {
        Console.WriteLine ("------Escribir------");
        Console.WriteLine("Escribe por capítulos");
        Console.WriteLine("Relaciona la ficción con la realidad");
        Console.WriteLine("Termina el primer borrador");
    }
}

class Escritor_Biografia 
{
    public override void Planear()
    {
        Console.WriteLine ("------Planear------");
        Console.WriteLine("Escritor hace investigación sobre una persona");
        Console.WriteLine("Escritor asegura que todos sus datos sean correctos");
    }

    public override void Escribir() 
    {
        Console.WriteLine ("------Escribir------");
        Console.WriteLine("Escribe por capítulos");
        Console.WriteLine("Describe el mundo de fantasía");
        Console.WriteLine("Termina el primer borrador");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("------Escritor de Fantasía------");
        Escritor.Fantasia = new Escritor_Fantasia();
        Escritor.Planear();
        Escritor.Escribir();
        Escritor.Editar();

        Console.WriteLine("------Escritor de Ficción Histórica------");
        Escritor.Ficcion_Historica = new Escritor_Ficcion_Historica();
        Escritor.Planear();
        Escritor.Escribir();
        Escritor.Editar();

        Console.WriteLine("------Escritor de Biografias------");
        Escritor.Biografia = new Escritor_Biografia();
        Escritor.Planear();
        Escritor.Escribir();
        Escritor.Editar();
    }
}
