using System.Collections.Generic;

namespace CS3020_Enigma_Machine_HW
{
    class Reflector
    {
        List<int> outputList = new List<int>();

        public Reflector(List<int> outputList)
        {
            this.outputList = outputList;
        }

        //Path through reflector
        public int InputDigitToOutput(int inputIndex)
        {
            return outputList[inputIndex];
        }
    }
}
