using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assistente_Virtual.Maths
{
    public static class AdvancedMath 
    {    
        //The Lerp returns the a Value between  A and B using the t
        public static float Lerp(float a,float b,float t)
        {            
            return (1.0f-t) * a + b * t;
        }
        //The InverseLerp return the t using the value
        public static float InverseLerp(float a, float b, float v)
        {
            return (v - a) / (b - a); 
        }
    }
}
