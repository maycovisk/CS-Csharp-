class Aula1
{

   static void Main()
   {
      string[] names = { "Maycon", "Clark"};

      //Console.WriteLine(names[0]);
      //Console.WriteLine(names[1]);

      //for(int i = 0; i < 2; i++){
      for(int i = 0; i < names.Length; i++){
         Console.WriteLine(names[i]);
      }

      foreach(string name in names){    //PARA CADA STRING NAME EM NAMES O LUPE SERA EXECUTADO
         Console.WriteLine(name);
      }
   }
}