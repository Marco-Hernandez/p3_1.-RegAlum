using System;
using System.Collections;

namespace RegAlum
{
	

	class Persona
	{  Hashtable tabla=new Hashtable();
		
	   
		public string nombre;
		public string codigo;
			
		public void AgregarAlum()
		{  
			
			Console.WriteLine("Nombre: ");
			nombre=Console.ReadLine();
			Console.WriteLine("Codigo: ");
			codigo=Console.ReadLine();
			tabla.Add(codigo,nombre);
		}
		
		public void EliminarAlum()
		{
				Console.WriteLine("Ingrese el codigo a eliminar");
				string CodElim=Console.ReadLine();
				if(tabla.Contains(CodElim))
				{   
				    Console.WriteLine("\nCodigo y Nombre que ingreso");
					Console.WriteLine("Codigo: "+CodElim);
					Console.WriteLine("Nombre: "+tabla[CodElim].ToString());
					Console.WriteLine("Seguro de eliminar registro de alumno s/n?");
					char answ2=char.Parse(Console.ReadLine());
					if(answ2=='s')
					{
						tabla.Remove(CodElim);
				   		Console.WriteLine("\n Los datos han sido eliminados");
					}
					else
						Console.WriteLine("\n Se arrepintio de eliminar los datos y salio");	
				}
				  Console.WriteLine("\n NO existe el codigo ingresado");
		}
		
		public void MostrarAlum()
		{	
			
			Console.WriteLine("\n A continuacion se muestra la tabla");
			Console.WriteLine( "\tCodigo \t Nombre " );
    	    foreach ( DictionaryEntry de in tabla )
            Console.WriteLine( "\t{0}:\t{1}", de.Key, de.Value );
    	    
		}
			
			
		public static void Main(string[] args)
		{ 	 Persona p=new Persona();
			
			int opcion;
			do{
			 
			 Console.WriteLine(".-1 Agregar alumno\n" +
				              ".-2 Eliminar alumno\n" +
				              ".-3 Ver alumnos\n" +
				              ".-4 Salir");
			Console.WriteLine("\nEliga la operacion a realizar:");
			
			opcion= int.Parse(Console.ReadLine());
			Console.Clear();
			switch(opcion){
					case 1:{ 
						p.AgregarAlum();
					    Console.ReadKey(true);
					    Console.Clear();
						break;
						}
					case 2:{
						p.EliminarAlum();
					    Console.ReadKey(true);
					    Console.Clear();
					    break;
			            }
				    case 3:{ 
					   
					   p.MostrarAlum();
					   Console.ReadKey(true);
					   Console.Clear();
					  
					    break;
				        }
				    case 4:{
					Console.WriteLine("Esta saliendo del programa!");
					break;
				}
					
			}
			
		  }while(opcion!=4);
		}
	} 

}