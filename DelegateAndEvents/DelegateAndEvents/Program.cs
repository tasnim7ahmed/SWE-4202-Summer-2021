using System;

namespace DelegateAndEvents
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // DelegateExample delegateExample = new DelegateExample();

            Student student = new Student(1, "Tasnim");
            StudentAdmission studentAdmission = new StudentAdmission(); //Publisher

            MailService mailService = new MailService(); //Subscriber
            SMSService sMSService = new SMSService(); //Subscriber

            studentAdmission.StudentAdmitted += mailService.OnStudentAdmitted;
            studentAdmission.StudentAdmitted += sMSService.OnStudentAdmitted;


            studentAdmission.Admit(student);
        }
    }

    //Subscriber
    //Event Receiver
    public class MailService
    {
        public void OnStudentAdmitted(object sender, EventArgs e)
        {
            Console.WriteLine("E-mail is sent...");
        }
    }

    public class SMSService
    {
        public void OnStudentAdmitted(object sender, EventArgs e)
        {
            Console.WriteLine("SMS is sent...");
        }
    }

}
