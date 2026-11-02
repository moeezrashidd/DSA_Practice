using System;




class Program
{

    public static void Main(string[] args)
    {
        Task1.LinkListCreation task1 = new Task1.LinkListCreation();
        task1.Run(args);


        Task2.linkListInsertion task2 = new Task2.linkListInsertion();

        task2.Run(args);

        Task3.doublyListCreation task3 = new Task3.doublyListCreation();
        task3.Run(args);
    }
}



