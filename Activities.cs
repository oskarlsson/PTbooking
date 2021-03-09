using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTbooking
{
    class Activities
    {
        // Create a fields
        public string selfTraining;  
        public string groupTraining;
        public string ptTraining;
        public string ptConsultation;

        // Create a class constructor
        public Activities()
        {
            selfTraining = "Your time for self training and using the selected machines is successfully booked";
            groupTraining = "Your time for group training is successfully booked";
            ptTraining = "Your time for PT training is successfully booked";
            ptConsultation = "Your time for PT Consultation is successfully booked";
        }
    }
}
