using System;
using System.Collections.Generic;

using System.Text;
using System.Threading;


namespace pipeServer_NoFrills
{
    class Program
    {
        
        
        
        static void Main(string[] args)
        {
           //Server ServTest = new Server();
           //Thread T = new Thread(ServTest.Serveradd);
           //T.Name = @"ServTest.Serveradd";
           //T.Start();

           
            
            //Console.WriteLine("mammama");
            Split_PipeServer pipeServer = 
                new Split_PipeServer();


            //start the pipe server if it's not already running
            if (!pipeServer.Running)
            {
                pipeServer.PipeName = "\\\\.\\pipe\\myNamedPipe";
                pipeServer.Start();
                pipeServer.SendMessage("this.tbSend.Text");

            }

            else
            {
                pipeServer.SendMessage("this.tbSend.Text");
            }






            Console.ReadLine();
        }


       
        
            
        


    
    }


}
