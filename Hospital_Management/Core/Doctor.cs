public class Doctor
    {
        public static int TotalDoctors;
        public readonly string LicenseNumber;
        public required string Name { get; set; }

        static Doctor()
        {
            TotalDoctors = 0;
        }

        public Doctor(string licenseNumber)
        {
            LicenseNumber = licenseNumber;
            TotalDoctors++;
        }
    }