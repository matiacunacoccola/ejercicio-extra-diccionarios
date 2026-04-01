// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        Curso curso = new Curso();
        int opcion;

        do
        {
            opcion=pedirInt("Ingrese una opcion: \n 1- Agregar una entrevista \n 2- Eliminar una entrevista \n 3- Modificar fecha y duración de una entrevista \n 4- Comparar fechas de dos entrevistas \n 5- Mover entrevista en el calendario \n 6- Mostrar la próxima entrevista \n 7- Listar todas las entrevistas \n 8- Salir ");
           
            
           
           
          "0- Salir");

           

            switch (opcion)
            {
                case 1:
                   

                case 2:
                    
                case 3:
                    
                case 4:
                   
                    break;

                case 5:
                  
                    break;
            }

        } while (opcion != 0);
    }
    static int pedirInt(string x)
    {
      int y;
      Console.WriteLine(x);
      y= int.Parse(Console.ReadLine());
      return y;

    }
     static int pedirInt(string x)
    {
      string y;
      Console.WriteLine(x);
      y= Console.ReadLine();
      return y;

    }
}