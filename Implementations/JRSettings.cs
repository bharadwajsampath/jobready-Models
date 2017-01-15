namespace App.Models.Implementations
{



    public class Consumers
    {
        public string JobreadyURL { get; set; }
        public string Api { get; set; }
        public string Username { get; set; }
    }

    public class EndPoints
    {
        public string Attendees { get; set; }
        public string Events { get; set; }
        public string Event { get; set; }

        public string Courses { get; set; }
        public string Enrolments { get; set; }
        public string PartiesInThatCourseEvent { get; set; }
        public string Party { get; set; }
        public string PartyFileNotes { get; set; }
    }

    public class JRSettings
    {
        public Consumers Consumers { get; set; }
        public EndPoints EndPoints { get; set; }

        public EmailSettings EmailSettings { get; set; }
    }

    public class EmailSettings
    {
        public string ApiKey { get; set; }
        public string BaseUri { get; set; }
        public string RequestUri { get; set; }
        public string From { get; set; }
    }




}