using System;
using System.Collections.Generic;

namespace assignment1
{
    public class BatchProcessor
    {
        private List<BigDataLoader> _bigDataList = new List<BigDataLoader>();

        public void addObjectToList(BigDataLoader dataloader)
        {
            _bigDataList.Add(dataloader);
        }

        public void processList()
        {
            foreach (BigDataLoader item in _bigDataList)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("[ETL-proces started]");
                Console.ResetColor();
                item.etl();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("[ETL-proces finished]");
                Console.ResetColor();
                Console.WriteLine();
            }
        }
    }
}
