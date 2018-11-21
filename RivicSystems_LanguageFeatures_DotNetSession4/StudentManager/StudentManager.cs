namespace StudentLibrary
{
    public abstract class StudentManager
    {
        public double GetStudentTotalFeePaid(Student objStudent)
        {
            int discount = ApplyStateTaxes(objStudent);
            return 1000 - (1000 * discount) / 100;
            
        }

        protected abstract int ApplyStateTaxes(Student objStudent);
     
        public void setInfo()
        {
            //do some thing;
        }
    }
}
