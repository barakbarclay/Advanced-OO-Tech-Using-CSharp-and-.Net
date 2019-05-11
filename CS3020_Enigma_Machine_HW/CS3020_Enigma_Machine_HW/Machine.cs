using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3020_Enigma_Machine_HW
{
    class Machine
    {
        Rotor left;
        Rotor middle;
        Rotor right;
        Reflector reflector;

        public Machine(Rotor left, Rotor middle, Rotor right, Reflector reflector)
        {
            this.left = left;
            this.middle = middle;
            this.right = right;
            this.reflector = reflector;
        }

        //Returns output digit after traveling through rotors, reflector, and backwards through rotors
        //Also rotates right rotor (others are rotated based on right rotors position)
        public int InputDigitToOutput(int inputIndex)
        {
            int outputDigit = right.InputDigitToOutputForwards(middle.InputDigitToOutputForwards(left.InputDigitToOutputForwards(inputIndex)));
            outputDigit = reflector.InputDigitToOutput(outputDigit);
            outputDigit = left.InputDigitToOutputBackwards(middle.InputDigitToOutputBackwards(right.InputDigitToOutputBackwards(outputDigit)));
            RotateRotor(right);
            return outputDigit;
        }

        //Rotates given rotor
        void RotateRotor(Rotor rotor)
        {
            rotor.offsets.Insert(0, rotor.offsets.Last());
            rotor.offsets.RemoveAt(rotor.offsets.Count - 1);
            rotor.currentPosition++;
            //Rotates to 0 if current position = 10
            if (rotor.currentPosition == rotor.offsets.Count)
            {
                rotor.currentPosition = 0;
            }
            //Rotates middle after full rotation of right
            if (rotor.currentPosition == rotor.startingPosition && rotor == right)
            {
                RotateRotor(middle);
            }
            //Rotates left after full rotation of middle
            else if (rotor.currentPosition == rotor.startingPosition && rotor == middle)
            {
                RotateRotor(left);
            }
        }
    }
}
