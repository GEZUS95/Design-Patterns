using System;

namespace Opgave1
{
    public abstract class BasisWoning
    {
        public void WoningBouwen()
        {
            FunderingPlaatsen();
            MurenPlaatsen();
            DakPlaatsen();
            RamenPlaatsen();
        }

       public void FunderingPlaatsen()
        {
            Console.WriteLine("fundering met beton en ijzer plaatsen");
        }

        public void RamenPlaatsen()
        {
            Console.WriteLine("glazen ramen plaatsen");
        }

        public abstract void MurenPlaatsen();


        public abstract void DakPlaatsen();
    }
}