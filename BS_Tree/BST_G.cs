namespace BinarySearchTree_SchoolAssignment
{
    public interface BST_G<T> where T : IComparable<T>
    {
        /// <summary>
        /// Lägger till ny nod till trädet.
        /// </summary>
        /// <param name="value"></param>
        public void Insert(T value);

        /// <summary>
        /// Kontrollerar om ett värde redan finns i trädet.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>En bool</returns>
        public bool Exists(T value);

        /// <summary>
        /// Returnerar antal noder i trädet.
        /// </summary>
        /// <returns>Ett heltal</returns>
        public int Count();
    }
}