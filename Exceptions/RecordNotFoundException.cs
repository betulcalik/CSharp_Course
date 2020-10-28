using System;

namespace _15_Exceptions
{
    public class RecordNotFoundException : Exception
    {
        public RecordNotFoundException(string message) : base(message){
            
        } 
    }
}