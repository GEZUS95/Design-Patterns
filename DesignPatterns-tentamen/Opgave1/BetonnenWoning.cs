namespace Opgave1
{
    public class BetonnenWoning : BasisWoning
    {
        public override void DakPlaatsen()
        {
            System.Console.WriteLine("betonnen dak plaatsen");
        }

        public override void MurenPlaatsen()
        {
            System.Console.WriteLine("betonnen muren plaatsen");
        }
    }
}