using System;

namespace assignment_3b_and_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            MyStack myStack = new MyStack();
            try
            {
                do
                {
                    Console.WriteLine("Enter the operation\n1.Insert\n2.Extract\n3.Display\n4.Clone");
                    i = Convert.ToInt32(Console.ReadLine());
                    switch (i)
                    {
                        case 1:
                            Console.WriteLine("Enter new element to insert");
                            int number = Convert.ToInt32(Console.ReadLine());
                            myStack.push(number);
                            break;
                        case 2:
                            myStack.pop();
                            break;
                        case 3:
                            myStack.display();
                            break;
                        case 4:
                            MyStack copyMyStack = myStack.Clone() as MyStack;
                            copyMyStack.display();
                            break;
                        default:
                            Console.WriteLine("Invalid option selected.");
                            break;
                    }
                } while (i <= 4);
            }
            catch (StackException st)
            {
                Console.WriteLine(st.Message);
            }
        }
    }
}
