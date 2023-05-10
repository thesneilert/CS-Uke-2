namespace Ukesoppgave_Uke_2;

public class Student                                                                                                    
{                                                                                                                       
    public string Name { get; set; }                                                                                    
    public string Age { get; set; }                                                                                        
    public string Course { get; set; }                                                                                  
                                                                                                                        
    public Student(string name, string age, string course)                                                                 
    {                                                                                                                   
        Name = name;                                                                                                    
        Age = age;                                                                                                      
        Course = course;                                                                                                
    }                                                                                                                   
}                                                                                                                       
