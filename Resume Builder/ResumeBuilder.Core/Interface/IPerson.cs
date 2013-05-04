using System;



namespace ResumeBuilder.Core
{
    public interface IPerson
    {
        string DisplayName { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string LoginName { get; set; }
        Guid PersonID { get; set; }

        void UpdateDisplayName();
    }
}
