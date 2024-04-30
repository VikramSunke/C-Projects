
using System.Collections.Generic;
    namespace GenericsDemo
{
    public class StudentModal<T, U>
    { 
    
            public T Id { get; set; }
            public U Name { get; set; }
            public T Age { get; set; }
        
    }
}
