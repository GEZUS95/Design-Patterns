namespace Assignment2
{
    class PencilSharpener : IPencilSharpener
    {
        public void Sharpen(IPencil pencil)
        {
            pencil.AfterSharpening();
        }
    }
}
