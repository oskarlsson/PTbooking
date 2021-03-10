using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTbooking
{   

    public class Activities //:Person;
    {
        public string selfTraining;
        public int selfTrainingMaxSize;
        public string groupTraining;
        public int groupTrainingMaxSize;
        public string ptTraining;
        public int ptTrainingMaxSize;
        public string ptConsultation;
        public int ptConsultationMaxSize;

        private List<Person> selfTraining = new List<Person>();
        private const int selfTrainingMaxSize = 10;
        
        public bool addToSelfTraining(Person p) {
            if(selfTraining.Count >= selfTrainingMaxSize) {
                return false;
            }
            selfTraining.Add(p);
            return true;
        }

        private List<Person> groupTraining = new List<Person>();
        private const int selfTrainingMaxSize = 6;
        
        public bool addToGroupTraining(Person p) {
            if(groupTraining.Count >= groupTrainingMaxSize) {
                return false;
            }
            groupTraining.Add(p);
            return true;
        }

        private List<Person> ptTraining = new List<Person>();
        private const int ptTrainingMaxSize = 5;
        
        public bool addToPtTraining(Person p) {
            if(ptTraining.Count >= ptTrainingMaxSize) {
                return false;
            }
            ptTraining.Add(p);
            return true;
        }

        private List<Person> ptConsultation = new List<Person>();
        private const int ptConsultationMaxSize = 3;
        
        public bool addToPtConsultation(Person p) {
            if(ptConsultation.Count >= ptConsultationMaxSize) {
                return false;
            }
            ptConsultation.Add(p);
            return true;
        }
}
