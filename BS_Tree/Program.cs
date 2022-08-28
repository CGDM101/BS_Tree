using BinarySearchTree_SchoolAssignment;

Console.WriteLine("Hej skogen!");
Console.WriteLine();


/* ============  ETT BALANSERAT BINÄRT SÖKTRÄD: =====================

                            1990      

                 /                         \
                /                           \

             1984                           2005

         /          \                   /          \ 
        /            \                 /            \

      1982           1986            1997          2013

     /     \       /     \          /     \       /     \
    /       \     /       \        /       \     /       \

  1981     1983   -      1987    1993     2001 2009      2017

=======================================================================
 */


BinarySearchTree<int> myTree = new BinarySearchTree<int>();
int[] numbersToBeInserted = new int[] { 1981, 1982, 1983, 1984, 1986, 1987, 1990, 1993, 1997, 2001, 2005, 2009, 2013, 2017 };

myTree.Insert(numbersToBeInserted[8]);
myTree.Insert(numbersToBeInserted[1]);
myTree.Insert(numbersToBeInserted[10]);
myTree.Insert(numbersToBeInserted[4]);
myTree.Insert(numbersToBeInserted[5]);
myTree.Insert(numbersToBeInserted[11]);
myTree.Insert(numbersToBeInserted[2]);
myTree.Insert(numbersToBeInserted[7]);
myTree.Insert(numbersToBeInserted[6]);
myTree.Insert(numbersToBeInserted[3]);
myTree.Insert(numbersToBeInserted[12]);
myTree.Insert(numbersToBeInserted[9]);
myTree.Insert(numbersToBeInserted[13]);
myTree.Insert(numbersToBeInserted[0]);

Console.WriteLine();
Console.WriteLine("Antal noder i trädet: " + myTree.Count()); // Funkar även om man försöker lägga in dublett.

Console.WriteLine();
Console.WriteLine("1981 finns? " + myTree.Exists(1981));
Console.WriteLine("2021 finns? " + myTree.Exists(2021));
Console.WriteLine();

myTree.Print();