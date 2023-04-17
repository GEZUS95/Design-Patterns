namespace Assignment1
{
    interface IStack
    {
        void Push(int value);
        int Pop();
        bool Contains(int value);
        int Count { get; }
        bool IsEmpty { get; }
    }
}
