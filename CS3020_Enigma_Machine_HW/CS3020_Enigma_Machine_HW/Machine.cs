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

        public Machine(Rotor left, int leftStartingPosition, Rotor middle, int middleStartingPosition, Rotor right, int rightStartingPosition, Reflector reflector)
        {
            this.left = left;
            for (int i = 0; i < leftStartingPosition; i++)
                left.Rotate();
            this.left.startingPosition = leftStartingPosition;
            this.middle = middle;
            for (int i = 0; i < middleStartingPosition; i++)
                middle.Rotate();
            this.middle.startingPosition = middleStartingPosition;
            this.right = right;
            for (int i = 0; i < rightStartingPosition; i++)
                right.Rotate();
            this.right.startingPosition = rightStartingPosition;
            this.reflector = reflector;
        }

        //Returns output digit after traveling through rotors, reflector, and backwards through rotors
        //Also rotates right rotor (others are rotated based on right rotors position)
        public int InputDigitToOutput(int inputIndex)
        {
            int outputDigit = right.InputDigitToOutputForwards(middle.InputDigitToOutputForwards(left.InputDigitToOutputForwards(inputIndex)));
            outputDigit = reflector.InputDigitToOutput(outputDigit);
            outputDigit = left.InputDigitToOutputBackwards(middle.InputDigitToOutputBackwards(right.InputDigitToOutputBackwards(outputDigit)));

            Rotate(right);
            return outputDigit;
        }

        //Rotates given rotor and checks for cases below
        void Rotate(Rotor rotor)
        {
            rotor.Rotate();
            //Rotates to 0 if current position = 10
            if (rotor.currentPosition == rotor.offsets.Count)
            {
                rotor.currentPosition = 0;
            }
            //Rotates middle after full rotation of right
            if (rotor.currentPosition == rotor.startingPosition && rotor == right)
            {
                Rotate(middle);
            }
            //Rotates left after full rotation of middle
            else if (rotor.currentPosition == rotor.startingPosition && rotor == middle)
            {
                Rotate(left);
            }
        }
    }
}
