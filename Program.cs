
using System.Collections;

internal class NewBaseType{
    private static void Main(string[] args)
    {
        int ? idx;
        string ? palabra;
        ArrayList Materias = new ArrayList();
        ArrayList Cursos = new ArrayList();
        
        Materias.Add("Calculo");
        Materias.Add("Español");
        Materias.Add("Dibujo tecnico");
        Materias.Add("Ingles");

        Console.WriteLine("Ingrese la materia a ser buscada: ");
        palabra = Console.ReadLine();

        idx = Materias.LastIndexOf(palabra);

        Console.WriteLine("La asignatira {0} se ebcontro en la ultima pos de id {1} ",palabra,idx);

    
        
        // do{
            
        //     idx = Convert.ToInt32(Console.ReadLine());
        // }while(idx > Materias.Count);

        // Materias.Insert(idx,palabra);

        // foreach(object materia in Materias){
        //     Console.WriteLine(materia.ToString());
        // }
    }
 
}