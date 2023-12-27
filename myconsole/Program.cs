using System;


class Program
{
    static void Main()
    {  
        
        // DataTypes dataTypes = new DataTypes();
        // dataTypes.PrintDataTypes();
        // Color myColor = Color.Green;        
        // Console.WriteLine($"The selected color is: {myColor}");
        // variables are:
        //  const string name = "chaithanya";
        // Console.WriteLine(name);
        // int myNum = 15;
        // Console.WriteLine(myNum);
        // int minutesPerHour = 60;//identifier
        // int m = 60;
        // Console.WriteLine(m);
        // Console.WriteLine(minutesPerHour);
        //OperatorsExample.myOperatorsExamples();
       // ConditionalStatementsExample.MyConditionalStatementsExamples(); 
        // int Team = 3;
        // SwitchExample.IPL(Team);
      //  Arrays.Arrayss(); 

        // BankAccount account = new BankAccount();
        // account.Deposit(100);
        // decimal balance = account.GetBalance();
        // Console.WriteLine($"Current Balance: {balance}rupees");

        // Football footballGame = new Football();      
        // footballGame.Play(); 
        // Basketball basketballGame = new Basketball();
        // basketballGame.Play();
        
        // Animal myAnimal = new Animal();  
        // Animal myPig = new Pig();  
        // Animal myDog = new Dog();      
        // myAnimal.animalSound();
        // myPig.animalSound();
        // myDog.animalSound();    
           
        // Rohit rohitSharma = new Rohit();       
        // rohitSharma.player();       
        // rohitSharma.play();         
        // rohitSharma.powerplay();
        // rohitSharma.deathovers();

        
        // ArrayListExample arrayListExample = new ArrayListExample();

        
        // arrayListExample.AddElement("Apple");
        // arrayListExample.AddElement("Banana");
        // arrayListExample.AddElement("Cherry");

        
        // Console.WriteLine("print list;");
        // arrayListExample.DisplayList();

        
        // arrayListExample.InsertElement(1, "Orange");
        // Console.WriteLine("List after inserting 'Orange' at index 1:");
        // arrayListExample.DisplayList();

        
        // arrayListExample.RemoveElement("Banana");
        // Console.WriteLine("List after removing 'Banana':");
        // arrayListExample.DisplayList();

       
        // arrayListExample.RemoveElementAt(2);
        // Console.WriteLine("List after removing element at index 2:");
        // arrayListExample.DisplayList();

        
        // Console.WriteLine("Does 'Cherry' exist in the list? " + arrayListExample.ContainsElement("Cherry"));

        
        // Console.WriteLine("Index of 'Apple': " + arrayListExample.IndexOfElement("Apple"));

        
        // arrayListExample.ClearList();
        // Console.WriteLine("List after clearing:");
        // arrayListExample.DisplayList();


        
        // HashtableExample hashtableExample = new HashtableExample();

       
        // hashtableExample.AddKeyValuePair("Age", 21);
        // hashtableExample.AddKeyValuePair("name","chaithanya");
        // hashtableExample.AddKeyValuePair("City", "bangalore");

        
        // Console.WriteLine("Initial Hashtable:");
        // hashtableExample.DisplayHashtable();

   
        // Console.WriteLine("\nUpdating value for the key 'Age':");
        // hashtableExample.UpdateValueForKey("Age", 22);
        // hashtableExample.DisplayHashtable();

     
        // Console.WriteLine("\nDoes the key 'Gender' exist? " + hashtableExample.DoesKeyExist("Gender"));

        
        // Console.WriteLine("\nRemoving the key-value pair for the key 'City':");
        // hashtableExample.RemoveKeyValuePair("City");
        // hashtableExample.DisplayHashtable();

        
        // Console.WriteLine("\nClearing the Hashtable:");
        // hashtableExample.ClearHashtable();
        // hashtableExample.DisplayHashtable();


   
    
        // StackExample stackExample = new StackExample();

        // stackExample.PushElement("Apple");
        // stackExample.PushElement("Banana");
        // stackExample.PushElement("Cherry");

        // Console.WriteLine("Initial Stack:");
        // stackExample.DisplayStack();

        // Console.WriteLine("\nPopping an element from the stack:");
        // string poppedElement = stackExample.PopElement();
        // Console.WriteLine($"Popped element: {poppedElement}");
        // stackExample.DisplayStack();

        // Console.WriteLine("\nPeeking at the top element without removing it:");
        // string topElement = stackExample.PeekAtTopElement();
        // Console.WriteLine($"Top element: {topElement}");
        // stackExample.DisplayStack();

        // Console.WriteLine("\nDoes the stack contain 'Banana'? " + stackExample.ContainsElement("Banana"));

        // Console.WriteLine("\nClearing the stack:");
        // stackExample.ClearStack();
        // stackExample.DisplayStack();



        // QueueExample queueExample = new QueueExample();

        // queueExample.EnqueueElement("Apple");
        // queueExample.EnqueueElement("Banana");
        // queueExample.EnqueueElement("Cherry");

        // Console.WriteLine("Initial Queue:");
        // queueExample.DisplayQueue();

        
        // string dequeuedElement = queueExample.DequeueElement();
        // Console.WriteLine($"Dequeued element: {dequeuedElement}");

        
        // string peekedElement = queueExample.PeekAtFrontElement();
        // Console.WriteLine($"Peeked element: {peekedElement}");

       
        // Console.WriteLine("Queue elements after dequeue and peek:");
        // queueExample.DisplayQueue();

       
        // Console.WriteLine("\nDoes the queue contain 'Banana'? " + queueExample.ContainsElement("Banana"));

       
        // Console.WriteLine("\nClearing the queue:");
        // queueExample.ClearQueue();
        // queueExample.DisplayQueue();

        // string filePath = "example.txt";
        // FileStreamExample.WriteAndReadFile(filePath);

        // string readMessage = MemoryExample.WriteAndReadMemory();

        // Console.WriteLine($"Data read from memory: {readMessage}");


        // string filePath = "c:/Users/vadde.c.sai/OneDrive - InTimeTec Visionsoft Pvt. Ltd.,/Desktop/helloworld.txt";
        // BufNWExample.ReadFileWithBufferedStream(filePath);


        // string textFilePath = "text.txt";
        // StreamRW.ReadWriteWithStreamReaderWriter(textFilePath);

        // string binaryFilePath = "binaryfile.dat";
        // BinaryStream.ReadWriteWithBinaryReaderWriter(binaryFilePath);


        //fileops
        // string filePath = "example.txt";
        // string[] fileContent = { "Hello,Chaithanya" };       
        // FileOps.WriteTextFile(filePath, fileContent);
        // FileOps.ReadTextFile(filePath);
        // FileOps.CheckFileExistence(filePath);

        // string newFilePath = "newfile.txt";

        
        // FileOps.CreateFile(newFilePath);
        // FileOps.DeleteFile(newFilePath);
        // string sourceFilePath = "oldfile.txt";
        // string destinationFilePath = "newfile.txt";

        // FileOps.MoveFile(sourceFilePath, destinationFilePath);

        // serialize
    // {
       
    //     Person person = new Person
    //     {
    //         Name = "chaithanya",
    //         Age = 21
    //     };

       
    //     Serialization.SerializePerson(person, "person.xml");
    //     Console.WriteLine("Serialization completed.");

       
    //     Person deserializedPerson = Serialization.DeserializePerson("person.xml");

        
    //     Console.WriteLine("Deserialized Person:");
    //     Console.WriteLine($"Name: {deserializedPerson.Name}");
    //     Console.WriteLine($"Age: {deserializedPerson.Age}");

        //exceptions
        // int[] arr = { 1, 2, 3, 4, 5 };
 
        
        // for (int i = 0; i < arr.Length; i++) {
        //     Console.WriteLine(arr[i]);
        // }
 
       
        // Console.WriteLine(arr[7]);


        // int[] arr = { 1, 2, 3, 4, 5 };       
        // for (int i = 0; i < arr.Length; i++) {
        //     Console.WriteLine(arr[i]);
        // }
        // try {         
        //     Console.WriteLine(arr[7]);
          
        // }
        // catch (IndexOutOfRangeException e) {
        //     Console.WriteLine("An Exception has occurred : {0}", e.Message);
        // }

        //multitrycatch
        // int[] arr = {19, 0, 75, 52}; 
        // try {          
        //     for (int i = 0; i < arr.Length; i++) {
        //         Console.WriteLine(arr[i] / arr[i + 1]);
        //     }
        // }        
        // catch (IndexOutOfRangeException e) {
 
        //     Console.WriteLine("An Exception has occurred : {0}", e.Message);
        // }     
        // catch (DivideByZeroException e) {
 
        //     Console.WriteLine("An Exception has occurred : {0}", e.Message);
        // }      
        // catch (ArgumentOutOfRangeException e) {
 
        //     Console.WriteLine("An Exception has occurred : {0}", e.Message);
        // }       
        // finally {
        //     for (int i = 0; i < arr.Length; i++) {
        //         Console.Write(" {0}", arr[i]);
        //     }
        // }
        //  try
        // {
            
        //     Throw.CheckEligibilityToVote(16);

           
        //     Console.WriteLine("Person is eligible to vote.");
        // }
        // catch (Exception ex)
        // {
            
        //     Console.WriteLine($"Error: {ex.Message}");
        // }



        // Console.ReadLine();

        // Deserialization Example
        // Person deserializedPerson = Deserialization.DeserializePerson();

       
        // Console.WriteLine("Deserialized Person:");
        // Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}");



 



      
    

        


        
    }
    }

    
    
// public class person
// {
//     public string FirstName { get; set; }
//     public string LastName { get; set; }
//     public int Age { get; set; }
    
// }
