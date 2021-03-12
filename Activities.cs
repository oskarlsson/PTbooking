using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTbooking
{

    class Activities : Person
    {   // each activity created as a list
        // each list has limited places >name+MaxSize<
        // when one of the lists is selected by the members the places available will be less by 1
        private readonly List<string> selfTrainingList = new List<string>();
        private const int selfTrainingMaxSize = 10;

        public bool addToSelfTraining(string name)
        {
            if (selfTrainingList.Count >= selfTrainingMaxSize)
            {
                return false;
            }
            else
            {
                selfTrainingList.Add(name);
                Console.WriteLine(string.Join(", ", selfTrainingList));                
                return true;
            }
            
        }

        private List<string> groupTrainingList = new List<string>();
        private const int groupTrainingMaxSize = 6;

        public bool addToGroupTraining(string name)
        {
            if (groupTrainingList.Count >= groupTrainingMaxSize)
            {
                return false;
            }
            groupTrainingList.Add(Name);
            return true;
        }

        private List<string> ptTrainingList = new List<string>();
        private const int ptTrainingMaxSize = 5;

        public bool addToPtTraining(string name)
        {
            if (ptTrainingList.Count >= ptTrainingMaxSize)
            {
                return false;
            }
            ptTrainingList.Add(Name);
            return true;
        }

        private List<string> ptConsultationList = new List<string>();
        private const int ptConsultationMaxSize = 3;

        public bool addToPtConsultation(string name)
        {
            if (ptConsultationList.Count >= ptConsultationMaxSize)
            {
                return false;
            }
            ptConsultationList.Add(Name);
            return true;
        }
    }
}
