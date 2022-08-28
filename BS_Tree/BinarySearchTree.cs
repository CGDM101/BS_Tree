namespace BinarySearchTree_SchoolAssignment
{
    public class BinarySearchTree<T> : BST_G<T> where T : IComparable<T> // Constraint att T är IComparable.
    {
        private const string isAdded = " tillagt.";
        private const string balance = "Balans: ";

        /// <summary>
        /// Field för trädets rot.
        /// </summary>
        private Node<T>? Root = null;

        /// <summary>
        /// Field för att hålla koll på antalet noder i trädet.
        /// </summary>
        private int count = 0;

        public int Count()
        {
            return count;
        }

        public bool Exists(T value)
        {
            Node<T>? currentNode = Root;
            if (Root == null)
            {
                return false; // För då finns inget i trädet.
            }
            while (currentNode != null) // Leta igenom trädet efter värdet.
            {
                if (currentNode.Data.CompareTo(value) == 0)
                {
                    return true;
                }
                else if (currentNode.Data.CompareTo(value) > 0) // Gå vänster.
                {
                    currentNode = currentNode.LeftChild;
                }
                else if (currentNode.Data.CompareTo(value) < 0) // Kolla höger.
                {
                    currentNode = currentNode.RightChild;
                }
            }
            return false; // Värdet finns inte.
        }

        public void Insert(T value)
        {
            if (Exists(value))
            {
                return; // Om värdet redan finns, insert ej ny nod (får inte finnas dubletter i binärt sökträd).
            }

            if (Root == null) // om roten är null...
            {
                Root = new Node<T>(value); // ... blir det aktuellt värde trädets rot.
                count++;
                Console.WriteLine(value + isAdded);
                Console.WriteLine(balance + Root.GetBalance()); // Alltid 0 eftersom detta är den enda noden.

                return;
            }

            var currentNode = Root; // Denna är nu currentNode.

            while (true) // Söka igenom trädet tills man hittar "ledig plats".
            {
                if (currentNode.Data.CompareTo(value) > 0) // Om värdet är lägre än rotens värde, gå till vänster.
                {
                    if (currentNode.LeftChild == null) // Om där är ledigt...
                    {
                        currentNode.LeftChild = new Node<T>(value); // ...skapa ny där
                        count++;
                        Console.WriteLine(value + BinarySearchTree<T>.isAdded);
                        Console.WriteLine(balance + Root.GetBalance());
                        return;
                    }
                    currentNode = currentNode.LeftChild; // Nu är denna nya nod currentNode.
                }
                else if (currentNode.Data.CompareTo(value) < 0) // Annars gå t höger.
                {
                    if (currentNode.RightChild == null)
                    {
                        currentNode.RightChild = new Node<T>(value);
                        count++;
                        Console.WriteLine(value + isAdded);
                        Console.WriteLine(balance + Root.GetBalance());
                        return;
                    }
                    currentNode = currentNode.RightChild;
                }
            }
        }

        public void Print()
        {
            Queue<Node<T>?> nodes = new Queue<Node<T>?>();
            Queue<Node<T>?> newNodes = new Queue<Node<T>?>();
            nodes.Enqueue(Root);
            int depth = 0;

            bool exitCondition = false;
            while (nodes.Count > 0 && !exitCondition)
            {
                depth++;
                newNodes = new Queue<Node<T>?>();

                string xs = "[";
                foreach (var maybeNode in nodes)
                {
                    string data = maybeNode == null ? " " : "" + maybeNode.Data;
                    if (maybeNode == null)
                    {
                        xs += "_, ";
                        newNodes.Enqueue(null);
                        newNodes.Enqueue(null);
                    }
                    else
                    {
                        Node<T> node = maybeNode;
                        string s = node.Data.ToString();
                        xs += s.Substring(0, Math.Min(4, s.Length)) + ", ";
                        if (node.LeftChild != null) newNodes.Enqueue(node.LeftChild);
                        else newNodes.Enqueue(null);
                        if (node.RightChild != null) newNodes.Enqueue(node.RightChild);
                        else newNodes.Enqueue(null);
                    }
                }
                xs = xs.Substring(0, xs.Length - 2) + "]";

                Console.WriteLine(xs);

                nodes = newNodes;
                exitCondition = true;
                foreach (var m in nodes)
                {
                    if (m != null) exitCondition = false;
                }
            }
        }
    }
}