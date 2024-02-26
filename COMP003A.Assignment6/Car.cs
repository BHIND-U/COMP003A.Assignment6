using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.Assignment6
{
    /// <summary>
    /// Car extend the Vehicle class
    /// </summary>
    internal class Car : Vehicle
    {
        /***** constructors section *****/

        /***** methods section *****/
        /// <summary>
        /// Overrides the base Vehicle's definintion for GetInfo()
        /// </summary>

        public override void GetInfo()
        {
            Console.WriteLine($"I'm a {nameof(Car)}");
            Console.WriteLine("I don't want to disclose my information.");
        }
    }
}
