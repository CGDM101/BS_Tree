namespace BinarySearchTree_SchoolAssignment
{
    /// <summary>
    /// En generisk klass av typen T.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Node<T>
    {
        //  En nod består av datan samt två barn (som kan vara null, då är de lövnoder).
        public T Data { get; set; }
        public Node<T>? LeftChild { get; set; }
        public Node<T>? RightChild { get; set; }

        /// <summary>
        /// Konstruktor som har en generisk parameter (typen T)
        /// </summary>
        /// <param name="value"></param>
        public Node(T value)
        {
            this.LeftChild = null; // Default är att barnen är null.
            this.RightChild = null;

            this.Data = value; // Sätter Data till aktuellt value.
        }

        // Ett binärt sökträd är balanserat om det är jämt eller högst +- 1 i skillnad i djup.
        public int GetBalance()
        {
            int left = this.LeftChild == null ? 0 : this.LeftChild.GetBalance() + 1;
            int right = this.RightChild == null ? 0 : this.RightChild.GetBalance() + 1;
            return Math.Abs(right - left);
        }
    }
}