namespace StudentsAndTeacher
{
    class Lecturer : ISubject
    {
        List<IObserver> observers;
        public Lecturer()
        {
            observers = new List<IObserver>();
        }
        public void addObserver(IObserver observer)
        {
            observers.Add(observer);
        }
        public void removeObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void studentSurvey()
        {
            notify();
        }

        public void notify()
        {
            foreach (IObserver observer in observers)
            {
                observer.update();
            }
        }
    }

}
