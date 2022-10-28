using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Zz2.Overriding
{
    public class Fruit_Overriding
    {
        public Fruit_Overriding()
        {
            Debug.Log("1st Fruit Constructor Called");
        }


        public virtual void Chop_Overriding()
        {
            Debug.Log("The fruit has been chopped.");
        }

        public virtual void SayHello_Overriding()
        {
            Debug.Log("Hello, I am a fruit.");
        }
    }

    public class Apple_Overriding : Fruit_Overriding
    {
        public Apple_Overriding()
        {
            Debug.Log("1st Apple Constructor Called");
        }

        //These methods are overrides and therefore
        //can override any virtual methods in the parent
        //class.
        public override void Chop_Overriding()
        {
            base.Chop_Overriding();
            Debug.Log("The apple has been chopped.");
        }

        public override void SayHello_Overriding()
        {
            base.SayHello_Overriding();
            Debug.Log("Hello, I am an apple.");
        }
    }
}
