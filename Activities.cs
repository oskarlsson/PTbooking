using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTbooking
{
    class Activities : Menu
    {
        public List<string> selfTrainingList = new List<string>();
        private const int selfTrainingMaxSize = 2;

        public bool AddToSelfTraining(string name)
        {
            if (selfTrainingList.Count >= selfTrainingMaxSize)
            {
                Console.WriteLine("Fully booked");
                return false;
            }
            else
            {
                selfTrainingList.Add(name);
                Console.WriteLine("Booked for selftraining");
                Console.WriteLine(string.Join(", ", selfTrainingList));
                return true;
            }  
        }

        private List<string> groupTrainingList = new List<string>();
        private const int groupTrainingMaxSize = 6;

        public bool AddToGroupTraining(string name)
        {
            if (groupTrainingList.Count >= groupTrainingMaxSize)
            {
                return false;
            }
            groupTrainingList.Add(name);
            Console.WriteLine(string.Join(", ", groupTrainingList));
            return true;
        }

        private List<string> ptTrainingList = new List<string>();
        private const int ptTrainingMaxSize = 5;

        public bool AddToPtTraining(string name)
        {
            if (ptTrainingList.Count >= ptTrainingMaxSize)
            {
                return false;
            }
            ptTrainingList.Add(name);
            Console.WriteLine(string.Join(", ", ptTrainingList));
            return true;
        }

        private List<string> ptConsultationList = new List<string>();
        private const int ptConsultationMaxSize = 3;

        public bool AddToPtConsultation(string name)
        {
            if (ptConsultationList.Count >= ptConsultationMaxSize)
            {
                return false;
            }
            ptConsultationList.Add(name);
            Console.WriteLine(string.Join(", ", ptConsultationList));
            return true;
        }
    }
}
