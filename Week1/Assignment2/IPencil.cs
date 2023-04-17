namespace Assignment2
{
    interface IPencil
    {
        bool CanWrite { get; }
        void Write(string message);
        void AfterSharpening();
    }
}
