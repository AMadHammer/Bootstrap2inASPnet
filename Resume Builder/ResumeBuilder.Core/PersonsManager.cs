using ResumeBuilder.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//namespace ResumeBuilder.Core
//{
//    public class PersonsManager : ResumeBuilder.Core.IPersonsManager
//    {
//        /// <summary>
//        /// Adds a new Person.
//        /// Omitting the displayName will create a display name using the Last, First format.
//        /// </summary>
//        /// <param name="first">First Name</param>
//        /// <param name="last">Last Name</param>
//        /// <param name="login">Login Name</param>
//        /// <param name="displayName">Display Name (optional)</param>
//        /// <returns></returns>
//        public IPerson AddPerson(string first, string last, string login, string displayName = "")
//        {
//            IPerson result = null;

//            using (CardinalCoreDDDContext context = new CardinalCoreDDDContext())
//            {
//                var person = new Person(first, last, login);

//                if (!String.IsNullOrEmpty(displayName))
//                {
//                    person.DisplayName = displayName;
//                }

//                result = context.Persons.Add(person);

//                context.SaveChanges();
//            }

//            return result;
//        }

//        /// <summary>
//        /// Updates a Person.
//        /// </summary>
//        /// <param name="personId">The unique id of an existing person</param>
//        /// <param name="first">First Name</param>
//        /// <param name="last">Last Name</param>
//        /// <param name="login">Login Name</param>
//        /// <param name="displayName">Display Name (optional)</param>
//        /// <returns></returns>
//        public IPerson UpdatePerson(Guid personId, string first, string last, string login, string displayName = "")
//        {
//            IPerson result = null;

//            using (CardinalCoreDDDContext context = new CardinalCoreDDDContext())
//            {
//                var person = context.Persons.FirstOrDefault(x => x.PersonID.Equals(personId));

//                if (person != null)
//                {
//                    person.FirstName = first;
//                    person.LastName = last;
//                    person.LoginName = login;

//                    if (!String.IsNullOrEmpty(displayName))
//                    {
//                        person.DisplayName = displayName;
//                    }
//                    else
//                    {
//                        person.UpdateDisplayName();
//                    }

//                    result = person;

//                    context.SaveChanges();
//                }                
//            }

//            return result;
//        }

//        /// <summary>
//        /// Gets a Person by database id
//        /// </summary>
//        /// <param name="personId">The unique id of an existing person</param>
//        /// <returns></returns>
//        public IPerson GetPerson(Guid personId)
//        {
//            IPerson result = null;

//            using (CardinalCoreDDDContext context = new CardinalCoreDDDContext())
//            {
//                result = context.Persons.FirstOrDefault(x => x.PersonID.Equals(personId));
//            }

//            return result;
//        }

//        /// <summary>
//        /// Returns a list of Person items where the first and last name match.
//        /// </summary>
//        /// <param name="first">First Name</param>
//        /// <param name="last">Last Name</param>
//        /// <returns></returns>
//        public List<IPerson> GetPersons(string first, string last)
//        {
//            List<IPerson> result = new List<IPerson>();

//            using (CardinalCoreDDDContext context = new CardinalCoreDDDContext())
//            {
//                result = context.Persons.Where(x => x.FirstName.Equals(first, StringComparison.InvariantCultureIgnoreCase) && x.LastName.Equals(last, StringComparison.InvariantCultureIgnoreCase)).AsEnumerable().Cast<IPerson>().ToList();
//            }

//            return result;
//        }

//        /// <summary>
//        /// Returns a list of Person items where login name matches.
//        /// </summary>
//        /// <param name="login">Login Name</param>
//        /// <returns></returns>
//        public List<IPerson> GetPersons(string login)
//        {
//            List<IPerson> result = new List<IPerson>();

//            using (CardinalCoreDDDContext context = new CardinalCoreDDDContext())
//            {
//                result = context.Persons.Where(x => x.LoginName.Equals(login, StringComparison.InvariantCultureIgnoreCase)).AsEnumerable().Cast<IPerson>().ToList();
//            }

//            return result;
//        }

//        /// <summary>
//        /// Returns a list of all Person items
//        /// </summary>
//        /// <returns></returns>
//        public List<IPerson> GetAllPersons()
//        {
//            List<IPerson> result = new List<IPerson>();

//            using (CardinalCoreDDDContext context = new CardinalCoreDDDContext())
//            {
//                result = context.Persons.AsEnumerable().Cast<IPerson>().ToList();
//            }

//            return result;
//        }

//        /// <summary>
//        /// Removes a Person.
//        /// </summary>
//        /// <param name="personId">The unique id of an existing person</param>
//        public void DeletePerson(Guid personId)
//        {
//            using (CardinalCoreDDDContext context = new CardinalCoreDDDContext())
//            {
//                var person = context.Persons.FirstOrDefault(x => x.PersonID.Equals(personId));

//                if (person != null)
//                {
//                    context.Persons.Remove(person);
//                }

//                context.SaveChanges();
//            }
//        }
//    }
//}
