namespace NoMansSky.Api.Definitions
{
    public unsafe interface IVirtualArray<T> : IMemoryObject
    {
        /// <summary>
        /// The number of elements in the array
        /// </summary>
        public int Count { get; }

        public T* this[int index]
        {
            get => GetElement(index);
            set => SetElement(index, value);
        }

        /// <summary>
        /// Returns the element at this index.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T* GetElement(int index);

        /// <summary>
        /// Set the value of the element at this index.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="valueToSet"></param>
        public void SetElement(int index, T valueToSet);

        /// <summary>
        /// Set the value of the element at this index.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="valueToSet"></param>
        public void SetElement(int index, T* valueToSet);
    }
}
