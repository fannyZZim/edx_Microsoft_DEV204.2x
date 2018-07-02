namespace edx_Microsoft_DEV204.2x.Mod2_SA_Lab
{
    abstract class Person
    {
       // Creates integer variable called "personCount" and assigns value to 1
        private static int personCount = 1;

        // 2 private member variables: personName, personBaseSalary, and personId
        private string personName;
        private int personId;

        // Public properties
        public string Name
        {
            get
            {
                return personName;
            }

            set
            {
                personName = value;
            }
        }
        public int ID
        {
            get
            {
                return personId;
            }

            set
            {
                personId = value;
            }
        }

        // Constructor
        public person(String name)
        {
            this.Name = name;
            this.ID = personCount++;
        }

        // This method returns the person's name
        public String getName()
        {
            return this.Name;
        }

        // This method returns the person's ID
        public int getPersonID()
        {
            return this.ID;
        }

        // This method returns the person's ID and Name
        public String toString()
        {
            return this.ID + " " + this.Name;
        }

        // Abstract method
        public abstract String personStatus();
     
    }
}