using System.Collections.Generic;
using System.IO;
using System;

namespace cse210_04.Game.Casting
{

        // 1) Add the class declaration. Use the following class comment. Make sure you
        //    inherit from the Actor class.

        // An item of cultural or historical interest.
        // The responsibility of an Artifact is to provide a message about itself.
        public class Artifact:Actor{
            private int score = 0;

        

        
            // Constructs a new instance of Artifact.
            public Artifact(){

            }
        
            // Gets the artifact's message.
            // The message as a string.
            public int GetScore(){
                
                return score;

            }
        
            // Sets the artifact's message to the given value.
            // The given message.
            public void SetScore(int score){
                this.score = score;

            }
        }
}