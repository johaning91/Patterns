using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Mediator
{
    public abstract class IColleage
    {
        private IMediator _mediator;
        public IMediator Mediator
        {
            get;
        }

        public IColleage(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void Comunicate(string message)
        {
            _mediator.Send(message, this);
        }

        public abstract void Receive(string message);
    }

    public interface IMediator
    {
        public void Send(string message, IColleage colleage);
    }

    public class MyMediator : IMediator
    {
        private List<IColleage> colleages;

        public MyMediator()
        {
            colleages = new List<IColleage>();
        }

        public void Add(IColleage colleage)
        {
            this.colleages.Add(colleage);
        }

        public void Send(string message, IColleage colleage)
        {
            foreach(IColleage c in colleages)
            {
                if(colleage != c)
                {
                    colleage.Receive(message);
                }
            }
        }
    }

    public class UserAdmin : IColleage
    {
        public UserAdmin(IMediator mediator) : base(mediator)
        {

        }
        public override void Receive(string message)
        {
            Console.WriteLine("Admin receive: " + message);
        }
    }

    public class User : IColleage
    {
        public User(IMediator mediator): base(mediator)
        {

        }
        public override void Receive(string message)
        {
            Console.WriteLine("User receive: " + message);
        }
    }
}
 