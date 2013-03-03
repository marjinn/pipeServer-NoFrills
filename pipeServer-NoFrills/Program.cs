using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace pipeServer_NoFrills
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            Server ServTest = new Server();
           Thread T = new Thread(ServTest.Serveradd);
           T.Name = @"ServTest.Serveradd";
           T.Start();

           Console.WriteLine("mammama");
            
            Console.ReadLine();
        }


       
        
            
        


    
    }


}
