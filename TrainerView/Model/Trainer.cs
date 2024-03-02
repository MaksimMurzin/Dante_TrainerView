namespace TrainerView.Model
{
    public class Trainer
    {
        public int Id { get; set; }
        public Course Course { get; set; }
        public int MasterScheduleID {  get; set; }
        public string Reference { get; set; }
        public string CourseName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int DayCount { get; set; }
        public Status Status { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
    }

    public class Course
    {
        public int Id { get; set; }
        public string Reference { get; set; }
        public string Name { get; set; }
    }

    public class Status
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
