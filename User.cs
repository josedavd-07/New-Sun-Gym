using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimmnasio
{
    class User
    {
        public string name { get; set; } 
        public int identification { get; set; }

        public float salary { get; set; }

        public int stratum { get; set; }

        public string selectedGender { get; set; }

        public float normalPayment;


        public float Calculations()
        {

            //Calculations
            float payment = 0;
            float discount = 0;

            //normal payment
            if (salary < 20000009)
            {
                normalPayment = 400000;
            }
            else if (salary < 5000000)
            {
                normalPayment = 60000;

            }
            else
            {
                normalPayment = 80000;
            }

            //Stratum discount

            if (stratum <= 2)
            {
                discount = 20;
            }
            else if (stratum <= 4)
            {
                discount = 15;
            }
            else
            {
                discount = 10;
            }

            //gender discount
            if (selectedGender.Equals("Female"))
            {
                discount += 5;
            }

            payment = normalPayment - (normalPayment * discount / 100);

            return payment;
        }
    }
}
