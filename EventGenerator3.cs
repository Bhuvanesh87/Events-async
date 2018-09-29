using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Delegates
{
    public delegate void LinkToEventHandler2(int i);
    class MaleStudent
    {
        string name;
        int Marks;
        public MaleStudent(string nameArg, int marks)
        {
            name = nameArg;
            Marks = marks;
        }
        public void MyActionItem(int i)
        {
            if (i == 1)
                Console.WriteLine("{0} Got Admission. He must pay fees", name);
            else
                Console.WriteLine( "{0} did not Get Admission. He must lookout for other college", name);
        }
        public int GetMarks()
        {
            return Marks;
        }
    }
    class FemaleStudent
    {
        string name;
        int Marks;
        public FemaleStudent(string nameArg, int marks)
        {
            name = nameArg;
            Marks = marks;
        }
        public void MyActionItem(int i)
        {
            if (i == 1)
                Console.WriteLine("{0} got Admission. He must pay fees", name);
            else
                Console.WriteLine("{0} did not Get Admission. He must lookout for other college", name);
        }
        public int GetMarks()
        {
            return Marks;
        }
    }
    class EventGenerator3
    {
        public static event LinkToEventHandler2 AdmissionDeniedEvt;
        public static event LinkToEventHandler2 AdmissionGrantedEvt;
        public static void Main()
        {
            MaleStudent Bhuvanesh = new MaleStudent("Bhuvanesh", 95);
            MaleStudent Ankur = new MaleStudent("Ankur", 89);
            MaleStudent Krishna = new MaleStudent("Krishna", 91);

            FemaleStudent Shilpa = new FemaleStudent("Shilpa", 92);
            FemaleStudent Rani = new FemaleStudent("Rani", 88);
            FemaleStudent jhansi = new FemaleStudent("Jhansi", 91);

            if (Bhuvanesh.GetMarks() >= 90)
                AdmissionGrantedEvt += new LinkToEventHandler2(Bhuvanesh.MyActionItem);
            else
                AdmissionDeniedEvt += new LinkToEventHandler2(Bhuvanesh.MyActionItem);

            if (Ankur.GetMarks() >= 90)
                AdmissionGrantedEvt += new LinkToEventHandler2(Ankur.MyActionItem);
            else
                AdmissionDeniedEvt += new LinkToEventHandler2(Ankur.MyActionItem);

            if (Krishna.GetMarks() >= 90)
                AdmissionGrantedEvt += new LinkToEventHandler2(Krishna.MyActionItem);
            else
                AdmissionDeniedEvt += new LinkToEventHandler2(Krishna.MyActionItem);

            if (Shilpa.GetMarks() >= 90)
                AdmissionGrantedEvt += new LinkToEventHandler2(Shilpa.MyActionItem);
            else
                AdmissionDeniedEvt += new LinkToEventHandler2(Shilpa.MyActionItem);

            if (Rani.GetMarks() >= 90)
                AdmissionGrantedEvt += new LinkToEventHandler2(Rani.MyActionItem);
            else
                AdmissionDeniedEvt += new LinkToEventHandler2(Rani.MyActionItem);

            if (jhansi.GetMarks() >= 90)
                AdmissionGrantedEvt += new LinkToEventHandler2(jhansi.MyActionItem);
            else
                AdmissionDeniedEvt += new LinkToEventHandler2(jhansi.MyActionItem);
            SendEvent();
        }
        public static void SendEvent()
        {
            if (AdmissionGrantedEvt != null)
                  AdmissionGrantedEvt(1);
            if (AdmissionDeniedEvt != null)
                  AdmissionDeniedEvt(0);
            Console.Read();
        }
    }
}
