namespace Assignment05_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01:Question01

            // Q1 : What is an interface in C#?
            // Why do we use interfaces instead of depending on concrete classes directly?
            // Mention at least three benefits of using interfaces.

            // interface is contract that defines a set of methods and properties that a class must implement
            // to achieve abstraction and polymorphism
            // 1- Enable polymorphism without inheritance
            // 2- Remove tight coupling between classes
            // 3- Enable multiple inheritance
            #endregion

            #region Part01:Question02

            // a) Both IEnglishSpeaker and IArabicSpeaker define a method with the same signature
            // Since the Translator class implements both interfaces it provides only one public Greet() method
            // both prints same output


            // b) to handle it we use explicit interface implementation.

            //class Translator : IEnglishSpeaker, IArabicSpeaker
            //{
            //void IEnglishSpeaker.Greet()
            //{
            //    Console.WriteLine("Hello");
            //}

            //void IArabicSpeaker.Greet()
            //{
            //    Console.WriteLine("Ahlan");
            //}
            //}

            // c) No you cannot Because explicitly implemented methods are not public methods of the class itself
            // They are only accessible through the interface reference

            #endregion

            #region Part01:Question03

            // Shallow copy copies the object but keeps the same references inside it while deep copy creates new copies of all nested reference objects too
            // Use shallow copy when the object contains only value types or when shared references are acceptable use deep copy when you need full independence
            // The risk of shallow copy with reference type fields is that modifying the copied object's internal data will also affect the original object

            #endregion
        }
    }
}
