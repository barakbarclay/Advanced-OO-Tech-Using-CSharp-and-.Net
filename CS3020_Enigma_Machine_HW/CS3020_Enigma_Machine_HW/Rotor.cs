using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3020_Enigma_Machine_HW
{
    class Rotor
    {
        public List<int> offsets = new List<int>();
        public int currentPosition;
        public int startingPosition;

        public Rotor(List<int> offsets, int startingPosition)
        {
            this.offsets = offsets;
            this.currentPosition = startingPosition;
            this.startingPosition = startingPosition;
            for (int i = 0; i < startingPosition; i++)
            {
                RotateSelfToStartingPosition();
            }
        }
        
        //Path through rotor forwards
        public int InputDigitToOutputForwards(int inputIndex)
        {
            //If else takes care of when the path shifts from 0 to 9 or vice versa
            if (inputIndex + offsets[inputIndex] < offsets.Count)
            {
                return inputIndex + offsets[inputIndex];
            }
            else
            {
                return inputIndex + offsets[inputIndex] - offsets.Count;
            }
        }

        //Path through rotor backwards
        public int InputDigitToOutputBackwards(int inputIndex)
        {
            for (int i = 0; i < offsets.Count; i++)
            {
                //If else takes care of when the path shifts from 0 to 9 or vice versa
                if (i + offsets[i] >= offsets.Count)
                {
                    //Since index is path start going forwards, it's the path end going backwards
                    if (i + offsets[i] - offsets.Count == inputIndex)
                    {
                        return i;
                    }
                }
                else
                {
                    //Since index is path start going forwards, it's the path end going backwards
                    if (i + offsets[i] == inputIndex)
                    {
                        return i;
                    }
                }
            }
            return 0;
        }

        //Rotates list to starting position
        void RotateSelfToStartingPosition()
        {
            this.offsets.Insert(0, this.offsets.Last());
            this.offsets.RemoveAt(this.offsets.Count - 1);
        }
    }
}
