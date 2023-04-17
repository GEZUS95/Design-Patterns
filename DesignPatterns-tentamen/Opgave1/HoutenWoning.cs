namespace Opgave1
{
    public class HoutenWoning : BasisWoning
    {
        public override void DakPlaatsen()
        {
            System.Console.WriteLine("houten dak plaatsen");
        }

        public override void MurenPlaatsen()
        {
            System.Console.WriteLine("houten muren plaatsen");
        }
    }
}