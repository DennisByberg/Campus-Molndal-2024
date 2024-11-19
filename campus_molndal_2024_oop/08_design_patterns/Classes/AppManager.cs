namespace campus_molndal_2024_oop._08_design_patterns.Classes
{
    public class AppManager
    {
        private static AppManager _instance;
        private bool _isTurnedOn;

        private AppManager() { }

        public static AppManager GetInstance()
        {
            return _instance ?? (_instance = new AppManager());
        }

        public void SetIsTurnedOn(bool value)
        {
            _isTurnedOn = value;
        }

        public bool GetIsTurnedOn()
        {
            return _isTurnedOn;
        }
    }
}
