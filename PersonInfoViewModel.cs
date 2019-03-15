using System.ComponentModel;
using System.Runtime.CompilerServices;
using MoshchytskyiSharp02.Annotations;

namespace MoshchytskyiSharp02
{
    // ReSharper disable ArrangeAccessorOwnerBody
    class PersonInfoViewModel : INotifyPropertyChanged
    {
        private readonly Person _person;

        public string Name => $"Name:\n{_person.Name}";
        public string Surname => $"Surname:\n{_person.Surname}";
        public string Email => $"E-Mail:\n{_person.Email}";
        public string BirthDate => $"Birthday:\n{_person.Birthday.ToShortDateString()}";
        public string SunSign => $"Sun sign:\n{_person.SunSign}";
        public string ChineseSign => $"Chinese sign:\n{_person.ChineseSign}";
        public string IsBirthday => $"Today is {(_person.IsBirthday ? "" : "not ")}your birthday";
        public string IsAdult => $"You are {(_person.IsAdult? "" : "not ")}adult";

        public PersonInfoViewModel(Person person)
        {
            _person = person;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        

        #region Implementation
        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
