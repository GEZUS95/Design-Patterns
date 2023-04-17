namespace Opgave1
{
    public class GlazenWoning : BasisWoning
    {
        public override void DakPlaatsen()
        {
            System.Console.WriteLine("glazen dak plaatsen");
        }

        public override void MurenPlaatsen()
        {
            System.Console.WriteLine("glazen muren plaatsen");
        }
    }
}