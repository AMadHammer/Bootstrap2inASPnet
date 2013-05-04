using System;
namespace ResumeBuilder.Core
{
    public interface IPersonsManager
    {
        IPerson AddPerson(string first, string last, string login, string displayName = "");
        void DeletePerson(Guid personId);
        System.Collections.Generic.List<IPerson> GetAllPersons();
        IPerson GetPerson(Guid personId);
        System.Collections.Generic.List<IPerson> GetPersons(string first, string last);
        System.Collections.Generic.List<IPerson> GetPersons(string login);
        IPerson UpdatePerson(Guid personId, string first, string last, string login, string displayName = "");
    }
}


